using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsDTO
{
    // The 'Create...DTO' will handle all non-ID-required actions!
    public class CreateAmenityDTO
    {
        [Required (ErrorMessage ="Naam is een verplicht veld.")]
        [MaxLength(50, ErrorMessage = "Maximum toegelaten tekens is 50.")]
        public string AmenityName { get; set; }

        [Required(ErrorMessage = "Prijs is een verplicht veld.")]
        public double AmenityRate { get; set; }

        public string AmenityIcon { get; set; }

        public string AmenityDescription { get; set; }
    }

    // Usually new classes get their own file, but because it is just a small application
    // we keep all the '...DTO'-classes in this file.
    public class AmenityDTO : CreateAmenityDTO
    {
        public int AmenityId { get; set; }

        public virtual ICollection<BnBDTO> BnBs { get; set; }

        public virtual ICollection<RoomDTO> Rooms { get; set; }
    }
}
