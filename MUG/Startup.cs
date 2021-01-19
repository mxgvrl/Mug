using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MUG.Models;

namespace MUG {
    public class Startup {
        
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }
 
        public IConfiguration Configuration { get; }
        
        public void ConfigureServices(IServiceCollection services) {
            string connection = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<MUGContext>(options => options.UseSqlServer(connection));
            services.AddControllersWithViews();
            services.AddCors();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options => //CookieAuthenticationOptions
                {
                    options.LoginPath = new PathString("/Account/Login");
                });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages();
                app.UseStaticFiles();
            }

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints => {
                endpoints.MapControllerRoute(
                    "default",
                    "{controller=Home}/{action=Home}/{id?}");
            });
        }
    }
}