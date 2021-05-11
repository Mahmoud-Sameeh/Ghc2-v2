using GHC2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GHC2.ViewModels
{
    public class GetPatientAppointmentsWithDoctors
    {
        public List<Appointment> appointments { get; set; }
        public List<Doctor> Doctors { get; set; }
    }
}
