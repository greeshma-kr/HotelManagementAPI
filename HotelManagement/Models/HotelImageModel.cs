using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagement.Models
{
    public class HotelImageModel
    {
        public int Id { get; set; }
        public string MediaUrl { get; set; }
        public Boolean PrimaryFlag { get; set; }
    }
}
