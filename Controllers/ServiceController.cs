using Eterna.DataAccess;
using Eterna.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Eterna.Controllers
{
    public class ServiceController : Controller
    {
        private readonly DataContext _context;

        public ServiceController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Service> services = _context.Services.ToList();
            return View(services);
        }

        public IActionResult Detail(int id)
        {
            //Service service = Data.Services.Find(x => x.Id == id);
            Service service = _context.Services.Find(id);

            return View(service);
        }
    }
}
