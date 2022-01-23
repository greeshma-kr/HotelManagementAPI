using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelManagement.Models;
using HotelManagement.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HotelManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {

     

        private readonly IHotelRepository _hotelRepo;



        public HotelController(IHotelRepository hotelRepo)
        {
            _hotelRepo = hotelRepo;
        }

        [HttpGet("getHotel/{id}")]
        public async Task<ActionResult<IEnumerable<HotelModel>>> GetHotelById([FromRoute] int id)
        {
            try
            {
                var result = await _hotelRepo.GetHotelByIdAsync(id);

                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }


        [HttpPost("search")]
        public async Task<ActionResult<IEnumerable<HotelModel>>> Search(string name,int pageNumber)
        {
            try
            {
                var result = await _hotelRepo.Search(name);

                if (!result.Any())
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
    }
}
