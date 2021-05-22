using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsDTO
{
    public class CreateBnBDTO
    {
        [Required(ErrorMessage ="B&B naam is een verplicht veld.")]
        public string BnBName { get; set; }

        [Required(ErrorMessage = "Straatnaam is een verplicht veld.")]
        public string StreetName { get; set; }

        [MaxLength(12, ErrorMessage ="Bijv. 128 bus F.")]
        [Required(ErrorMessage = "Huisnummer is een verplicht veld.")]
        public string HouseNumber { get; set; }

        [Range(1000, 9999, ErrorMessage ="Postcode moet een getal zijn tussen 1000 en 9999.")]
        [Required(ErrorMessage = "Postcode is een verplicht veld.")]
        public int PostalCode { get; set; }

        [Required(ErrorMessage = "Gemeente is een verplicht veld.")]
        public string Municipality { get; set; }

        [Required(ErrorMessage = "Provincie is een verplicht veld.")]
        public string Province { get; set; }

        [Required(ErrorMessage = "BTW nr. is een verplicht veld.")]
        public string VATnr { get; set; }

        [Required(ErrorMessage = "Bankrekeningnr. is een verplicht veld.")]
        public string BankAccountNr { get; set; }

        public string BnBDetails { get; set; }
        }

        public class BnBDTO : CreateBnBDTO
        {
            public int BnBId { get; set; }

            public int ContactId { get; set; }

            public ContactDTO Contacts { get; set; }

            public virtual List<string> BnBImageUrls { get; set; }

            public virtual ICollection<BnBImageDTO> BnBImages { get; set; }

            public virtual ICollection<RoomDTO> Rooms { get; set; }

            public virtual ICollection<AmenityDTO> Amenities { get; set; }
        }
}
