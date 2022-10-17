using AutoMapper;

namespace NZWalksAPI.Models.Profiles
{
    public class RegionsProfile : Profile
    {
        public RegionsProfile()
        {
            CreateMap<Models.Domain.Region, Models.DTOs.Region>()
                .ReverseMap();
        }
    }
}
