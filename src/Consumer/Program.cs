using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using RabbitMQ.Models.Commands;
using RabbitMQ.Models.QueueMessage;

namespace Consumer
{
    class Client
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initializing Message Handler ...");
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "RepoCommands",
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += async (model, ea) =>
                {
                    var body = ea.Body;
                    var messageJson = Encoding.UTF8.GetString(body);
                    var message = Newtonsoft.Json.JsonConvert.DeserializeObject<Message>(messageJson);

                    var command = CommandFactory.GetCommand(message.Type, message.BaseUrl);
                    Console.WriteLine("Received Message: {0}", messageJson);
                    Console.WriteLine("Executing Command ...");
                    if (command != null)
                    {
                        Console.WriteLine(await command.Execute()
                            ? "Command was executed succsessfully."
                            : "Failed to execute command.");
                    }


                };
                channel.BasicConsume(queue: "RepoCommands",
                                     noAck: true,
                                     consumer: consumer);

                Console.WriteLine(" Press [enter] to exit.");
                Console.ReadLine();
            }
        }
    }
}
