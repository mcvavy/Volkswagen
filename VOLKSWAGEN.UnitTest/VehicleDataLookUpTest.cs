using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Moq;
using NSubstitute;
using NUnit.Framework;
using Shouldly;
using VOLKSWAGEN.Core.Entities;
using VOLKSWAGEN.Infrastructure.Helpers;
using VOLKSWAGEN.Infrastructure.Services;
using VOLKSWAGEN.UnitTest.Helpers;

namespace VOLKSWAGEN.UnitTest
{
    [TestFixture]
    public class VehicleDataLookUpTest
    {
        private Mock<FakeHttpMessageHandler> _fakeHttpMessageHandler;
        private HttpClient _client;
        private Mock<JsonDeserializer> _jsonDeserializer;
        private IOptions<ConfigSettings> _settingOption;

        private VehicleLookUp _vehicleLookUp;

        [SetUp]
        public void SetUp()
        {

            _fakeHttpMessageHandler = new Mock<FakeHttpMessageHandler>() { CallBase = true };
            _client = new HttpClient(_fakeHttpMessageHandler.Object);

            _fakeHttpMessageHandler.Setup(x => x.Send(It.IsAny<HttpRequestMessage>())).Returns(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(FakeHttpResponseMessage.Message)
            });

            _jsonDeserializer = new Mock<JsonDeserializer>();

            _settingOption = Options.Create(new ConfigSettings { FullUrl = "http://somefunrul.com", Apikey = "Any" });

            _vehicleLookUp = new VehicleLookUp(_client, _jsonDeserializer.Object, _settingOption);

        }

        [TearDown]
        public void TearDown()
        {
            _client = null;
        }



        [Test]
        public async Task VehicleLookUpShould_Return_Correct_Type()
        {
            var data = await _vehicleLookUp.GetVehicleDataAsync(Arg.Any<string>());
            data.ShouldBeOfType<VehicleData>();

        }

        [Test]
        public async Task VehicleLookUp_Should_Return_VehicleRegistration()
        {
            var data = await _vehicleLookUp.GetVehicleDataAsync(Arg.Any<string>());
            data.Response.DataItems.VehicleRegistration.Vrm.ShouldBe("N398TAX");
        }
    }
}
