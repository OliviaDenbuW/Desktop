using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nackowskis.Data;
using Nackowskis.Models;
using Microsoft.AspNetCore.Identity;
using System.Net.Http;
using Nackowskis.DataLayer;
using Nackowskis.BusinessLayer;

namespace Nackowskis
{
    public class Startup
    {
        private static readonly HttpClient client = new HttpClient();

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            //För att kunna ha endast den required service
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                    .AddEntityFrameworkStores<ApplicationDbContext>()
                    .AddDefaultTokenProviders();

            //Registrera klasserna som används i de olika skikten
            services.AddScoped<IAdminRepository, AdminRepository>();
            services.AddScoped<IAdminBusiness, AdminBusiness>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider services)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            CreateUserRoles(services).Wait();
        }

        private async Task CreateUserRoles(IServiceProvider serviceProvider)
        {
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var UserManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            IdentityResult roleResult;

            //Adding Admin role
            var roleCheck = await RoleManager.RoleExistsAsync("Admin");
            if (!roleCheck)
            {
                //Skapar rollen och seedar den till db
                roleResult = await RoleManager.CreateAsync(new IdentityRole("Admin"));
            }

            //Ger Admin-rollen till user
            ApplicationUser user = await UserManager.FindByEmailAsync("denbuw@gmail.com");
            var User = new ApplicationUser();
            await UserManager.AddToRoleAsync(user, "Admin");
        }
    }
}
