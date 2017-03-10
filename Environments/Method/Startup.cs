using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Method
{
    public class Startup
    {
        string environmentName;
        //ConfigureServiceは本来はDBの設定などに使う
        public void ConfigureDevelopmentServices(IServiceCollection services)
        {
            environmentName = "Development";
        }

        public void ConfigureProductionServices(IServiceCollection services)
        {
            environmentName = "Production";
        }

        public void ConfigureServices(IServiceCollection services)
        {
            environmentName = "Others";
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync($"Hello World! It's {environmentName} Environment!");
            });
        }
    }
}
