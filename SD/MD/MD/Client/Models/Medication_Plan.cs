using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcServer.Models
{
    public class Medication_Plan
    {
        public int Id { get; set; }
        public int Patient { get; set; }
        public int Medication { get; set; }
        public int Medication_Schedule { get; set; }
        public DateTime time { get; set; }

        public Medication_Plan(int id, int Patient, int medication, int medication_schedule, DateTime time)
        {
            this.Id = id;
            this.Patient = Patient;
            this.Medication = medication;
            this.Medication_Schedule = medication_schedule;
            this.time = time;
        }
        public Medication_Plan()
        {

        }
    }
}
