using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicationDispenser.Models
{
    class MedicationSchedule
    {
        public int id { get; set; }
        public string name { get; set; }
        public int patient { get; set; }
        public int doctor { get; set; }

        public MedicationSchedule(int id, string name, int patient, int doctor)
        {
            this.id = id;
            this.name = name;
            this.patient = patient;
            this.doctor = doctor;
        }

        public MedicationSchedule()
        {
        }
    }
}
