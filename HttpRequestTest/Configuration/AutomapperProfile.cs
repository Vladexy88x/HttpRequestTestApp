using AutoMapper;
using HttpRequestExamples.Dtos;
using HttpRequestExamples.Models;

namespace HttpRequestExamples.Configuration
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<List<Root>, AddressDto>()
                .ForMember(
                    dto => dto.result,
                    dto => dto.MapFrom(src => src.Select(s => s.result).First()));
        }
    }
}