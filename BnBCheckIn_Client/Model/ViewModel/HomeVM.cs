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
        [Required(ErrorMessage = "Startdatum is een verplicht veld.")]
        [DataType(DataType.DateTime, ErrorMessage = "Startdatum moet correct worden ingegeven.")]
        public DateTime StartDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Einddatum is een verplicht veld.")]
        [DataType(DataType.DateTime, ErrorMessage = "Startdatum moet correct worden ingegeven.")]
        public DateTime EndDate { get; set; } = DateTime.Now.AddDays(1);

        [Required(ErrorMessage = "Provincie is een verplicht veld.")]
        public string Province { get; set; } = "alle provincies";

        public int NoOfNights { get; set; } = 1;
    }
}
