using GHC2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GHC2.ViewModels
{
    public class VMPatientAppointment
    {
        public List<Appointment> Appointments { get; set; }
        public List<Patient> Patients { get; set; }
    }
}
