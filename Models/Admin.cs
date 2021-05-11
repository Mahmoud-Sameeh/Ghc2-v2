using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GHC2.Models
{
    public class Admin
    {
        [Key]
        public Int64 Nid { get; set; }
        [Required]
       
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public DateTime BitrhDate { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]

       // [RegularExpression(@"^01[0-2]\d{1,8}$")]
        public Int64? Phone { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
       
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]

        public string Password { get; set; }

        public string ImageUrl { get; set; }
        [Required]

        public string Position { get; set; }
        [Required]

        public string IdentityId { get; set; }
    }
}
