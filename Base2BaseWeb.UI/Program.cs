using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NLog.Web;

namespace Base2BaseWeb.UI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // NLog: setup the logger first to catch all errors
            var appBasePath = System.IO.Directory.GetCurrentDirectory();
            NLog.GlobalDiagnosticsContext.Set("appbasepath", appBasePath);
            var logger = NLog.Web.NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();
            try
            {
                logger.Debug("init main");
                BuildWebHost(args).Run();
            }
            catch (Exception ex)
            {
                //NLog: catch setup errors
                logger.Error(ex, "Stopped program because of exception");
                throw;
            }
            finally
            {
                // Ensure to flush and stop internal timers/threads before application-exit (Avoid segmentation fault on Linux)
                NLog.LogManager.Shutdown();
            }
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((builderContext,config) => 
                {
                    IHostingEnvironment env = builderContext.HostingEnvironment;
                    config.AddJsonFile($"connectionsettings.{env.EnvironmentName}.json")
                    .AddJsonFile($"mailsettings.{env.EnvironmentName}.json")
                    .AddJsonFile($"imagesettings.{env.EnvironmentName}.json")
                    .AddJsonFile($"adminsettings.json");
                })
                .ConfigureLogging(logging =>
                {
                    logging.ClearProviders();
                    logging.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
                })
                .UseNLog()
                .UseStartup<Startup>()
                .Build();
    }
}
