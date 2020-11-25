using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc;
using DataAccessLayer.Context;
using Divar.Core.Classes;
using Divar.Core.Services;
using Divar.Core.Interface;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Runtime;

namespace TDivar3
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        public IConfiguration Configuration { get; set; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication("UserCookie").AddCookie("UserCookie", options =>
            {
                options.Cookie.Name = "userscookie";
                options.LoginPath = "/Account/Login";
                options.LogoutPath = "/Account/Logout";
                options.ExpireTimeSpan = TimeSpan.FromMinutes(43200);
            });
           
            services.AddAuthorization();
            services.AddDbContext<DivarContext>(Options =>
            {
                Options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });
         
            services.AddTransient<IUser, UserService>();
            services.AddTransient<IAdvert, AdvertService>();
            services.AddTransient<IAdmins, AdminService>();
            services.AddMvc();
            
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            var cookiePolicyOptions = new CookiePolicyOptions
            {
                MinimumSameSitePolicy = SameSiteMode.Strict,
            };
            
            app.UseStaticFiles();
            app.UseRouting();
            //who are you?
            app.UseAuthentication();
            //are you allowed?
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=HomeF}/{action=Index}/{id?}");
            });

        }
    }
}
