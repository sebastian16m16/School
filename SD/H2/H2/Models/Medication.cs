using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace H2.Models
{
    public class Medication
    {
        public int id { get; set; }
        public string name { get; set; }
        public int side_effect { get; set; }
        public int dosage { get; set; }
    }
}