using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsDTO
{
    public class ContactDTO
    {
        [Required(ErrorMessage = "Naam is een verplicht veld.")]
        [MaxLength(100, ErrorMessage = "Maximum toegelaten tekens is 100.")]
        public string ContactName { get; set; }

        [Required(ErrorMessage = "Email is een verplicht veld.")]
        [EmailAddress]
        public string Email { get; set; }
        
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        public int? BnBId { get; set; }
    }
}
