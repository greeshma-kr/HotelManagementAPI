
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HotelManagement.Models;
using HotelManagement.Data;

namespace HotelManagement.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Hotel, HotelModel>().ReverseMap();

            CreateMap<Address, AddressModel>();

            CreateMap<Rating, RatingModel>();

            CreateMap<Facilities, FacilityModel>();

            CreateMap<Reviews, ReviewsModel>();

            CreateMap<HotelImages, HotelImageModel>();

            CreateMap<Reservation, BookingModel>().ReverseMap();

            CreateMap<Guests, GuestModel>().ReverseMap();
        }

    }
}
