using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ProjektFront.Services;
using Syncfusion.Blazor;

namespace ProjektFront
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.Services.AddSyncfusionBlazor();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NjYyNjAxQDMxMzkyZTM0MmUzMFFncnZ4UzhhZkI4NllUc2x3dGRMLzVCdnlPS3BubG1YZ21CcEJ5S2k5UHc9");
            builder.Services
               .AddScoped<IAccountService, AccountService>()
               .AddScoped<IStockService,StockService>()
               .AddScoped<ILocalStorageService, LocalStorageService>();
            builder.RootComponents.Add<App>("#app");        

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:5001/api/") });

            var host = builder.Build();

            var accountService = host.Services.GetRequiredService<IAccountService>();
            await accountService.Initialize();

            await host.RunAsync();
        }
    }
}
