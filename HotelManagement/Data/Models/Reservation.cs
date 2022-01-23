using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagement.Data
{
    public class Reservation
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public string CheckIn_Date { get; set; }
        public string CheckOut_Date { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public DateTime DateAdded { get; set; }
        public List<Guests> Guests { get; set; } 
        public string RoomType { get; set; }
        public string NoOfRooms { get; set; }
        public int Children { get; set; }
        public int Adults { get; set; }
        public int UserId { get; set; }

    }
}
