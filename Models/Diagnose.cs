using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GHC2.Models
{
    public class Diagnose
    {
        public Int64 Id { get; set; }
        public DateTime DiagnoseDateTime { get; set; }
        public string DiagnoseDescription { get; set; }
        public string RequiredRadiation { get; set; }
        public string RequiredAnalyses { get; set; }
        public Int64 PatientId { get; set; }
        public Int64 DocId { get; set; }

        public virtual Doctor Doc { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual ICollection<DiagnosePrescription> DiagnosePrescriptions { get; set; }
    }
}
