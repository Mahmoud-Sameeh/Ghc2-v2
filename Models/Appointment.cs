using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GHC2.Models
{
    public class Appointment
    {
        public Int64 Id { get; set; }
        public Int64 PatientId { get; set; }
        public Int64 DocId { get; set; }
        public DateTime AppointmetDateTime { get; set; }
        public string Note { get; set; }
        public string Accepted { get; set; }

        public virtual Doctor Doc { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
