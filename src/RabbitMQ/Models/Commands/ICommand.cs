using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RabbitMQ.Models.Commands
{
    public interface ICommand
    {
        Task<bool> Execute();
    }
}
