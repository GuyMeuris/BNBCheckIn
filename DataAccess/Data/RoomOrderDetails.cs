using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class RoomOrderDetails
    {
        [Key]
        public int OrderId { get; set; }

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

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        public string Phone { get; set; }

        public string OrderStatus { get; set; }

        [Required]
        [ForeignKey(nameof(Room))]
        public int RoomId { get; set; }

        public Room BnBRoom { get; set; }
    }
}
