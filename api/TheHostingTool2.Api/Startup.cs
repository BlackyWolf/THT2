using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace TheHostingTool2.Api
{
    /// <summary>
    ///     The startup class used for configuring the application.
    /// </summary>
    public class Startup
    {
        /// <summary>
        ///     Used to get and set configuration data for configuring the
        ///     application.
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        ///     Creates an instance of <see cref="Startup" /> with the
        ///     application configuration.
        /// </summary>
        /// <param name="configuration">
        ///     Used to configure the application.
        /// </param>
        public Startup(IConfiguration configuration) =>
            Configuration = configuration;

        /// <summary>
        ///     Configures the application middleware pipeline.
        /// </summary>
        /// <param name="app">Used to build the middleware pipeline.</param>
        /// <param name="env">
        ///     Contains information about the application's hosting environment.
        /// </param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }

        /// <summary>
        ///     Used to configure services and dependencies used throughout the
        ///     application.
        /// </summary>
        /// <param name="services">
        ///     A collection used to add and register services and dependencies.
        /// </param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }
    }
}
