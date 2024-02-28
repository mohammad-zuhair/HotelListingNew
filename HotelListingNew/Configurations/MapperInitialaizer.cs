using AutoMapper;
using HotelListingNew.Data;
using HotelListingNew.Models;

namespace HotelListingNew.Configurations
{
    public class MapperInitialaizer : Profile
    {
        public MapperInitialaizer()
        {
            CreateMap<Country, CountryDTO>().ReverseMap();
            CreateMap<Country, CreateCountryDTO>().ReverseMap();
            CreateMap<Hotel, HotelDTO>().ReverseMap();
            CreateMap<Hotel, CreateHotelDTO>().ReverseMap();
        }
    }
}
