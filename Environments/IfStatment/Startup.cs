using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace IfStatment
{
    public class Startup
    {
        private string environmentName;
        //IHostingEnvironment ILoggerFactoryしかDIできない
        public Startup(IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            //DevelopmentとProductionはIsXXXで識別できる
            if (env.IsDevelopment())
            {}
            else if(env.IsProduction())
            {}
            //もしくは直接EnvironmentNameを取得できる
            environmentName = env.EnvironmentName;
        }

        //ConfigureServicesにはIHostingEnvironmetnをDIできない
        public void ConfigureServices(IServiceCollection services)
        {
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
                await context.Response.WriteAsync($"Hello World! It's {environmentName} Envrironment!");
            });
        }
    }
}
