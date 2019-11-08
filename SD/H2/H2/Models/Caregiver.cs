using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace H2.Models
{
    public class Caregiver
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public DateTime birthdate { get; set; }
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
        public string address { get; set; }


    }
}