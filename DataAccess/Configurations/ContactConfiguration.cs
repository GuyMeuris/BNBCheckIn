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
    class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasData(
                new Contact
                {
                    ContactId = 1,
                    ContactName = "Arthur Blanckaert",
                    Email = "tuur@zanger.be",
                    PhoneNumber = "016/026.754"
                },
                new Contact
                {
                    ContactId = 2,
                    ContactName = "Eddy Wally",
                    Email = "wally@zanger.be",
                    PhoneNumber = "09/657.237"
                },
                new Contact
                {
                    ContactId = 3,
                    ContactName = "Rocking Moustache",
                    Email = "moustache@zanger.be",
                    PhoneNumber = "016/981.247"
                },
                new Contact
                {
                    ContactId = 4,
                    ContactName = "Koen Crucke",
                    Email = "crucke@zanger.be",
                    PhoneNumber = "03/026.754"
                },
                new Contact
                {
                    ContactId = 5,
                    ContactName = "Bart Kaëll",
                    Email = "kajell@zanger.be",
                    UserName = "snellenbeire",
                    Password = "123"
                },
                new Contact
                {
                    ContactId = 6,
                    ContactName = "Luk Steeno",
                    Email = "steeno@zanger.be",
                    UserName = "kasseisteeno",
                    Password = "123"
                }
                );
        }
    }
}
