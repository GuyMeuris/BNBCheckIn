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
    public class BnBConfiguration : IEntityTypeConfiguration<BnB>
    {
        public void Configure(EntityTypeBuilder<BnB> builder)
        {
            builder.HasData(
                new BnB
                {
                    BnBId = 1,
                    BnBName = "Boerenhol",
                    StreetName = "Driegoenstraat",
                    HouseNumber = "4",
                    PostalCode = 8970,
                    Municipality = "Reningelst",
                    Province = "West-Vlaanderen",
                    VATnr = "BE3524874diefstal",
                    BankAccountNr = "BE59889nogmeerdiefstal",
                    NameOwner = "Jos",
                    BnBEmail = "jos@mail",
                    BnBPhone = "0123",
                    BnBDetails = "details hier"
                },
                new BnB
                {
                    BnBId = 2,
                    BnBName = "Boskant",
                    StreetName = "Terrillstraat",
                    HouseNumber = "8",
                    PostalCode = 3530,
                    Municipality = "Helchteren",
                    Province = "Limburg",
                    VATnr = "BE3526654diefstal",
                    BankAccountNr = "BE59654nogmeerdiefstal",
                    NameOwner = "Jos",
                    BnBEmail = "jos@mail",
                    BnBPhone = "0123",
                    BnBDetails = "details hier"
                }
                );
        }
    }
}
