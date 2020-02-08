using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Blazor.Fluxor;

namespace StripeIntegration.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            //Fluxor
            builder.Services.AddFluxor(options => options.UseDependencyInjection(typeof(Program).Assembly));

            builder.RootComponents.Add<App>("app");


            await builder.Build().RunAsync();
        }
    }
}
