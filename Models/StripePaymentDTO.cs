using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsDTO
{
    // Class for the handling payment information
    public class StripePaymentDTO
    {
        public string BnBRoomProduct { get; set; }

        public long Amount { get; set; }

        public string ImageUrl { get; set; }
        
        public string ReturnUrl { get; set; }
    }
}
