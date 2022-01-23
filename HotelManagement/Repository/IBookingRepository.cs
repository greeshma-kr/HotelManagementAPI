using HotelManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagement.Repository
{
    public interface IBookingRepository
    {
        Task<int> NewBooking(BookingModel booking);

        Task<BookingModel> GetBookByIdAsync(int id);
    }
}
