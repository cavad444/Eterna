using Eterna.Models;
using System.Collections.Generic;

namespace Eterna.ViewModels
{
    public class HomeViewModel
    {
        public List<Feature> Features { get; set; } 
        public List<Service> Services { get; set; } 
        public List<Slide> Slides { get; set; } 
    }
}
