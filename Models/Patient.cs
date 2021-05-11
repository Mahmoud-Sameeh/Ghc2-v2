using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GHC2.Models
{
    public class Patient
    {
        [Key]
        public Int64 Nid { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime BitrhDate { get; set; }
        public string Address { get; set; }
        public Int64? Phone { get; set; }
        public string Email { get; set; }
        public string BloodGroup { get; set; }
        public string Password { get; set; }
        public string ImageUrl { get; set; }
        public string IdentityId { get; set; }

        public virtual ICollection<Analysis> Analyses { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Diagnose> Diagnoses { get; set; }
        public virtual ICollection<Radiation> Radiations { get; set; }
    }
}
