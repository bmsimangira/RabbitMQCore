using System;
using System.Collections.Generic;
using System.Linq;
using RabbitMQ.Models.Commands;

namespace RabbitMQ.Models.QueueMessage
{
    public interface IMessage
    {
        string BaseUrl { get; set; }
        ECommandType Type { get; set; }
    }
}
