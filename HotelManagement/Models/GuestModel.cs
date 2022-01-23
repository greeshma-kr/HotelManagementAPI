using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagement.Models
{
    public class GuestModel
    {

        public int Id { get; set; }
        public int ReservationId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string IDType { get; set; }
        public string IDNumber { get; set; }
    }
}
