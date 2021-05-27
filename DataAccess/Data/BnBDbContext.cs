using DataAccess.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class BnBDbContext : IdentityDbContext<User>
    {
        public BnBDbContext(DbContextOptions<BnBDbContext> options) : base(options)
        {

        }

        //  Dummy data quantity:

        public DbSet<Room> Rooms { get; set; }   // -->  At least 1 per B&B to start 

        public DbSet<BnB> BnBs { get; set; }     // -->   1 per province to start   *

        public DbSet<RoomImage> RoomImages { get; set; }  
        
        public DbSet<BnBImage> BnBImages { get; set; }  

        public DbSet<Amenity> Amenities { get; set; }   // --> 5 to start

        public DbSet<Contact> Contacts { get; set; }    //  -->  At least 1 owner per B&B and 2 users to start

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new AmenityConfiguration());

            modelBuilder.ApplyConfiguration(new ContactConfiguration());

            modelBuilder.ApplyConfiguration(new BnBConfiguration());

            modelBuilder.ApplyConfiguration(new RoomConfiguration());

            modelBuilder.SharedTypeEntity<Dictionary<string, object>>("AmenityBnB")
                .HasData(
                    new { AmenitiesAmenityId = 1, BnBsBnBId = 1 },
                    new { AmenitiesAmenityId = 1, BnBsBnBId = 5 },
                    new { AmenitiesAmenityId = 1, BnBsBnBId = 3 },
                    new { AmenitiesAmenityId = 1, BnBsBnBId = 4 },
                    new { AmenitiesAmenityId = 2, BnBsBnBId = 3 },
                    new { AmenitiesAmenityId = 3, BnBsBnBId = 1 },
                    new { AmenitiesAmenityId = 3, BnBsBnBId = 3 },
                    new { AmenitiesAmenityId = 4, BnBsBnBId = 1 },
                    new { AmenitiesAmenityId = 4, BnBsBnBId = 3 },
                    new { AmenitiesAmenityId = 4, BnBsBnBId = 5 },
                    new { AmenitiesAmenityId = 5, BnBsBnBId = 2 },
                    new { AmenitiesAmenityId = 5, BnBsBnBId = 4 }
                );

            modelBuilder.SharedTypeEntity<Dictionary<string, object>>("AmenityRoom")
                .HasData(
                    new { AmenitiesAmenityId = 1, RoomsRoomId = 1 },
                    new { AmenitiesAmenityId = 1, RoomsRoomId = 2 },
                    new { AmenitiesAmenityId = 1, RoomsRoomId = 3 },
                    new { AmenitiesAmenityId = 1, RoomsRoomId = 7 },
                    new { AmenitiesAmenityId = 1, RoomsRoomId = 8 },
                    new { AmenitiesAmenityId = 1, RoomsRoomId = 9 },
                    new { AmenitiesAmenityId = 1, RoomsRoomId = 10 },
                    new { AmenitiesAmenityId = 1, RoomsRoomId = 11 },
                    new { AmenitiesAmenityId = 1, RoomsRoomId = 12 },
                    new { AmenitiesAmenityId = 3, RoomsRoomId = 7 },
                    new { AmenitiesAmenityId = 3, RoomsRoomId = 10 },
                    new { AmenitiesAmenityId = 3, RoomsRoomId = 11 },
                    new { AmenitiesAmenityId = 4, RoomsRoomId = 11 },
                    new { AmenitiesAmenityId = 4, RoomsRoomId = 5 }
                );
   
        }
    }
}
