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
        public static void AddApiKey(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<ConfigSettings>(configuration.GetSection("VehicleLookConfig"));
            services.Configure<ResponseConfig>(configuration.GetSection("ResponseObject"));
        }
    }
}
