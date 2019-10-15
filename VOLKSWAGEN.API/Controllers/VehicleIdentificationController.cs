using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using VOLKSWAGEN.Core.DTOs;
using VOLKSWAGEN.Core.Interfaces;

namespace VOLKSWAGEN.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleIdentificationController : Controller
    {
        private readonly IVehicleLookUp _vehicleLookUp;
        private readonly IMapper _mapper;

        public VehicleIdentificationController(IVehicleLookUp vehicleLookUp, IMapper mapper)
        {
            _vehicleLookUp = vehicleLookUp;
            _mapper = mapper;
        }

        [HttpGet("{vehicleRegistration}", Name = "GetVehicleData")]
        public async Task<ActionResult> GetVehicleDetailsAsync(string vehicleRegistration)
        {
            var response = await _vehicleLookUp.GetVehicleDataAsync(vehicleRegistration);

            return Ok(_mapper.Map<ResponseDto>(response));
        }


    }
}