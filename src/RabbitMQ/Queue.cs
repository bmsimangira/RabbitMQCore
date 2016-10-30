using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;
using RabbitMQ.Models.QueueMessage;

namespace RabbitMQ
{
    public class Queue
    {
        public static void PushCommand(IMessage message)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };

            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "RepoCommands",
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                var messageJson = Newtonsoft.Json.JsonConvert.SerializeObject(message);

                var body = Encoding.UTF8.GetBytes(messageJson);

                channel.BasicPublish(exchange: "",
                                     routingKey: "RepoCommands",
                                     basicProperties: null,
                                     body: body);
            }
        }
    }
}
