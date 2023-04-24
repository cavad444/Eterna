using Eterna.DataAccess;
using Eterna.Models;
using Eterna.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Eterna.Controllers
{
    public class HomeController : Controller
    {

        private readonly DataContext _dataContext;

        public HomeController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult Index()
        {
            List<Slide> slides = _dataContext.Slides.ToList();

            HomeViewModel vm = new HomeViewModel
            {
                Services = Data.Services,
                Features = Data.Features,
                Slides = slides
            };

            return View(vm);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
