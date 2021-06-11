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
    public class BnBDbContext : IdentityDbContext<Contact>
    {
        public BnBDbContext(DbContextOptions<BnBDbContext> options) : base(options)
        {

        }

        public DbSet<Room> Rooms { get; set; }   

        public DbSet<BnB> BnBs { get; set; }    

        public DbSet<RoomImage> RoomImages { get; set; }  
        
        public DbSet<BnBImage> BnBImages { get; set; }  

        public DbSet<Amenity> Amenities { get; set; }  

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<RoomOrderDetails> RoomOrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new AmenityConfiguration());

            modelBuilder.ApplyConfiguration(new BnBConfiguration());

            modelBuilder.ApplyConfiguration(new RoomConfiguration());

   
        }
    }
}
