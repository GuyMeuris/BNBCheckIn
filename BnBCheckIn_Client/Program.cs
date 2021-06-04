using Blazored.LocalStorage;
using BnBCheckIn_Client.Service;
using BnBCheckIn_Client.Service.IService;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
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
               
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = 
                new Uri(builder.Configuration.GetValue<string>("BaseAPIUrl")) });

            builder.Services.AddBlazoredLocalStorage();

            builder.Services.AddScoped<IBnBService, BnBService>();
            builder.Services.AddScoped<IBnBRoomService, BnBRoomService>();
            builder.Services.AddScoped<IAmenityService, AmenityService>();

            builder.Services.AddScoped<IRoomOrderDetailsService, RoomOrderDetailsService>();

            await builder.Build().RunAsync();
  
        }
    }
}
