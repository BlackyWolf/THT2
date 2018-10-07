using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace TheHostingTool2.Api
{
    /// <summary>
    ///     The entry class for the entire application, used by the hosting
    ///     environment.
    /// </summary>
    public class Program
    {
        /// <summary>
        ///     The entry method for the entire application, used to run the
        ///     application in the hosting environment.
        /// </summary>
        /// <param name="args">
        ///     Any arguments used for configurating application startup.
        /// </param>
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        /// <summary>
        ///     Creates the implementations of <see cref="IWebHostBuilder" />
        ///     for building the application web host.
        /// </summary>
        /// <param name="args">
        ///     Any arguments used for configuring the web host.
        /// </param>
        /// <returns>
        ///     The implementation of <see cref="IWebHostBuilder" />.
        /// </returns>
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
