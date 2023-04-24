using Eterna.DataAccess;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eterna
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<DataContext>(opt =>
            {
               
                opt.UseSqlServer(@"Server=DESKTOP-2CQPHUQ\FIRSTSQL;Database=eternaTask;Trusted_Connection=true");
            });

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    "default",
                    "{controller=home}/{action=index}/{id?}"
                    );

                endpoints.MapControllerRoute(
                   "about",
                   "about-us",
                   defaults: new { controller="home", action="about"}
                   );

                endpoints.MapControllerRoute(
                   "contact",
                   "contact-us",
                   defaults: new { controller = "home", action = "contact" }
                   );
            });
        }
    }
}
