using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace H2.Models
{
    public class Login
    {
        public string username { get; set; }
        public string password { get; set; }
        private char _type;
        public char type
        {
            get { return _type; }
            set { if (value == 'D' || value == 'C' || value == 'P')
                {
                    _type = value;
                }
                else
                {
                    _type = 'P';
                }
            }
        }
    }
}