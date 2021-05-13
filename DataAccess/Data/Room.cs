using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    class Room
    {
        [Key]
        public int RoomId { get; set; }

        public string RoomName { get; set; } 

        [Required]
        public int Occupancy { get; set; }

        [Required]
        public double Rate { get; set; }

        public int RoomSize { get; set; }

        [Required]
        public bool IsVacant { get; set; }

        public bool PetsAllowed { get; set; } = false;

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public string UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        // We will need a link to our 'BnB'-class, because we would like
        // to attach a room to a B&B --> 'one-to-one'-relationship!
        [ForeignKey(nameof(BnB))]
        public int BnBId { get; set; }

        public BnB BnB { get; set; }

        // We will also need a link to our 'Amenity' and 'Image'-classes, because
        // we would like to attach each room to multiple amenities and images
        // --> 'one-to-many'-relationship!
        // We do this by adding a 'virtual' collections.
        public virtual IList<Amenity> Amenities { get; set; }

        public virtual IList<Image> Images { get; set; }
    }
}
