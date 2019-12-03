using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Reflection;
using System.Security.Permissions;
using System.Text.RegularExpressions;
using SensorsAndPatients.Models;
using System.Collections;

namespace SensorsAndPatients.Resource
{
    public class SensorRead
    {
        string line;
        string[] data;
        bool read = true;

        StreamReader stream = new StreamReader(MessageSender.Properties.Resources.activityFile);

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

        public IList<String> getLines()
        {
            List<String> lines = new List<string>();

            while((line = stream.ReadLine()) != null && read != false)
            {
                data = Regex.Split(line, "\t\t");

                
                string cleanLine = string.Format("{0} {1} {2}", data[0].Trim('\t'),
                    data[1].Trim('\t'), data[2].Trim('\t'));

                lines.Add(cleanLine);
            }
            read = false;

            return lines;
        }

        public IList<Activity> getDataFromLines(List<string> lines)
        {
            List<Activity> activities = new List<Activity>();

            foreach(var line in lines)
            {
                Activity activity = new Activity();

                data = Regex.Split(line, " ");

                activity.start_time = DateTime.Parse(data[0]);
                activity.end_time = DateTime.Parse(data[1]);
                activity.activity_label = data[2].Trim('\t');

                activities.Add(activity);
            }

            return activities;
        }
       
    }
}