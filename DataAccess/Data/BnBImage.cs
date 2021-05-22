using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class BnBImage
    {
        [Key]
        public int BnBImageId { get; set; }

        [Required]
        public string BnBImageSourceUrl { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;

        [ForeignKey(nameof(BnB))]
        public int BnBId { get; set; }

        public virtual BnB BnB { get; set; }
       
    }
}
