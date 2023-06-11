using Airbnb.Models;
using Airbnb.Models.DTO;
using AutoMapper;

namespace Airbnb;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<Location, LocationDTO>()
            .ForMember(dest => dest.LandLordAvatarURL, opt => opt.MapFrom(src => src.Landlord.Avatar.Url))
            .ForMember(dest => dest.ImageURL, opt => opt.MapFrom(src => src.Images.FirstOrDefault(image => image.IsCover).Url));

        CreateMap<Location, LocationDTOWithPrice>().
            ForMember(member => member.Price, options => options.MapFrom(property => property.PricePerDay)).
            ForMember(member => member.ImageURL, options => options.MapFrom(property => property.Images.FirstOrDefault(image => image.IsCover).Url)).
            ForMember(member => member.LandlordAvatarUrl, options => options.MapFrom(property => property.Landlord.Avatar.Url));

        CreateMap<Location, LocationsDetailsDTO>();
    }
}