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
    public class HotelRepository : IHotelRepository
    {

        private readonly AppDbContext _context;

        private readonly IMapper _mapper;

        public HotelRepository(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<HotelModel> GetHotelByIdAsync(int id)
        {

            // var hotels = await _context.Hotel.ToListAsync();
            // return _mapper.Map<List<HotelModel>>(hotels);

            var hotels = await _context.Hotel
                  .AsNoTracking()
                 .Include(rating => rating.Rating)
                .Include(facil => facil.Facilities)
                .Include(address => address.Address)
                .Include(images => images.Images).FirstAsync(x => x.Id == id);

            return _mapper.Map<HotelModel>(hotels);


        }




        public async Task<List<HotelModel>> Search(string searchKey, int pageNumber, int pageSize)
        {
            if (!String.IsNullOrEmpty(searchKey))
            {
                var hotels = await _context.Hotel
               .AsNoTracking()
               .Include(rating => rating.Rating)
               .Include(facil => facil.Facilities)
               .Include(address => address.Address)
               .Include(images => images.Images)
               .Skip((pageNumber - 1) * pageSize)
               .Take(pageSize)
               .Where(hotel => hotel.Title.Contains(searchKey) || hotel.City.Contains(searchKey))
               .ToListAsync();

                return _mapper.Map<List<HotelModel>>(hotels);
            }
            else
            {
                var hotels = await _context.Hotel
                  .AsNoTracking()
                  .Include(rating => rating.Rating)
                  .Include(facil => facil.Facilities)
                  .Include(address => address.Address)
                  .Include(images => images.Images)
                  .Skip((pageNumber - 1) * pageSize)
                  .Take(pageSize)
                  .ToListAsync();

                return _mapper.Map<List<HotelModel>>(hotels);

            }

        }

    }
}
