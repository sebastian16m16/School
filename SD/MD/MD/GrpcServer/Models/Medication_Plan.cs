using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcServer.Models
{
    public class Medication_Plan
    {
        public int Id { get; set; }
        public int Medication { get; set; }
        public int Medication_Schedule { get; set; }
        public DateTime time { get; set; }
    }
}
