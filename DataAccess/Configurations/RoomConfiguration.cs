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
                        IsVacant = true
                    },
                    new Room
                    {
                        RoomId = 2,
                        RoomName = "Rozenkamer",
                        Occupancy = 2,
                        Rate = 100,
                        RoomSize = 28,
                        IsVacant = true
                    }
                ); ;
        }
    }
}
