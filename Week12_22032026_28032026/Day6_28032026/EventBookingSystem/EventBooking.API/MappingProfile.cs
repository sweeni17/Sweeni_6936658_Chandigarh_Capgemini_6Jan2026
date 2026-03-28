using AutoMapper;
using EventBooking.API.Models;
using EventBooking.API.DTOs;

namespace EventBooking.API
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventDto>().ReverseMap();
            CreateMap<Booking, BookingDto>().ReverseMap();
        }
    }
}