using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WebApplication1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "unione",
                    pattern: "Department",
                    defaults: new {controller = "University" , Action = "Department" });

                endpoints.MapControllerRoute(
                    name: "unitwo",
                    pattern: "Fecaulty",
                    defaults: new { controller = "University", Action = "Fecaulty" });

                endpoints.MapControllerRoute(
                    name: "unithree",
                    pattern: "Course",
                    defaults: new { controller = "University", Action = "Course" });

                endpoints.MapControllerRoute(
                    name: "unifour",
                    pattern: "Student",
                    defaults: new { controller = "University", Action = "Student" });

                endpoints.MapControllerRoute(
                    name: "unifive",
                    pattern: "Teacher",
                    defaults: new { controller = "University", Action = "Teacher" });

                endpoints.MapControllerRoute(
                    name: "officeone",
                    pattern: "Office",
                    defaults: new { controller = "Office", Action = "Index" });

                endpoints.MapControllerRoute(
                    name: "officetwo",
                    pattern: "Information-technology",
                    defaults: new { controller = "Office", Action = "IT" });

                endpoints.MapControllerRoute(
                    name: "officethree",
                    pattern: "Sales",
                    defaults: new { controller = "Office", Action = "Sales" });

                endpoints.MapControllerRoute(
                    name: "officefour",
                    pattern: "Admin-panel",
                    defaults: new { controller = "Office", Action = "Admin" });

                endpoints.MapControllerRoute(
                    name: "officefive",
                    pattern: "Office-Account",
                    defaults: new { controller = "Office", Action = "Account" });

                endpoints.MapControllerRoute(
                    name: "officesix",
                    pattern: "Human-Resource",
                    defaults: new { controller = "Office", Action = "HR" });

                endpoints.MapControllerRoute(
                    name: "news",
                    pattern: "news/{y}/{m}/{d}/{p}/{a}",
                    defaults: new { controller = "News", Action = "NewsPaper" });

                endpoints.MapControllerRoute(
                    name: "linq",
                    pattern: "Linq",
                    defaults: new { controller = "News", Action = "Link" });

                endpoints.MapControllerRoute(
                    name: "linqindex",
                    pattern: "LinqIndex",
                    defaults: new { controller = "LINQ", Action = "Index" });

                endpoints.MapControllerRoute(
                    name: "linqnumber",
                    pattern: "LinqNumbers",
                    defaults: new { controller = "LINQ", Action = "ExampleOne" });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
