using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsDTO
{
    public class CreateRoomOrderDetailsDTO
    {        
        [Required]
        public string UserId { get; set; }

        [Required]
        public string StripeSessionId { get; set; }

        [Required]
        public DateTime CheckInDate { get; set; }

        [Required]
        public DateTime CheckOutDate { get; set; }

        public DateTime ActualCheckInDate { get; set; }

        public DateTime ActualCheckOutDate { get; set; }

        [Required]
        public double TotalCost { get; set; }

        public bool IsPaymentSuccessful { get; set; } = false;

        [Required(ErrorMessage = "Naam is een verplicht veld. Geef opnieuw in.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Emailadres is een verplicht veld. Geef opnieuw in.")]
        [EmailAddress(ErrorMessage = "Emailadres was niet correct in gegeven. Geef opnieuw in.")]
        public string Email { get; set; }

        public string Phone { get; set; }

        public string OrderStatus { get; set; }

        [Required]
        public int RoomId { get; set; } 
    }

    public class RoomOrderDetailsDTO : CreateRoomOrderDetailsDTO
    {
        public int OrderId { get; set; }

        public RoomDTO BnBRoomDTO { get; set; }
    }
}
