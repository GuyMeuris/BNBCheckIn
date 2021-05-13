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
                    ContactId = 1
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
                    ContactId = 2
                },
                new BnB
                {
                    BnBId = 3,
                    BnBName = "Scheldezicht",
                    StreetName = "Bollekeslei",
                    HouseNumber = "88",
                    PostalCode = 2100,
                    Municipality = "Linkeroever",
                    Province = "Antwerpen",
                    VATnr = "BE3524987diefstal",
                    BankAccountNr = "BE59987nogmeerdiefstal",
                    ContactId = 2
                },
                new BnB
                {
                    BnBId = 4,
                    BnBName = "De Wieg",
                    StreetName = "Beschavingsstraat",
                    HouseNumber = "44",
                    PostalCode = 1730,
                    Municipality = "Kester",
                    Province = "Vlaams-Brabant",
                    VATnr = "BE3524123diefstal",
                    BankAccountNr = "BE59123nogmeerdiefstal",
                    ContactId = 3
                },
                new BnB
                {
                    BnBId = 5,
                    BnBName = "Nie Neute",
                    StreetName = "Ledebergstraat",
                    HouseNumber = "24",
                    PostalCode = 9300,
                    Municipality = "Merelbeke",
                    Province = "Oost-Vlaanderen",
                    VATnr = "BE3524789diefstal",
                    BankAccountNr = "BE59789nogmeerdiefstal",
                    ContactId = 4
                }
                );
        }
    }
}
