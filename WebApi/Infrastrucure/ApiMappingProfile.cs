using AutoMapper;
using WebApi.Contracts;
using WebApi.Models;

namespace WebApi.Infrastrucure
{
    public class ApiMappingProfile : Profile
    {
        public ApiMappingProfile()
        {
            CreateMap<CreateEmailContract, CreateEmailModel>()
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Subject));
        }
    }
}
