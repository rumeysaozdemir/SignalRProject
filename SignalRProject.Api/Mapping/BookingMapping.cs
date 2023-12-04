﻿using AutoMapper;
using SignalRProject.DtoLayer.BookingDto;
using SignalRProject.EntityLayer.Entities;

namespace SignalRProject.Api.Mapping
{
    public class BookingMapping : Profile
    {
        public BookingMapping() 
        {
            CreateMap<Booking, ResultBookingDto>().ReverseMap();
            CreateMap<Booking, CreateBookingDto>().ReverseMap();
            CreateMap<Booking, GetBookingDto>().ReverseMap();
            CreateMap<Booking, UpdateBookingDto>().ReverseMap();
        }
    }
}
