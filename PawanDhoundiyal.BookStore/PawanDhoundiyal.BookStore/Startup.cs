using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PawanDhoundiyal.BookStore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        //To add all the dependecies in our project
        public void ConfigureServices(IServiceCollection services)
        {
            //we can use models controllers and views using this
                //services.AddMvc();

            //If we are wroking with API we don't need views so we can use AddController Methos
                //services.AddControllers();

            //If we are working with Web Project we can use Controller with views.

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //we write middleware(multiple).it as code

        //IWebHostEnvironment parameter reads enviromental settings from launchsettings and tells us current used environment
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //wether current evnvironment is development
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            #region use Use method to create custom middleware start

            //first Middleware
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from my first middleware");

            //    //this is used to call next middleware 
            //    //if we don't use then second middle ware is not called
            //    await next();

            //    await context.Response.WriteAsync("Hello from my first middleware");
            //});

            ////Second middleware
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from my Second middleware");
            //});

            #endregion


            //we use Use method to create custom middleware End



            app.UseRouting();

            #region Using Environment From Launc Settings file
            //app.UseEndpoints(endpoints =>
            //{
            //    //this is used to  map the url to particular resource / is default url
            //    //before using mapping we need to set to route first
            //    //if we want to write some message based on Enviroment then we can use this
            //    endpoints.MapGet("/", async context =>
            //    {
            //        //To Print the environment we are working on
            //        await context.Response.WriteAsync("This is : "+env.EnvironmentName);
            //    });
            //});

            #endregion

            app.UseEndpoints(endpoints =>
            {
                //this is used to  map the url to particular resource / is default url
                //before using mapping we need to set to route first

                //If map the Controller we can use other method

                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!");
                //});

                //if our controller name is other than home then we will use other methods
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
