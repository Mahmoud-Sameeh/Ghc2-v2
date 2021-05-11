using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GHC2.Models
{
    public class Analysis
    {
        public Int64 Id { get; set; }
        public string Type { get; set; }
        public DateTime DateAndTime { get; set; }
        public Int64 PatientId { get; set; }
        public Int64 DocId { get; set; }
        public string Report { get; set; }
        public string Note { get; set; }
        public string AttachUrl { get; set; }

        public virtual Doctor Doc { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
