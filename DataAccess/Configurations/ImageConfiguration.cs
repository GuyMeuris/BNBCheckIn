using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(
                new Image
                {
                    ImageId = 1,
                    ImageName = "fotooke",
                    ImageSourceUrl = "~/css/images/fotooke.png",
                    ImageDescription = "schoon fotooke van een grasplein"  ,
                    RoomId = 1
                },
                new Image
                {
                    ImageId = 2,
                    ImageName = "polaroid",
                    ImageSourceUrl = "~/css/images/polaroid.png",
                    ImageDescription = "schoon fotooke van een grasperk",
                    BnBId = 1
                },
                new Image
                {
                    ImageId = 3,
                    ImageName = "imageke",
                    ImageSourceUrl = "~/css/images/imageke.png",
                    ImageDescription = "schoon fotooke van ne gazon",
                    RoomId = 3,
                    BnBId = 1
                },
                new Image
                {
                    ImageId = 4,
                    ImageName = "prentje",
                    ImageSourceUrl = "~/css/images/prentje.png",
                    ImageDescription = "schoon fotooke van een weideke",
                    RoomId = 9
                },
                new Image
                {
                    ImageId = 5,
                    ImageName = "plaatje",
                    ImageSourceUrl = "~/css/images/plaatje.png",
                    ImageDescription = "schoon fotooke van een tuintje",
                    BnBId = 5
                },
                new Image
                {
                    ImageId = 6,
                    ImageName = "kaartje",
                    ImageSourceUrl = "~/css/images/kaartje.png",
                    ImageDescription = "schoon fotooke van een shrubbery",
                    RoomId = 7
                }

                );
        }
    }
}
