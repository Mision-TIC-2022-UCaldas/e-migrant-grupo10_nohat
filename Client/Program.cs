using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using proyFinal_g63.Shared.Model;
using proyFinal_g63.Client.Services;

namespace proyFinal_g63.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            
            //La configuracion de servicios
            ConfiguracionServicios(builder.Services);

            await builder.Build().RunAsync();
        }

        private static void ConfiguracionServicios(IServiceCollection services){
            
            //Despues toca cambiarlo a addscoped
            services.AddScoped<IServiceMovie, ServiceMovie>();

        }
    }
}
