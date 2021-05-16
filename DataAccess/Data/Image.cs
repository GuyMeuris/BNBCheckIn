using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class Image
    {
        [Key]
        public int ImageId { get; set; }
        [Required]
        public string ImageSourceUrl { get; set; } 
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }



        [ForeignKey(nameof(BnB))]
        public int? BnBId { get; set; }
        public virtual BnB BnB { get; set; }

        [ForeignKey(nameof(Room))]
        public int? RoomId { get; set; }
        public virtual Room Room { get; set; }

    }
}
