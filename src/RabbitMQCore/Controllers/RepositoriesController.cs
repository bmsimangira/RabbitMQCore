using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PangeaServices.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace RabbitMQCore.Controllers
{
    public class RepositoriesController : Controller
    {
        private RepositoriesContext _context;

        public RepositoriesController(RepositoriesContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public JsonResult Index()
        {
            List<Repository> repositories = _context.Repositories.ToList();

            return Json(repositories);
        }

        [HttpPost]
        [ActionName("Index")]
        public JsonResult IndexPost([FromBody] List<Repository> repositories)
        {
            try
            {
                repositories.ForEach(repository => _context.Repositories.Add(repository));
                _context.SaveChanges();

                return Json(true);
            }
            catch (Exception ex)
            {
                return Json(false);
            }
        }
    }
}
