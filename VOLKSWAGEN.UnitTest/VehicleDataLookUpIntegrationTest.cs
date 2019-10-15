using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using NUnit.Framework;
using Shouldly;
using VOLKSWAGEN.API;
using VOLKSWAGEN.Core.Entities;
using VOLKSWAGEN.Core.Interfaces;
using VOLKSWAGEN.Infrastructure.DependencyResolution;
using VOLKSWAGEN.Infrastructure.Extensions;
using VOLKSWAGEN.Infrastructure.Helpers;
using VOLKSWAGEN.Infrastructure.Services;

namespace VOLKSWAGEN.UnitTest
{
    [TestFixture]
    public class VehicleDataLookUpIntegrationTest
    {
        private ServiceCollection _services;
        private IConfigurationRoot _configurationRoot;
        private ServiceProvider _serviceProvider;
        private HttpClient _client;
        private IOptions<ConfigSettings> _config;
        private IJsonDeserializer _deserialiser;

        [SetUp]
        public void SetUp()
        {

            _services = new ServiceCollection();
            _services.AddOptions();


            _configurationRoot = Helpers.TestHelper.GetIConfigurationRoot(TestContext.CurrentContext.TestDirectory);
            _services.Configure<ConfigSettings>(_configurationRoot.GetSection("VehicleLookConfig"));

            _services.AddRegisteredTypes();
            //services.AddApiKey(configurationRoot);


            _serviceProvider = _services.BuildServiceProvider();

            
            _client = _serviceProvider.GetRequiredService<HttpClient>();
            
            _config = _serviceProvider.GetRequiredService<IOptions<ConfigSettings>>();
            
            _deserialiser = _serviceProvider.GetRequiredService<IJsonDeserializer>();
        }

        [Test]
        public async Task VehicleDataLookUp_ShouldReturn_VehicleData_Given_A_CorrectRegistration()
        {

            var vehiclelookup = new VehicleLookUp(_client, _deserialiser, _config);
            var result = await vehiclelookup.GetVehicleDataAsync("N398 TAX");
            result.Response.StatusCode.ShouldBe("Success");
        }

        [Test]
        public async Task VehicleDataLookUp_ShouldReturn_InvalidKey_Given_An_IncorrectRegistration()
        {

            var vehiclelookup = new VehicleLookUp(_client, _deserialiser, _config);
            var result = await vehiclelookup.GetVehicleDataAsync("ABABABABA");
            result.Response.StatusCode.ShouldBe("KeyInvalid");
        }
    }
}
