using HotelManagement.Models;
using HotelManagement.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : Controller
    {

        private readonly IBookingRepository _bookingRepo;

        public BookingController(IBookingRepository bookingRepo)
        {
            _bookingRepo = bookingRepo;
        }



        [HttpPost("new-booking")]
        public async Task<IActionResult> AddBooking([FromBody] BookingModel booking)
        {
            try
            {
                var id = await _bookingRepo.NewBooking(booking);
                return Ok(new { bookingId = id });
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error connecting to the database");
            }
        }

        [HttpGet("get-booking/{id}")]
        public async Task<IActionResult> GetBookingById([FromRoute] int id)
        {
            try
            {
                var booking = await _bookingRepo.GetBookByIdAsync(id);

                if (booking == null)
                {
                    return NotFound();
                }
                return Ok(booking);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

    }
}
