using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicationDispenser.Models
{
    class Report
    {
        public int id { get; set; }
        public int patient { get; set; }
        public int medication_schedule { get; set; }
        public Int16 taken { get; set; }



    }
}
