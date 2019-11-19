﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SensorsAndPatients.Models
{
    public class Activity
    {
        public int id { get; set; }
        public DateTime start_time { get; set; }
        public DateTime end_time { get; set; }
        public string activity_label { get; set; }
        public int patient { get; set; }
    }
}