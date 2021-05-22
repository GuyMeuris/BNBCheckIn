using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsDTO
{
    public class RoomImageDTO
    {
        public int RoomImageId { get; set; }

        public string RoomImageSourceUrl { get; set; }
        
        public int RoomId { get; set; }
    }

}
