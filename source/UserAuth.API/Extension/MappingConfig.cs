using AutoMapper;
using UserAuth.API.Models.DTO;
using UserAuth.API.Models;

namespace UserAuth.API.Extension
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<RegisterModelDTO, ApplicationUser>()
                    .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.Email))
                    .ReverseMap();
                    });
            return mappingConfig;
        }
    }
}
