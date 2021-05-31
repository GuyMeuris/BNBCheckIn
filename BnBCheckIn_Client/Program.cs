using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Core;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BnBCheckIn_Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            var levelSwitch = new LoggingLevelSwitch();
            Log.Logger = new LoggerConfiguration()
            .MinimumLevel.ControlledBy(levelSwitch)
            .Enrich.WithProperty("InstanceId", Guid.NewGuid().ToString("n"))
            .WriteTo.BrowserHttp($"{builder.HostEnvironment.BaseAddress}ingest", controlLevelSwitch: levelSwitch)
            .WriteTo.BrowserConsole()
            .CreateLogger();

            try
            {
                Log.Information("BNBCheckIn browser starting");
               
                builder.RootComponents.Add<App>("#app");

                builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

                builder.Services.AddBlazoredLocalStorage();

                await builder.Build().RunAsync();
            }
            catch (Exception ex)
            {

                Log.Fatal(ex, "BNBCheckIn browser failed to start.");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
    }
}
