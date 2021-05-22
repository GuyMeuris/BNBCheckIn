using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsDTO
{
    public class CreateContactDTO
    {
        [Required(ErrorMessage = "Naam is een verplicht veld.")]
        [MaxLength(100, ErrorMessage = "Maximum toegelaten tekens is 100.")]
        public string ContactName { get; set; }

        [Required(ErrorMessage = "Email is een verplicht veld.")]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        [MaxLength(40, ErrorMessage = "Maximum toegelaten tekens is 40.")]
        public string UserName { get; set; }

        [MaxLength(50, ErrorMessage = "Maximum toegelaten tekens is 50.")]
        public string Password { get; set; }
    }

    public class ContactDTO : CreateContactDTO
    {
        public int ContactId { get; set; }

        public virtual BnBDTO BnB { get; set; }
    }
}
