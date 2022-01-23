using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagement.Data
{
    public class Rating
    {
        public int Id { get; set; }
        public int Votes_count { get; set; }

        public string Value { get; set; }

        public int HotelId { get; set; }
    }
}
