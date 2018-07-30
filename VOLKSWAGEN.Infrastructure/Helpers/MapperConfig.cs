using AutoMapper;
using VOLKSWAGEN.Core.DTOs;
using VOLKSWAGEN.Core.Entities;

namespace VOLKSWAGEN.Infrastructure.Helpers
{
    public static class MapperConfig
    {
        public static void RegisterMapping()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<VehicleRegistration, VehicleRegistrationDto>();
            });
        }
    }
}
