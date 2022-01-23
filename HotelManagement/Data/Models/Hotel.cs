using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagement.Data
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Hotel_Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string Price_currency { get; set; }
        public string City { get; set; }
        public Address Address { get; set; }
        public Rating Rating { get; set; }
        public List<HotelImages> Images { get; set; }
        public Facilities Facilities { get; set; }


    }
}
