using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configurations
{
    // Class for seeding starting data in the server app
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> modelBuilder)
        {
            modelBuilder
                .HasData(
                    new Room
                    {
                        RoomId = 1,
                        RoomName = "Hommelkamer",
                        Occupancy = 2,
                        Rate = 105,
                        RoomSize = 36,
                        RoomDetails ="details hier",
                        BnBId = 1
                    },
                    new Room
                    {
                        RoomId = 2,
                        RoomName = "Rozenkamer",
                        Occupancy = 2,
                        Rate = 100,
                        RoomSize = 28,
                        RoomDetails = "details hier",
                        BnBId = 1
                    },
                    new Room
                    {
                        RoomId = 3,
                        RoomName = "Wespenkamer",
                        Occupancy = 3,
                        Rate = 115,
                        RoomSize = 46,
                        RoomDetails = "details hier",
                        BnBId = 1
                    },
                    new Room
                    {
                        RoomId = 4,
                        RoomName = "Bijenkamer",
                        Occupancy = 1,
                        Rate = 97,
                        RoomSize = 35,
                        RoomDetails = "details hier",
                        BnBId = 2
                    },
                    new Room
                    {
                        RoomId = 5,
                        RoomName = "Mierenkamer",
                        Occupancy = 4,
                        Rate = 124,
                        RoomSize = 29,
                        RoomDetails = "details hier",
                        BnBId = 2
                    },
                    new Room
                    {
                        RoomId = 6,
                        RoomName = "Duizendpootkamer",
                        Occupancy = 2,
                        Rate = 116,
                        RoomSize = 26,
                        RoomDetails = "details hier",
                        BnBId = 2
                    }
                ); ;
        }
    }
}
