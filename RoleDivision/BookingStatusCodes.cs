using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class BookingStatusCodes
    {
        public const string Status_Pending = "In Behandeling";
        
        public const string Status_Booked = "Gereserveerd";
        
        public const string Status_CheckedIn = "Ingechecked";
        
        public const string Status_CheckedOut_Completed = "Uitgechecked";
        
        public const string Status_NoShow = "Niet Aangekomen";
        
        public const string Status_Cancelled = "Geannulleerd";

    }
}
