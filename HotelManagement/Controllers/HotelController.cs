using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelManagement.Helpers;
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

        [HttpGet("get-hotel/{id}")]
        public async Task<IActionResult> GetHotelById([FromRoute] int id)
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


        [HttpGet("search")]
        public async Task<IActionResult> Search(string name, int pageNumber, int pageSize)
        {
            try
            {
                var validFilter = new PaginationFilter(pageNumber, pageSize);

                var result = await _hotelRepo.Search(name, validFilter.PageNumber, validFilter.PageSize);

                if (!result.Any())
                {
                    return NotFound();
                }
                return Ok(new PagedResponse<List<HotelModel>>(result, validFilter.PageNumber, validFilter.PageSize));

                // return Ok(result);

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
    }
}
