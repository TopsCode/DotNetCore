using CustomMiddleware.Middleware;
using CustomMiddleware.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CustomMiddleware
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
                        
            // call the options from class and assign some value
            services.Configure<EmployeeLocationOptions>(options => {
                options.CityName = "Atlanta";
                options.CountryName = "USA";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IOptions<EmployeeLocationOptions> locationOptions)
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

            //1
            // Use method registers new Middleware component and is expressed as lamda function
            app.Use(async (context, next) =>
            {
                if (context.Request.Method == HttpMethods.Get && context.Request.Query["iscertified"] == "true")
                {
                    await context.Response.WriteAsync("Message from Custom Middleware \n");
                }
                await next();
            });

            //2
            // use separate class RequestQueryStringMiddleware
            app.UseMiddleware<RequestQueryStringMiddleware>();

            //4
            // short circuit when /short in url.
            app.Use(async (context, next) =>
            {
                if (context.Request.Path == "/short")
                {
                    await context.Response.WriteAsync($"Request Short circuited");
                }
                else
                {
                    await next();
                }
            });

            //5
            // when url has /branch, the class middleware is called as well as msg "Branch Middleware" is shown.
            app.Map("/branch", branch =>
            {
                branch.UseMiddleware<RequestQueryStringMiddleware>();

                branch.Use(async (context, next) =>
                {
                    await context.Response.WriteAsync($"Branch Middleware");
                });
                //branch.Run(async (context) =>
                //{
                //    await context.Response.WriteAsync($"Branch Run Middleware");
                //});
            });


            //3
            // status code msg will be displayed even after next middleware is called first.
            app.Use(async (context, next) =>
            {
                await next();
                await context.Response.WriteAsync($"\nStatus Code: {context.Response.StatusCode}");
            });


            app.UseMiddleware<EmployeeLocationMiddleware>();
            //8
            // call from configure method
            //app.Use(async (context, next) =>
            //{
            //    if (context.Request.Path == "/Employeelocation")
            //    {
            //        EmployeeLocationOptions opts = locationOptions.Value;
            //        await context.Response.WriteAsync($"{opts.CityName}, {opts.CountryName}");
            //    }
            //    else
            //    {
            //        await next();
            //    }
            //});



            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                // this statement will show msg before going to Home Controller's Index action.
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World");
                });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
