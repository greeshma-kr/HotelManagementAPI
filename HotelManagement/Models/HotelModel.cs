using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagement.Models
{
    public class HotelModel
    {
        public int Id { get; set; }
        public string Hotel_Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string Price_currency { get; set; }
        public string City { get; set; }
        public AddressModel Address { get; set; }
        public RatingModel Rating { get; set; }
        public List<HotelImageModel> Images { get; set; }
        public FacilityModel Facilities { get; set; }
    }
}
