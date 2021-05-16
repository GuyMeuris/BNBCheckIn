using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsDTO
{
    public class CreateRoomDTO
    {
        public string RoomName { get; set; }
        [Range(1, 6, ErrorMessage ="De kamercapaciteit moet minstens 1 en maximum 6 personen bedragen.")]
        [Required(ErrorMessage ="De capaciteit van de kamer is een verplicht veld.")]
        public int Occupancy { get; set; }
        [Range(1, 2000, ErrorMessage ="De prijs/nacht moet een bedrag zijn tussen € 1.00 en € 2000.00.")]
        [Required(ErrorMessage = "De prijs/nacht van de kamer is een verplicht veld.")]
        public double Rate { get; set; }
        [Range(5, 1000, ErrorMessage ="De kameroppervlakte moet minstens 5 en maximum 1000 m² bedragen.")]
        [Required(ErrorMessage ="De kameroppervlakte is een verplicht veld.")]
        public int RoomSize { get; set; }
        public bool PetsAllowed { get; set; } = false;
        public virtual ICollection<ImageDTO> BnBImages { get; set; }
    }
    public class RoomDTO : CreateRoomDTO
    {
        public int BnBId { get; set; }
        public BnBDTO BnB { get; set; }
        public virtual ICollection<AmenityDTO> Amenities { get; set; }
        public virtual IList<string> ImageUrls { get; set; }
    }
}
