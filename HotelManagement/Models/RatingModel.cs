using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagement.Models
{
    public class RatingModel
    {

        public int Id { get; set; }
        public int Votes_count { get; set; }

        public string value { get; set; }

        public int HotelId { get; set; }
    }
}
