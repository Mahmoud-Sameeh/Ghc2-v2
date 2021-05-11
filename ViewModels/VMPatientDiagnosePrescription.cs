using GHC2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GHC2.ViewModels
{
    public class VMPatientDiagnosePrescription
    {
        public Diagnose diagnose { set; get; }
        public List< PrescriptionMedicine> PrescriptionMedicine { set; get; }
        public List<Medicine>medicines { get; set; }
        public Patient patient { set; get; }
    }
}
