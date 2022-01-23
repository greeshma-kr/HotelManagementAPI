using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagement.Models
{
    public class HotelImageModel
    {
        public int Id { get; set; }
        public string mediaUrl { get; set; }
        public int Primary_flag { get; set; }
    }
}
