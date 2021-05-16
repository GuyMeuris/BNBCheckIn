using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsDTO
{
    public class CreateImageDTO
    {
        [Required]
        public string ImageSourceUrl { get; set; }

        public int? BnBId { get; set; }
        
        public int? RoomId { get; set; }   
    }

    public class ImageDTO :CreateImageDTO
    {
        public int ImageId { get; set; }

        public virtual BnBDTO BnB { get; set; }

        public virtual RoomDTO Room { get; set; }
    }
}
