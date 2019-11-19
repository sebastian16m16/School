using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using SensorsAndPatients.Controllers;

namespace SensorsAndPatients.Resource
{
    public class ManageData
    {
        SensorRead sensorData = new SensorRead();
        

        public async void handleData()
        {
            ActivityController activityController = new ActivityController();
            PatientController patientController = new PatientController();
            PatientHandle handle = new PatientHandle();
            Random random = new Random();

            foreach(var data in sensorData.getData())
            {
                int n = patientController.GetCount();
                data.patient = random.Next(1, n);
                activityController.Post(data);
                TimeSpan span = data.end_time.Subtract(data.start_time);
                var hours = span.Hours;
                

                switch (data.activity_label)
                {
                    case "Sleeping": if (hours > 12) handle.notifyCaregiver(data.patient);
                        break;

                    case "Showering": if (hours > 1) handle.notifyCaregiver(data.patient);
                        break;

                    case "Toileting": if (hours > 1) handle.notifyCaregiver(data.patient);
                        break;
                    
                    case "Leaving": if (hours > 12) handle.notifyCaregiver(data.patient);
                        break;
                }

                await Task.Delay(1000);
            }
        }
    }
}