using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyhigh.Desktop.Extensions
{
    public static class HttpCliensExtension
    {
        public static void ConfigureHttpCliens(this IServiceCollection services)
        {
            services.AddHttpClient("KretaApi", options =>
            {
                options.BaseAddress = new Uri("https://localhost:7090/");
            });
        }

    }
}
