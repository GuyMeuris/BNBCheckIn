using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class Amenity
    {
        [Key]
        public int AmenityId { get; set; }
        [Required]
        public string AmenityName { get; set; }
        public string AmenityIcon { get; set; }
        public string AmenityDescription { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }


        public IList<BnB> BnBsWithAmenities { get; set; }
        public IList<Room> RoomsWithAmenities{ get; set; }

    }
}
