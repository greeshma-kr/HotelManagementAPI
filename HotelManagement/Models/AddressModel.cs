using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagement.Models
{
    public class AddressModel
    {

        public int Id { get; set; }

        public string HotelId { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string PostCode { get; set; }

        public string Landmark { get; set; }

        public string CountryCode { get; set; }

        public string Latitude { get; set; }
        public string Longitude { get; set; }

    }
}
