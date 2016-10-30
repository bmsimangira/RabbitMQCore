using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RabbitMQ.Models.Commands;
using RabbitMQ.Models.QueueMessage;
using RabbitMQ;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace RabbitMQCore.Controllers
{
    public class LoadData : Controller
    {
        // GET: /<controller>/
        public JsonResult Index()
        {
            //var baseUrl = "http://" + Request.Url.Authority + "/";
            var baseUrl = "http://" + Request.Host + "/";
            var message = new Message { BaseUrl = baseUrl, Type = ECommandType.DownloadRepositories };

            Queue.PushCommand(message);

            return Json(true);
        }
    }
}
