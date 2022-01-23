using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagement.Models
{
    public class ReviewsModel
    {
        public int Id { get; set; }


        public string Rating { get; set; }

        public string Review { get; set; }

        public int HotelId { get; set; }

    }
}
