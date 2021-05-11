using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GHC2.Models
{
    public class Medicine
    {
        public Int64 Id { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }
        public string Description { get; set; }
    }
}
