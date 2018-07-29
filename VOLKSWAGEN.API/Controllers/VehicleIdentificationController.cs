using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using VOLKSWAGEN.Core.Entities;
using VOLKSWAGEN.Core.Interfaces;

namespace VOLKSWAGEN.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleIdentificationController : Controller
    {
        private readonly ConfigSettings _settings;
        private readonly ResponseConfig _responseConfig;
        private readonly IVehicleLookUp _vehicleLookUp;

        public VehicleIdentificationController(
            IOptions<ConfigSettings> settings, 
            IOptions<ResponseConfig> responseConfig, 
            IVehicleLookUp vehicleLookUp)
        {
            _settings = settings.Value;
            _responseConfig = responseConfig.Value;
            _vehicleLookUp = vehicleLookUp;
        }

        [HttpGet("{vehicleRegistration}", Name = "GetVehicleData")]
        public async Task<ActionResult> GetVehicleDetails(string vehicleRegistration)
        {
            var response = await _vehicleLookUp.GetVehicleData(vehicleRegistration, _settings, _responseConfig);

            return Ok(response);
        }


    }
}