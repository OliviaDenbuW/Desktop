using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace DemoASPNETIntro
{
    public class Startup
    {
        //Efter main funktionen i Program hamnar koden här
        public void ConfigureServices(IServiceCollection services)
        {
            //Detta behövs för att köra MVC i projektet
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //Detta anger att vi skall använda statiska filer i projektet
            //dvs CSS och javascript
            app.UseStaticFiles();

            //Sätter upp en route som skickar ett anrop till en metod i en 
            //controller
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });


        }
    }
}
