using AutoMapper;
using VOLKSWAGEN.Core.DTOs;
using Response = VOLKSWAGEN.Core.Entities.Response;

namespace VOLKSWAGEN.Infrastructure.Helpers
{
    public static class MapperConfig
    {
        public static void RegisterMapping()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<Response, ResponseDto>();
            });
        }
    }
}
