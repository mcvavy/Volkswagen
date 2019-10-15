using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using VOLKSWAGEN.Core.Entities;
using VOLKSWAGEN.Core.Interfaces;
using VOLKSWAGEN.Infrastructure.Helpers;
using VOLKSWAGEN.Infrastructure.Services;

namespace VOLKSWAGEN.Infrastructure.DependencyResolution
{
    public static class RegisterTypes
    {
        public static void AddRegisteredTypes(this IServiceCollection services)
        {

            services.AddTransient<HttpClient>();
            services.AddTransient<VehicleData>();
            services.AddTransient<IVehicleLookUp, VehicleLookUp>();
            services.AddTransient<IJsonDeserializer, JsonDeserializer>();
        }
    }
}
