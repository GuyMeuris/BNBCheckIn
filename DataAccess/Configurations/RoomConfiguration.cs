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
                        IsVacant = true,
                        BnBId = 1
                    },
                    new Room
                    {
                        RoomId = 2,
                        RoomName = "Rozenkamer",
                        Occupancy = 2,
                        Rate = 100,
                        RoomSize = 28,
                        IsVacant = true,
                        BnBId = 1
                    },
                    new Room
                    {
                        RoomId = 3,
                        RoomName = "Wespenkamer",
                        Occupancy = 3,
                        Rate = 115,
                        RoomSize = 46,
                        IsVacant = false,
                        BnBId = 1
                    },
                    new Room
                    {
                        RoomId = 4,
                        RoomName = "Bijenkamer",
                        Occupancy = 1,
                        Rate = 97,
                        RoomSize = 35,
                        IsVacant = true,
                        BnBId = 2
                    },
                    new Room
                    {
                        RoomId = 5,
                        RoomName = "Mierenkamer",
                        Occupancy = 4,
                        Rate = 124,
                        RoomSize = 29,
                        IsVacant = true,
                        BnBId = 2
                    },
                    new Room
                    {
                        RoomId = 6,
                        RoomName = "Duizendpootkamer",
                        Occupancy = 2,
                        Rate = 116,
                        RoomSize = 26,
                        IsVacant = false,
                        BnBId = 2
                    },
                    new Room
                    {
                        RoomId = 7,
                        RoomName = "Muggenkamer",
                        Occupancy = 2,
                        Rate = 119,
                        RoomSize = 36,
                        IsVacant = true,
                        BnBId = 3
                    },
                    new Room
                    {
                        RoomId = 8,
                        RoomName = "Spinnenkamer",
                        Occupancy = 3,
                        Rate = 100,
                        RoomSize = 28,
                        IsVacant = true,
                        BnBId = 4
                    },
                    new Room
                    {
                        RoomId = 9,
                        RoomName = "Tulpenkamer",
                        Occupancy = 2,
                        Rate = 99,
                        RoomSize = 36,
                        IsVacant = true,
                        BnBId = 4
                    },
                    new Room
                    {
                        RoomId = 10,
                        RoomName = "Chrysantenkamer",
                        Occupancy = 1,
                        Rate = 107,
                        RoomSize = 38,
                        IsVacant = true,
                        BnBId = 4
                    },
                    new Room
                    {
                        RoomId = 11,
                        RoomName = "Freziakamer",
                        Occupancy = 2,
                        Rate = 108,
                        RoomSize = 36,
                        IsVacant = true,
                        BnBId = 4
                    },
                    new Room
                    {
                        RoomId = 12,
                        RoomName = "Narcissenkamer",
                        Occupancy = 5,
                        Rate = 139,
                        RoomSize = 44,
                        IsVacant = false,
                        BnBId = 5
                    }
                ); ;
        }
    }
}
