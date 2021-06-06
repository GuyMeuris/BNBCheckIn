using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class BnB
    {
        [Key]
        public int BnBId { get; set; }
        [Required]
        public string BnBName { get; set; }
        [Required]
        public string StreetName { get; set; }
        [Required]
        public string HouseNumber { get; set; }
        [Required]
        public int PostalCode { get; set; }
        [Required]
        public string Municipality { get; set; }
        [Required]
        public string Province { get; set; }
        [Required]
        public string VATnr { get; set; }
        [Required]
        public string BankAccountNr { get; set; }
        [Required]
        public string NameOwner { get; set; }
        [Required]
        public string BnBEmail { get; set; }

        public string BnBPhone { get; set; }

        public string BnBDetails { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;

        public string UpdatedBy { get; set; }

        public DateTime UpdatedOn { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }

        public virtual ICollection<BnBImage> BnBImages { get; set; }

        public virtual IList<Amenity> Amenities { get; set; }
    }
}
