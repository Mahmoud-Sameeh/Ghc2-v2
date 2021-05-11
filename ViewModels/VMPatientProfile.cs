using GHC2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GHC2.ViewModels
{
    public class VMPatientProfile
    {
        public List<Diagnose> Diagnoses { get; set; }
        public List<Radiation> Radiations { get; set; }
        public List<Analysis> Analyses { set; get; }
        public List<Doctor> Doctors { set; get; }
        public Patient patient { set; get; }
        public Doctor LogedInDoctor { get; set; }
    }
}
