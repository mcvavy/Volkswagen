using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VOLKSWAGEN.Core.Entities;

namespace VOLKSWAGEN.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        //https://stackoverflow.com/questions/38398022/access-from-class-library-to-appsetting-json-in-asp-net-core
        //https://stackoverflow.com/questions/46940710/getting-value-from-appsettings-json-in-net-core
        //https://stackoverflow.com/questions/31453495/how-to-read-appsettings-values-from-config-json-in-asp-net-core
        public static void AddApiKey(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<ConfigSettings>(configuration.GetSection("VehicleLookConfig"));
            services.Configure<ResponseConfig>(configuration.GetSection("ResponseObject"));
        }
    }
}
