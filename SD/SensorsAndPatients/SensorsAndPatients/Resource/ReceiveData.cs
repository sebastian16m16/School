using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using RabbitMQ.Client.Events;
using System.Text.RegularExpressions;
using SensorsAndPatients.Models;
using SensorsAndPatients.Controllers;
using System.Threading.Tasks;

namespace SensorsAndPatients.Resource
{
    public class ReceiveData
    {
        public void getData()
        {

            var factory = new ConnectionFactory() { HostName = "localhost" };

            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "SensordAndPatients",
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                var consumer = new EventingBasicConsumer(channel);

                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body;
                    var message = Encoding.UTF8.GetString(body);

                    manageData(message);
                    Console.WriteLine(" [x] Received: {0}", message);
                };

                channel.BasicConsume(queue: "SensorsAndPatients",
                                     autoAck: true,
                                     consumer: consumer);

                Console.WriteLine(" Press [enter] to exit.");
                Console.ReadLine();
            }
        }

        public async void manageData(string line)
        {
            ActivityController activityController = new ActivityController();
            PatientController patientController = new PatientController();
            PatientHandle handle = new PatientHandle();
            Random random = new Random();

            Activity activity = new Activity();

            var data = Regex.Split(line, " ");

            activity.start_time = DateTime.Parse(data[0]);
            activity.end_time = DateTime.Parse(data[1]);
            activity.activity_label = data[2].Trim('\t');

            int n = patientController.GetCount();
            activity.patient = random.Next(1, n);
            activityController.Post(activity);
            TimeSpan span = activity.end_time.Subtract(activity.start_time);
            var hours = span.Hours;


            switch (activity.activity_label)
            {
                case "Sleeping":
                    if (hours >= 12) handle.notifyCaregiver(activity.patient);
                    break;

                case "Showering":
                    if (hours >= 1) handle.notifyCaregiver(activity.patient);
                    break;

                case "Toileting":
                    if (hours >= 1) handle.notifyCaregiver(activity.patient);
                    break;

                case "Leaving":
                    if (hours >= 12) handle.notifyCaregiver(activity.patient);
                    break;
            }

            await Task.Delay(500);
        }
    }
}