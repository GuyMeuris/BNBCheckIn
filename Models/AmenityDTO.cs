using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsDTO
{
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

    public class AmenityDTO : CreateAmenityDTO
    {
        public int AmenityId { get; set; }

        public virtual ICollection<BnBDTO> BnBs { get; set; }

        public virtual ICollection<RoomDTO> Rooms { get; set; }
    }
}
