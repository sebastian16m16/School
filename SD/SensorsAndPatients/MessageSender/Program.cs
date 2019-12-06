using System;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;
using SensorsAndPatients.Models;
using SensorsAndPatients.Resource;


namespace MessageSender
{
    class Program
    {
        public static void Main()
        {

            SensorRead sensor = new SensorRead();

            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                foreach (var data in sensor.getLines())
                {
                    channel.QueueDeclare(queue: "SensorsAndPatients",
                                         durable: false,
                                         exclusive: false,
                                         autoDelete: false,
                                         arguments: null);

                    string message = data;

                    var body = Encoding.UTF8.GetBytes(message);

                    channel.BasicPublish(exchange: "",
                                         routingKey: "Sensors",
                                         basicProperties: null,
                                         body: body);

                    Console.WriteLine(" [x] Sent {0}", message);
                    Task.Delay(500);
                }
            }

            Console.WriteLine(" Press [enter] to exit.");
            Console.ReadLine();
        }
    }
}
