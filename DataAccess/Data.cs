using Eterna.Models;
using System.Collections.Generic;

namespace Eterna.DataAccess
{
    public static class Data
    {
        public static List<Service> Services = new List<Service>
        {
            new Service{Id=1,Title = "Service 1",Icon = "bx bxl-dribbble",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"},
            new Service{Id=2,Title = "Service 2",Icon = "bx bx-file",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"},
            new Service{Id=3,Title = "Service 3",Icon = "bx bx-tachometer",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"},
            new Service{Id=4,Title = "Service 4",Icon = "bx bx-world",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"},
            new Service{Id=5,Title = "Service 5",Icon = "bx bx-slideshow",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"},
            new Service{Id=6,Title = "Service 6",Icon = "bx bx-arch",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"},
        };

        public static List<Feature> Features = new List<Feature>
        {
            new Feature{Id=1,Title = "Feature 1",Icon = "bx bxl-dribbble",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"},
            new Feature{Id=2,Title = "Feature 2",Icon = "bx bxl-dribbble",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"},
            new Feature{Id=3,Title = "Feature 3",Icon = "bx bxl-dribbble",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"},
        };
    }
}
