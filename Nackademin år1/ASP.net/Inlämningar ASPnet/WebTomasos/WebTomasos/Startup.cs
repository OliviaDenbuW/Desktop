using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebTomasos.Entities;

namespace WebTomasos
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSession();
            services.AddDistributedMemoryCache();

            var conn = @"Server=localhost;Database=tomasos;Trusted_Connection=True;
                        ConnectRetryCount=0";
            services.AddDbContext<tomasosContext>(options => options.UseSqlServer(conn));
        }

        // This method gets called by the runtime.Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseSession();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=WebTomasos}/{action=Login}/{id?}");
            });
        }
    }
}
