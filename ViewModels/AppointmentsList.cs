using GHC2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GHC2.ViewModels
{
    public class AppointmentsList
    {
        public Appointment appointment { get; set; }
        public List< DateTime> dateTimes { get; set; }
    }
}
