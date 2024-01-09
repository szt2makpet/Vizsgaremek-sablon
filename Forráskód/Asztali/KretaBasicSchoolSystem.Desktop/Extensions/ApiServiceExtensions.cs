using Flyhigh.Desktop.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyhigh.Desktop.Extensions
{
    public static class ApiServiceExtensions
    {
        public static void ConfigureApiServices(this IServiceCollection services)
        {
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<IGepService, GepService>();

        }
    }
}
