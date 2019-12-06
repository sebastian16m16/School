using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Reflection;
using System.Security.Permissions;
using System.Text.RegularExpressions;
using SensorsAndPatients.Controllers;
using SensorsAndPatients.Models;
using System.Collections;

namespace SensorsAndPatients.Resource
{
    public class SensorRead
    {
        string line;
        string[] data;
        bool read = true;

        StreamReader stream = new StreamReader(Resource1.activity);

        public IList<Activity> getData()
        {
            List<Activity> activitiesRead = new List<Activity>();

           
            while ((line = stream.ReadLine()) != null && read != false)
            {
                Activity activity = new Activity();
                data = Regex.Split( line ,"\t\t");

                activity.start_time = DateTime.Parse(data[0]);
                activity.end_time = DateTime.Parse(data[1]);
                activity.activity_label = data[2].Trim('\t');

                activitiesRead.Add(activity);
            }

            read = false;

            return activitiesRead;
        }


       
    }
}