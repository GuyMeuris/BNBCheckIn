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
    // Class for seeding starting data in the server app
    public class AmenityConfiguration : IEntityTypeConfiguration<Amenity>
    {
        public void Configure(EntityTypeBuilder<Amenity> builder)
        {
            builder.HasData(
                new Amenity
                {
                    AmenityId = 1,
                    AmenityName = "free wifi",
                    AmenityRate = 0,
                    AmenityDescription = "We don't charge you for using our wifi."
                },
                new Amenity
                {
                    AmenityId = 2,
                    AmenityName = "pool",
                    AmenityRate = 20,
                    AmenityDescription = "We don't swim in your toilet, so please don't pee in our pool."
                },
                new Amenity
                {
                    AmenityId = 3,
                    AmenityName = "sauna",
                    AmenityRate = 25,
                    AmenityDescription = "For people who like to sweat"
                },
                new Amenity
                {
                    AmenityId = 4,
                    AmenityName = "jacuzzi",
                    AmenityRate = 33,
                    AmenityDescription = "The relaxing kind, not the Japanese maffia."
                },
                new Amenity
                {
                    AmenityId = 5,
                    AmenityName = "pingpongtafelke",
                    AmenityRate = 0,
                    AmenityDescription = "For rainy days."
                }
                );
        }
    }
}
