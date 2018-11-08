using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

//Dessa måste läggas till för att använda EF och 
//för att referera till contextklassen
using DemoASPNETEntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoASPNETEntityFramework
{
    public class Startup
    {
       
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            //Lägger till en service för EF och skickar in en connectionsträng
            var connection = @"Server=localhost;Database=MyDB;Trusted_Connection=True";
            services.AddDbContext<MyDBContext>(options => options.UseSqlServer(connection));

        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}
