using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Linq;
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
            services.AddTransient<IVehicleRegistration,VehicleRegistration>();
            services.AddTransient<IVehicleLookUp, VehicleLookUp>();
            services.AddTransient<IJsonParser<JObject>, JsonParser>();
            services.AddTransient<IJsonDeserializer, JsonDeserializer>();
        }
    }
}
