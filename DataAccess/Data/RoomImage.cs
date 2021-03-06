using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class RoomImage
    {
        [Key]
        public int RoomImageId { get; set; }

        [Required]
        public string RoomImageSourceUrl { get; set; } 

        public string CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;

        [ForeignKey(nameof(Room))]
        public int RoomId { get; set; }

        public virtual Room Room { get; set; }
        

    }
}
