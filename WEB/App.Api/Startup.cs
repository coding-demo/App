using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using App.ModuleRegistration;
using Autofac.Integration.WebApi;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Web.App.Api.Tests")]
namespace App.Api
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

            if (env.IsEnvironment("Development"))
            {
                // This will push telemetry data through Application Insights pipeline faster, allowing you to view results immediately.
                builder.AddApplicationInsightsSettings(developerMode: true);
            }

            builder.AddEnvironmentVariables();
            Configuration = builder.Build();
            


        }

        public IConfigurationRoot Configuration { get; }
        public IContainer ApplicationContainer { get; private set; }


        // This method gets called by the runtime. Use this method to add services to the container
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddApplicationInsightsTelemetry(Configuration);

            services.AddMvc(options =>
                                {
                                     options.RespectBrowserAcceptHeader = true; 
                                });

            #region AUTOFAC wired up using an instance class
            AppRoot root = new AppRoot();
            root.ContainerBuilder.RegisterApiControllers(typeof(Startup).Assembly);
            root.ContainerBuilder.Populate(services);
            ApplicationContainer = root.GetContainer();
            #endregion

            services.AddCors();
            return new AutofacServiceProvider(this.ApplicationContainer);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseCors(builder =>
                      builder.WithOrigins("https://estimate-dev.mymitchell.com")
                        );

            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseApplicationInsightsRequestTelemetry();

            app.UseApplicationInsightsExceptionTelemetry();

            app.UseMvc();
        }
    }
}
