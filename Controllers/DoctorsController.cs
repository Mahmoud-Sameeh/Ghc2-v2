using GHC2.Data;
using GHC2.Models;
using GHC2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace GHC2.Controllers
{
    [Authorize(Roles = "Doctor")]
    public class DoctorsController : Controller
    {
        private readonly ApplicationDbContext context;
        
        public DoctorsController(ApplicationDbContext _context)
        {
            context = _context;
        }
       
       
        Int64 docid;
        //public IActionResult DDD()
        //{
        //    return RedirectToAction("Index","Doctors");
        //}
     
        public IActionResult DoctorIndex()
        {
            docid = context.Doctors.FirstOrDefault(z => z.IdentityId == User.FindFirst(ClaimTypes.NameIdentifier).Value).Nid;
            ViewBag.TotalDoctorsCount = context.Doctors.Count();
            ViewBag.TotalAppoinmetsCount = context.Appointments.Where(e => e.DocId == docid).Select(e => e.Id).Count();
            ViewBag.TodayAppoinmetsCount = context.Appointments.Where(e => (e.DocId == docid)&&(e.AppointmetDateTime.Date== DateTime.Now.Date) ).Count();
            ViewBag.TotalPatientsCount = context.Diagnoses.Where(e => e.DocId == docid).Select(e => e.PatientId).Distinct().Count();
            VMIndex _VMIndex = new VMIndex()
            {
                UpcomingAppointments = context.Appointments.Where(e => (e.DocId == docid) && (e.Accepted == "NO")).OrderByDescending(e => e.AppointmetDateTime).ToList(),
                ToDayAppointments = context.Appointments.Where(e => (e.DocId == docid) && (e.AppointmetDateTime.Date == DateTime.Now.Date)).OrderByDescending(e => e.AppointmetDateTime).ToList(),
                Patients = context.Patients.ToList()
            };
            return View(_VMIndex);
        }

        public IActionResult AcceptPatientAppointment(Int64 id)
        {

            Appointment UpcomingAppoint = context.Appointments.Where(e => e.Id == id).FirstOrDefault();
            if (UpcomingAppoint!=null)
            {
                UpcomingAppoint.Accepted = "Yes";
                context.SaveChanges();
            }
            return RedirectToAction("DoctorIndex");
        }
        public IActionResult CanclePatientAppointment(Int64 id)
        {
            Appointment Appoint = context.Appointments.Where(e => e.Id == id).FirstOrDefault();
            if (Appoint != null)
            {
                context.Appointments.Remove(Appoint);
                context.SaveChanges();
            }
            return RedirectToAction("DoctorIndex");
        }
        public IActionResult DeletePatientAppointment(Int64 id)
        {
            Appointment Appoint = context.Appointments.Where(e => e.Id == id).FirstOrDefault();
            if (Appoint != null)
            {
                context.Appointments.Remove(Appoint);
                context.SaveChanges();
            }
            return RedirectToAction("GetAppointment");
        }
        public IActionResult GetAppointment()
        {
            docid = context.Doctors.FirstOrDefault(z => z.IdentityId == User.FindFirst(ClaimTypes.NameIdentifier).Value).Nid;

            VMPatientAppointment _VMPatientAppointment = new VMPatientAppointment()
            {
                Appointments = context.Appointments.Where(e => (e.DocId == docid)).ToList(),
                Patients = context.Patients.ToList()
            };
            return View(_VMPatientAppointment);
        }
        public IActionResult GetDoctors()
        {
            List<Doctor> doctors = context.Doctors.ToList();
            return View(doctors);
        }
        public IActionResult GetDoctorPatientds()
        {
            docid = context.Doctors.FirstOrDefault(z => z.IdentityId == User.FindFirst(ClaimTypes.NameIdentifier).Value).Nid;

            List<Int64> patientsID = context.Diagnoses.Where(e => e.DocId == docid).Select(e => e.PatientId).Distinct().ToList();
            List<Diagnose> docPatientDiagnoses = new List<Diagnose>();
     
            foreach (Int64 item in patientsID)
            {
                var diagnose = context.Diagnoses.Where(e => (e.PatientId == item)).FirstOrDefault();
                docPatientDiagnoses.Add(diagnose);
            }

            VMPatientDiagnose _VMPatientDiagnose = new VMPatientDiagnose()
            {
                Diagnoses =docPatientDiagnoses,
                patients = context.Patients.ToList(),
            };
            return View(_VMPatientDiagnose);
        }
        public IActionResult GetPatientProfileWithNewDiagnose(Int64 id)
        {

            docid = context.Doctors.FirstOrDefault(z => z.IdentityId == User.FindFirst(ClaimTypes.NameIdentifier).Value).Nid;


            VMPatientProfile VMPatientProfile = new VMPatientProfile()
            {
                Diagnoses = context.Diagnoses.Where(e => e.PatientId == id).ToList(),
                Radiations = context.Radiations.Where(e => e.PatientId == id).ToList(),
                Analyses = context.Analyses.Where(e => e.PatientId == id).ToList(),
                Doctors = context.Doctors.ToList(),
                patient = context.Patients.Where(e => e.Nid == id).FirstOrDefault(),
                LogedInDoctor = context.Doctors.Where(e => e.Nid == docid).FirstOrDefault()
            };
            return View(VMPatientProfile);
        }
        public IActionResult GetPatientProfileReadonly(Int64 id)
        {

            VMPatientProfile VMPatientProfile = new VMPatientProfile()
            {
                Diagnoses = context.Diagnoses.Where(e => e.PatientId == id).ToList(),
                Radiations = context.Radiations.Where(e => e.PatientId == id).ToList(),
                Analyses = context.Analyses.Where(e => e.PatientId == id).ToList(),
                Doctors = context.Doctors.ToList(),
                patient = context.Patients.Where(e => e.Nid == id).FirstOrDefault()
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
        [HttpGet]
        public IActionResult AddPatientDiagnose(Int64 id)
        {
            VMPatientDiagnosePrescription _VMPatientDiagnosePrescription = new VMPatientDiagnosePrescription()
            { 
                patient = context.Patients.Where(e => e.Nid == id).FirstOrDefault(),
                medicines = context.Medicines.ToList(),
            };
            return View(_VMPatientDiagnosePrescription);
        }
        [HttpPost]
        public IActionResult AddPatientDiagnose(VMPatientDiagnosePrescriptionJson VMPatientDiagnosePrescriptionJson)
        {
            docid = context.Doctors.FirstOrDefault(z => z.IdentityId == User.FindFirst(ClaimTypes.NameIdentifier).Value).Nid;

            //try
            //{
                Diagnose newDiagnose = new Diagnose()
                {
                    DiagnoseDescription = VMPatientDiagnosePrescriptionJson.Description,
                    RequiredAnalyses = VMPatientDiagnosePrescriptionJson.Analyses,
                    RequiredRadiation = VMPatientDiagnosePrescriptionJson.Rad,
                    DocId = docid,
                    PatientId = Int64.Parse(VMPatientDiagnosePrescriptionJson.Pid),
                    DiagnoseDateTime = DateTime.Now

                };
                DiagnosePrescription diagnosePrescription = new DiagnosePrescription()
                {
                    Diagnose = newDiagnose
                };
                context.Diagnoses.Add(newDiagnose);
                context.SaveChanges();
                context.DiagnosePrescriptions.Add(diagnosePrescription);
                context.SaveChanges();
                foreach (var item in VMPatientDiagnosePrescriptionJson.prescr)
                {
                    PrescriptionMedicine prescriptionMedicine = new PrescriptionMedicine();
                    prescriptionMedicine.PrescriptionId = diagnosePrescription.PrescriptionId;
                    prescriptionMedicine.MedicineId = context.Medicines.Where(e => e.Name == item.name).Select(e => e.Id).FirstOrDefault();
                    prescriptionMedicine.Dose = item.Dose;
                    prescriptionMedicine.Note = item.Note;
                    context.PrescriptionMedicines.Add(prescriptionMedicine);
                    context.SaveChanges();
                }
               
            //}
            //catch
            //{

            //    return View();
            //}
            return RedirectToAction("GetPatientProfileWithNewDiagnose", new { id = VMPatientDiagnosePrescriptionJson.Pid });
        }
        [HttpGet]
        public IActionResult AddNewAnalyses(Int64 id)
        {
            VMAddNewAnalyses analyses = new VMAddNewAnalyses();
            analyses.Patient = context.Patients.Where(e => e.Nid == id).FirstOrDefault();
            return View(analyses);
        }
       [HttpPost]
        public IActionResult AddNewAnalyses(VMAddNewAnalyses VMnewAnalyses, [FromServices] IHostingEnvironment oHostingEnvironment)
        {
            docid = context.Doctors.FirstOrDefault(z => z.IdentityId == User.FindFirst(ClaimTypes.NameIdentifier).Value).Nid;
            string serial = DateTime.Now.Year.ToString()+ DateTime.Now.Month.ToString()+ DateTime.Now.Day.ToString()+ DateTime.Now.Hour.ToString()+ DateTime.Now.Minute.ToString()+ DateTime.Now.Second.ToString();
            Analysis newAnalyses = new Analysis();
            if (ModelState.IsValid)
            {
                newAnalyses.DocId = docid;
                newAnalyses.Id = 0;
                newAnalyses.Patient = VMnewAnalyses.Patient;
                newAnalyses.PatientId = VMnewAnalyses.PatientId;
                newAnalyses.DocId = docid;
                newAnalyses.DateAndTime = VMnewAnalyses.DateAndTime.Value;
                newAnalyses.Report = VMnewAnalyses.Report;
                newAnalyses.Note = VMnewAnalyses.Note;
                newAnalyses.Type = VMnewAnalyses.Type;
                if (VMnewAnalyses.formFile.Length > 0)
                {
                    string fileName = $"{oHostingEnvironment.WebRootPath}\\UploadedFiles\\{serial}{VMnewAnalyses.formFile.FileName}";
                    using (FileStream fileStream = System.IO.File.Create(fileName))
                    {
                        VMnewAnalyses.formFile.CopyTo(fileStream);
                        fileStream.Flush();
                        newAnalyses.AttachUrl = $"~/UploadedFiles/{serial}{VMnewAnalyses.formFile.FileName}";
                    }
                }
                context.Analyses.Add(newAnalyses);
                context.SaveChanges();
            }
            return RedirectToAction("GetPatientProfileWithNewDiagnose", new { id = newAnalyses.PatientId });////set its value
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
        [HttpGet]
        public IActionResult AddNewRadiation(Int64 id)
        {
            VMAddNewRadiation radiation = new VMAddNewRadiation();
            radiation.Patient = context.Patients.Where(e => e.Nid == id).FirstOrDefault();
            return View(radiation);
          
        }
        [HttpPost]
        public IActionResult AddNewRadiation(VMAddNewRadiation VMnewRadiation,[FromServices] IHostingEnvironment oHostingEnvironment)
        {
            docid = context.Doctors.FirstOrDefault(z => z.IdentityId == User.FindFirst(ClaimTypes.NameIdentifier).Value).Nid;
            string serial = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            Radiation newRadiation = new Radiation();
            if (ModelState.IsValid)
            {
                newRadiation.DocId = docid;
                newRadiation.Id = 0;
                newRadiation.Patient = VMnewRadiation.Patient;
                newRadiation.PatientId= VMnewRadiation.PatientId;
                newRadiation.DocId = docid;
                newRadiation.DateAndTime = VMnewRadiation.DateAndTime.Value;
                newRadiation.Report = VMnewRadiation.Report;
                newRadiation.Note = VMnewRadiation.Note;
                newRadiation.Type = VMnewRadiation.Type;
                if (VMnewRadiation.formFile.Length > 0)
                {
                    string fileName = $"{oHostingEnvironment.WebRootPath}\\UploadedFiles\\{serial}{VMnewRadiation.formFile.FileName}";
                    using(FileStream fileStream=System.IO.File.Create(fileName))
                    {
                        VMnewRadiation.formFile.CopyTo(fileStream);
                        fileStream.Flush();
                        newRadiation.AttachUrl =$"~/UploadedFiles/{serial}{VMnewRadiation.formFile.FileName}";                    }
                }
                context.Radiations.Add(newRadiation);
                context.SaveChanges();
            }
            return RedirectToAction("GetPatientProfileWithNewDiagnose", new { id = newRadiation.PatientId });////set its value
        }
     
        public IActionResult GetDoctorProfile(Int64 id)
        {
            Doctor doctor = context.Doctors.Where(e => e.Nid == id).FirstOrDefault();
            return View(doctor);
        }
        [HttpGet]
        public IActionResult EditDoctorProfile(Int64 id)
        {
            Doctor doctor = context.Doctors.Where(e => e.Nid == id).FirstOrDefault();
            return View(doctor);
        }
        [HttpPost]
        public IActionResult EditDoctorProfile(Doctor doctor)
        {
            Doctor updated = context.Doctors.Where(e => e.Nid == doctor.Nid).FirstOrDefault();
            updated.Address = doctor.Address;
            updated.Email = doctor.Email;
            updated.Phone = doctor.Phone;
            context.SaveChanges();

            return RedirectToAction("GetDoctorProfile", new { id = doctor.Nid });
        }
    }
}
