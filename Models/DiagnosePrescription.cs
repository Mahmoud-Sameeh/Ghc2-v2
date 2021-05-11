using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GHC2.Models
{
    public class DiagnosePrescription
    {
        [Key]
        public Int64 PrescriptionId { get; set; }
        public Int64 DiagnoseId { get; set; }

        public virtual Diagnose Diagnose { get; set; }
    }
}
