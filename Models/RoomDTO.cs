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

        [Range(1, 6, ErrorMessage = "De kamercapaciteit moet min. 1 en mag max. 6 personen bedragen.")]
        [Required(ErrorMessage = "De capaciteit van de kamer is een verplicht veld.")]
        public int Occupancy { get; set; }

        [Range(1, 2000, ErrorMessage = "De prijs/nacht moet een bedrag zijn tussen € 1 en € 2000.")]
        [Required(ErrorMessage = "De prijs/nacht van de kamer is een verplicht veld.")]
        public double Rate { get; set; }

        [Range(5, 1000, ErrorMessage = "De kameroppervlakte moet min. 5 en mag max. 1000 m² bedragen.")]
        [Required(ErrorMessage = "De kameroppervlakte is een verplicht veld.")]
        public int RoomSize { get; set; }

        public bool PetsAllowed { get; set; } = false;

        public string RoomDetails { get; set; }

        public int BnBId { get; set; }

        public double TotalDays { get; set; }

        public double TotalAmount { get; set; }

    }

    public class RoomDTO : CreateRoomDTO
    {
        public int RoomId { get; set; }

        public BnBDTO BnB { get; set; }

        public virtual ICollection<RoomImageDTO> RoomImages { get; set; }

        public virtual ICollection<AmenityDTO> Amenities { get; set; }

        public List<string> RoomImageUrls { get; set; }
    }

}
