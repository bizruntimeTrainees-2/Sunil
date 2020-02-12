﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace WebApplication1
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //demonstrating middleware
            app.Use(async (context, next) =>
            {
                logger.LogInformation("MW1: Incomming Request");
                await next();
                logger.LogInformation("MW1: Outgoing response");
            });
            app.Use(async (context, next) =>
            {
                logger.LogInformation("MW2: Incomming Request");
                await next();
                logger.LogInformation("MW2: Outgoing Response");
            });
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("MW3: Incomming Request");
                logger.LogInformation("MW3: Outgoing Response");
            });
        }
    }
}
