using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcServer.Models
{
    public class Patient
    {
        public int id { get; set; }
        public string name { get; set; }
        public int doctor { get; set; }
    }
}
