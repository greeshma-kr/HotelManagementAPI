﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagement.Data
{
    public class Facilities
    {
        public int id { get; set; }
        public int HotelId { get; set; }
        
        public Boolean Breakfast { get; set; }

        public Boolean Wifi { get; set; }

        public Boolean Parking { get; set; }

        public Boolean Spa { get; set; }

        public Boolean Pool { get; set; }

    }
}
