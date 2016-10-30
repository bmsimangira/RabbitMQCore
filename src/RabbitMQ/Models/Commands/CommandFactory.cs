using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RabbitMQ.Models.Commands
{
    public class CommandFactory
    {
        public static ICommand GetCommand(ECommandType type, string url)
        {
            switch (type)
            {
                case ECommandType.DownloadRepositories:
                    return new DownloadRepo(url);
                default:
                    return null;
            }

        }
    }
}
