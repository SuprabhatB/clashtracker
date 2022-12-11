using ClashTracker.Client.Services;
using ClashTracker.Client.Services.Interfaces;
using ClashTracker.Client.Utilities.Constants;
using ClashTracker.Client.Utilities.Helpers;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClashTracker.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>(AppClientConstants.RootComponentName);

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            ConfigureServices(builder.Services);

            await builder.Build().RunAsync();
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IIdGenerator, IdGenerator>();

            services.AddScoped<IClanService, ClanService>();
            services.AddScoped<IStringHelper, StringHelper>();
            services.AddScoped<IUriHelper, UriHelper>();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
