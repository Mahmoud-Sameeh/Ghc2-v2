using GHC2.Data;
using GHC2.Models;
using GHC2.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GHC2.Controllers
{
    [Authorize(Roles = "Patient")]

    public class PatientController : Controller
    {
        private readonly ApplicationDbContext context;
        public PatientController(ApplicationDbContext _context)
        {
            context = _context;
        }

        //id of the login patient
        Int64 PId ;
        public IActionResult Index()
        {
            PId = context.Patients.FirstOrDefault(z => z.IdentityId == User.FindFirst(ClaimTypes.NameIdentifier).Value).Nid;
            return RedirectToAction("GetPatientProfileReadonly");
        }
        public IActionResult GetPatientProfileReadonly()
        {
            PId = context.Patients.FirstOrDefault(z => z.IdentityId == User.FindFirst(ClaimTypes.NameIdentifier).Value).Nid;

            VMPatientProfile VMPatientProfile = new VMPatientProfile()
            {
                Diagnoses = context.Diagnoses.Where(e => e.PatientId == PId).ToList(),
                Radiations = context.Radiations.Where(e => e.PatientId == PId).ToList(),
                Analyses = context.Analyses.Where(e => e.PatientId == PId).ToList(),
                Doctors = context.Doctors.ToList(),
                patient = context.Patients.Where(e => e.Nid == PId).FirstOrDefault()
            };
            return View(VMPatientProfile);
        }
        public IActionResult GetPatientDiagnoseDescription(Int64 id)
        {
            Diagnose diagnose = context.Diagnoses.Where(e => e.Id == id).FirstOrDefault();
            Int64 diagnosePrescriptionID = context.DiagnosePrescriptions.Where(e => e.DiagnoseId == id).Select(e => e.PrescriptionId).FirstOrDefault();
            VMPatientDiagnosePrescription _VMPatientDiagnosePrescription = new VMPatientDiagnosePrescription()
            {
                diagnose = diagnose,
                PrescriptionMedicine = context.PrescriptionMedicines.Where(e => e.PrescriptionId == diagnosePrescriptionID).ToList(),
                medicines = context.Medicines.ToList(),
                patient = context.Patients.Find(diagnose.PatientId)
            };
            return View(_VMPatientDiagnosePrescription);
        }
        public IActionResult GetPatientAnalysesDetailsReadonly(Int64 id)
        {
            Analysis PatientAnalyses = context.Analyses.Where(e => e.Id == id).FirstOrDefault();
            PatientAnalyses.Patient = context.Patients.Where(e => e.Nid == PatientAnalyses.PatientId).FirstOrDefault();
            return View(PatientAnalyses);
        }
        public IActionResult GetPatientRadiationsDetailsReadonly(Int64 id)
        {
            Radiation PatientRadiation = context.Radiations.Where(e => e.Id == id).FirstOrDefault();
            PatientRadiation.Patient = context.Patients.Where(e => e.Nid == PatientRadiation.PatientId).FirstOrDefault();
            return View(PatientRadiation);
        }
        public IActionResult GetDoctors()
        {
            List<Doctor> doctors = context.Doctors.ToList();
            return View(doctors);
        }
        //[HttpGet]
        public IActionResult GetAppointmentAfter(Int64 id, string date1 = null)
        {
            Int64 id1 = id;
            string date11 = date1;
            DateTime d = new DateTime();

            if (date1 == null)
            {
                d = new DateTime(2021, 04, 25);
                //d = DateTime.Now;
                string x = d.TimeOfDay.ToString();
            }
            else
            {
                d = DateTime.Parse(date1);
                string x = d.TimeOfDay.ToString();
            }
            Appointment patientappointment = new Appointment()
            {
                Doc = context.Doctors.Where(e => e.Nid == id).FirstOrDefault(),

            };
            AppointmentsList appointmentsList = new AppointmentsList()
            {
                appointment = patientappointment,
                dateTimes = context.Appointments.Where(s => s.DocId == id && s.AppointmetDateTime.Date == d.Date).Select(s => s.AppointmetDateTime).ToList()
            };
            List<DateTime> mytime = new List<DateTime>();
            foreach (var item in appointmentsList.dateTimes)
            {
                mytime.Add(item);
            }
            return RedirectToAction("GetAppointment", new { id = id1, date1 = date11 });
            //  return View();
        }

        public IActionResult GetAppointment(Int64 id, string date1 = null)
        {

            DateTime d = new DateTime();

            if (date1 == null)
            {
                //d = new DateTime(2021,04,25);
                d = DateTime.Now;
                string x = d.TimeOfDay.ToString();
            }
            else
            {
                d = DateTime.Parse(date1);
                string x = d.TimeOfDay.ToString();
            }
            Appointment patientappointment = new Appointment()
            {
                Doc = context.Doctors.Where(e => e.Nid == id).FirstOrDefault(),
                AppointmetDateTime = d,
            };
            AppointmentsList appointmentsList = new AppointmentsList()
            {
                appointment = patientappointment,
                dateTimes = context.Appointments.Where(s => s.DocId == id && s.AppointmetDateTime.Date == d.Date).Select(s => s.AppointmetDateTime).ToList()
            };
            List<DateTime> mytime = new List<DateTime>();
            foreach (var item in appointmentsList.dateTimes)
            {
                mytime.Add(item);
            }
            return View(appointmentsList);
        }
        public IActionResult GetAppointmentProfile()
        {

            return View();
        }
        public IActionResult GetAppointmentPatient()
        {
            PId = context.Patients.FirstOrDefault(z => z.IdentityId == User.FindFirst(ClaimTypes.NameIdentifier).Value).Nid;

            GetPatientAppointmentsWithDoctors getPatientAppointmentsWithDoctors = new GetPatientAppointmentsWithDoctors()
            {
            appointments = context.Appointments.Where(e => e.PatientId == PId).ToList(),
                Doctors = context.Doctors.ToList(),

            };

            return View(getPatientAppointmentsWithDoctors);
        }

        //Action to save appointment request from patient
        public void SaveAppointRequest(Int64 docid, string AppointDateTime)
        {
            PId = context.Patients.FirstOrDefault(z => z.IdentityId == User.FindFirst(ClaimTypes.NameIdentifier).Value).Nid;

            Appointment appointment = new Appointment()
            {
                AppointmetDateTime = DateTime.Parse(AppointDateTime),
                //id is the id of login  patient
                PatientId = PId,
                DocId = docid,
                Accepted = "NO"

            };
            context.Appointments.Add(appointment);
            context.SaveChanges();

        }
        [HttpGet]
        public IActionResult EditPatientProfile(Int64 id)
        {
            Patient patient = context.Patients.Where(e => e.Nid == id).FirstOrDefault();
            return View(patient);
        }
        [HttpPost]
        public IActionResult EditPatientProfile(Patient patient)
        {
            Patient updated = context.Patients.Where(e => e.Nid == patient.Nid).FirstOrDefault();
            updated.Address = patient.Address;
            updated.Email = patient.Email;
            updated.Phone = patient.Phone;
            context.SaveChanges();

            return RedirectToAction("GetPatientProfileReadonly", new { id = patient.Nid });
        }

    }
}