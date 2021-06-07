using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BnBCheckIn_Client.Model.ViewModel
{
    public class HomeVM
    {
        public DateTime StartDate { get; set; } = DateTime.Now;

        public DateTime EndDate { get; set; } = DateTime.Now.AddDays(1);

        public string Province { get; set; } = "alle provincies";

        public int NoOfNights { get; set; } = 1;
    }
}
