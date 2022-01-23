
using HotelManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagement.Repository
{
    public interface IHotelRepository 
    {
        Task<List<HotelModel>> Search(string searchKey, int pageNumber, int pageSize);
        Task<HotelModel> GetHotelByIdAsync(int hotelId);
    }
}
