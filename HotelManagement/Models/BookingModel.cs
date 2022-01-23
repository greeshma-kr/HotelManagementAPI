using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagement.Models
{
    public class BookingModel
    {
        public int Id { get; set; }

       [Required(ErrorMessage = "Please provide hotel Id")]
        public int HotelId { get; set; }

        [Required(ErrorMessage = "Please provide checkIndate")]
        public string CheckIn_Date { get; set; }
        public string CheckOut_Date { get; set; }

        [Required(ErrorMessage = "Please provide Contact Number")]
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public List<GuestModel> Guests { get; set; }
        public string RoomType { get; set; }

        [Required(ErrorMessage = "Please provide number of rooms required")]
        public string NoOfRooms { get; set; }
        public int Children { get; set; }

        [Required(ErrorMessage = "Please provide number of adults")]
        public int Adults { get; set; }
        public int UserId { get; set; }
    }
}
