using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsDTO
{
    // Class for the client registration authentication 
    public class UserRequestDTO
    {
        [Required(ErrorMessage = "Naam is een verplicht veld.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Emailadres is een verplicht veld.")]
        [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "Emailadres is niet correct ingegeven.")]
        public string Email { get; set; }

        public string PhoneNo { get; set; }

        [Required(ErrorMessage = "Paswoord is een verplicht veld.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Paswoord bevestigen is verplicht.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "De paswoorden komen niet overeen.")]
        public string ConfirmPassword { get; set; }
    }
}
