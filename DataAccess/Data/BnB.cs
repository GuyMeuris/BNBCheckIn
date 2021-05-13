using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    class BnB
    {
        [Key]
        public int BnBId { get; set; }
        [Required]
        public string BnBName { get; set; }
        [Required]
        public string StreetName { get; set; }
        [Required]
        public string StreetNumber { get; set; }
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
        public string CreatedByContact { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedByContact { get; set; }
        public DateTime UpdatedOn { get; set; }


        [ForeignKey]
        public int ContactId { get; set; }
        public Contact Contacts { get; set; }
        public virtual IList<Room> Rooms { get; set; }
        public virtual IList<Image> Images { get; set; }


    }
}
