using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GHC2.ViewModels
{
    public class prescr
    {
        public string name{ get; set; }
        public string Dose { get; set; }
        public string Note { get; set; }
    }
    public class VMPatientDiagnosePrescriptionJson
    {
        public string Pid { get; set; }
        public string Description { get; set; }
        public string Analyses { get; set; }
        public string Rad { get; set; }
        public List<prescr> prescr { get; set; }

    }
}
