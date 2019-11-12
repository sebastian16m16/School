using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace H2.Models
{
    public class MedicationPlan
    {
        public int id { get; set; }
        public string name { get; set; }
        public int medication { get; set; }
        public int assigned_by { get; set; }
    }
}