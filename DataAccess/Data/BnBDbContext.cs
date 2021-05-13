using DataAccess.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class BnBDbContext : DbContext
    {
        public BnBDbContext(DbContextOptions<BnBDbContext> options) : base(options)
        {

        }

        //  Dummy data quantity:

        public DbSet<Room> Rooms { get; set; }   // -->  At least 1 per B&B to start 

        public DbSet<BnB> BnBs { get; set; }     // -->   1 per province to start

        public DbSet<Image> Images { get; set; }   //  -->  At least 1 per B&B AND 1 per room to start 

        public DbSet<Amenity> Amenities { get; set; }   // --> 5 to start

        public DbSet<Contact> Contacts { get; set; }    //  -->  At least 1 owner per B&B and 2 users to start
                                                          
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.ApplyConfiguration(new RoomConfiguration());
        //}
    }
}
