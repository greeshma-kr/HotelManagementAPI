using AutoMapper;
using HotelManagement.Data;
using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagement.Repository
{
    public class BookingRepository : IBookingRepository
    {
        private readonly AppDbContext _context;

        private readonly IMapper _mapper;

        public BookingRepository(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<int> NewBooking(BookingModel booking)
        {
            var reservation = new Reservation()
            {
                HotelId = booking.HotelId,
                CheckIn_Date = booking.CheckIn_Date,
                CheckOut_Date = booking.CheckOut_Date,
                ContactNumber =booking.ContactNumber,
                Email = booking.Email,
                DateAdded = DateTime.Now,
                RoomType = booking.RoomType,
                NoOfRooms = booking.NoOfRooms,
                Adults = booking.Adults,
                Children = booking.Children
            };

            _context.Reservation.Add(reservation);

             await _context.SaveChangesAsync();

            foreach (GuestModel p in booking.Guests)
            {
                var guest = new Guests()
                {
                    Firstname = p.Firstname,
                    Lastname = p.Lastname,
                    IDNumber = p.IDNumber,
                    IDType = p.IDType,
                    ReservationId = reservation.Id

                };
                _context.Guests.Add(guest);
                await _context.SaveChangesAsync();
            }

            return reservation.Id;
        }

        public async Task<BookingModel> GetBookByIdAsync(int id)
        {

            var booking = await _context.Reservation
                .Include(x => x.Guests)
                .FirstAsync(x => x.Id == id);

            return _mapper.Map<BookingModel>(booking);
        }

    }
}
