using Eterna.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;

namespace Eterna.DataAccess
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) { }


        public DbSet<Service> Services { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Slide> Slides { get; set; }
    }
}
