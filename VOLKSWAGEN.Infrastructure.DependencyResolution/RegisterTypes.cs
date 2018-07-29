using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Linq;
using VOLKSWAGEN.Core.Interfaces;
using VOLKSWAGEN.Infrastructure.Helpers;
using VOLKSWAGEN.Infrastructure.Services;

namespace VOLKSWAGEN.Infrastructure.DependencyResolution
{
    public static class RegisterTypes
    {
        public static void AddRegisteredTypes(this IServiceCollection services)
        {
            services.AddScoped<IVehicleLookUp, VehicleLookUp>();
            services.AddScoped<IJsonParser<JObject>, JsonParser>();
            services.AddScoped<IJsonDeserializer, JsonDeserializer>();
        }
    }
}
