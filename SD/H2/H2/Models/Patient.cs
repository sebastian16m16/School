using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace H2.Models
{
    public class Patient
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public DateTime birthdate { get; set; }
        public string address { get; set; }
        public int doctor { get; set; }
        public int caregiver { get; set; }
        public int medication_plan { get; set; }
        private char _gender;
        public char gender
        {
            get { return _gender; }
            set
            {
                if (value == 'F' || value == 'M')
                {
                    _gender = value;
                }
                else
                {
                    _gender = 'M';
                }
            }
        }
    }
}