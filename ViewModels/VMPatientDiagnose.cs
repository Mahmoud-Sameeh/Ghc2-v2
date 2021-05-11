using GHC2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GHC2.ViewModels
{
    public class VMPatientDiagnose
    {
        public List<Diagnose> Diagnoses { get; set; }
        public List<Patient> patients { get; set; }
    }
}
