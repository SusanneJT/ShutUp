using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ShutUp.Client.Services.StateContainers;
using Microsoft.AspNetCore.Components;
using ShutUp.Client.Services.ApiServices;
using Blazored.LocalStorage;

namespace ShutUp.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddSingleton<MessageStateContainer>();
            builder.Services.AddSingleton<MessageApiService>();
            builder.Services.AddSingleton<UserApiService>();
            builder.Services.AddSingleton<UserStateContainer>();
            builder.Services.AddSingleton(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            await builder.Build().RunAsync();
        }
    }
}
