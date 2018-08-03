using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using Shouldly;
using VOLKSWAGEN.API.Controllers;
using VOLKSWAGEN.Core.Interfaces;
using VOLKSWAGEN.Infrastructure.Services;

namespace VOLKSWAGEN.IntegrationTest
{
    [TestFixture]
    public class VehicleRegistrationTest
    {
        [Test]
        public async void ShouldReturn_VehicleDetailes_IfInput_IsValid()
        {
            var serviceCollection = new ServiceCollection();
            var verhicleLookUp = serviceCollection.BuildServiceProvider().GetService<IVehicleLookUp>();
            var mapper = serviceCollection.BuildServiceProvider().GetService<IMapper>();

            var VehicleIdentification = new VehicleIdentificationController(verhicleLookUp, mapper);
            await VehicleIdentification.GetVehicleDetails("N398 TAX");
            VehicleIdentification.ShouldNotBeNull();
        }
    }
}
