using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RabbitMQ.Models.Commands;

namespace RabbitMQ.Models.QueueMessage
{
    public class Message : IMessage
    {
        public string BaseUrl { get; set; }
        public ECommandType Type { get; set; }
    }
}
