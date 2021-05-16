using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Amenities",
                columns: new[] { "AmenityId", "AmenityDescription", "AmenityIcon", "AmenityName", "AmenityRate", "CreatedBy", "CreatedOn", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, "We don't charge you for using our wifi.", null, "free wifi", 0.0, null, new DateTime(2021, 5, 16, 15, 52, 38, 98, DateTimeKind.Local).AddTicks(4914), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "We don't swim in your toilet, so please don't pee in our pool.", null, "pool", 20.0, null, new DateTime(2021, 5, 16, 15, 52, 38, 101, DateTimeKind.Local).AddTicks(5059), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "For people who like to sweat", null, "sauna", 25.0, null, new DateTime(2021, 5, 16, 15, 52, 38, 101, DateTimeKind.Local).AddTicks(5096), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "The relaxing kind, not the Japanese maffia.", null, "jacuzzi", 33.0, null, new DateTime(2021, 5, 16, 15, 52, 38, 101, DateTimeKind.Local).AddTicks(5102), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "For rainy days.", null, "pingpongtafelke", 0.0, null, new DateTime(2021, 5, 16, 15, 52, 38, 101, DateTimeKind.Local).AddTicks(5234), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "ContactName", "CreatedBy", "CreatedOn", "Email", "Password", "PhoneNumber", "UpdatedBy", "UpdatedOn", "UserName" },
                values: new object[,]
                {
                    { 1, "Arthur Blanckaert", null, new DateTime(2021, 5, 16, 15, 52, 38, 103, DateTimeKind.Local).AddTicks(2180), "tuur@zanger.be", null, "016/026.754", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, "Eddy Wally", null, new DateTime(2021, 5, 16, 15, 52, 38, 103, DateTimeKind.Local).AddTicks(3994), "wally@zanger.be", null, "09/657.237", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, "Rocking Moustache", null, new DateTime(2021, 5, 16, 15, 52, 38, 103, DateTimeKind.Local).AddTicks(4008), "moustache@zanger.be", null, "016/981.247", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, "Koen Crucke", null, new DateTime(2021, 5, 16, 15, 52, 38, 103, DateTimeKind.Local).AddTicks(4012), "crucke@zanger.be", null, "03/026.754", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, "Bart Kaëll", null, new DateTime(2021, 5, 16, 15, 52, 38, 103, DateTimeKind.Local).AddTicks(4014), "kajell@zanger.be", "123", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "snellenbeire" },
                    { 6, "Luk Steeno", null, new DateTime(2021, 5, 16, 15, 52, 38, 103, DateTimeKind.Local).AddTicks(4817), "steeno@zanger.be", "123", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kasseisteeno" }
                });

            migrationBuilder.InsertData(
                table: "BnBs",
                columns: new[] { "BnBId", "BankAccountNr", "BnBName", "ContactId", "CreatedBy", "CreatedOn", "HouseNumber", "Municipality", "PostalCode", "Province", "StreetName", "UpdatedBy", "UpdatedOn", "VATnr" },
                values: new object[,]
                {
                    { 1, "BE59889nogmeerdiefstal", "Boerenhol", 1, null, new DateTime(2021, 5, 16, 15, 52, 38, 103, DateTimeKind.Local).AddTicks(9234), "4", "Reningelst", 8970, "West-Vlaanderen", "Driegoenstraat", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BE3524874diefstal" },
                    { 2, "BE59654nogmeerdiefstal", "Boskant", 2, null, new DateTime(2021, 5, 16, 15, 52, 38, 104, DateTimeKind.Local).AddTicks(3519), "8", "Helchteren", 3530, "Limburg", "Terrillstraat", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BE3526654diefstal" },
                    { 3, "BE59987nogmeerdiefstal", "Scheldezicht", 2, null, new DateTime(2021, 5, 16, 15, 52, 38, 104, DateTimeKind.Local).AddTicks(3534), "88", "Linkeroever", 2100, "Antwerpen", "Bollekeslei", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BE3524987diefstal" },
                    { 4, "BE59123nogmeerdiefstal", "De Wieg", 3, null, new DateTime(2021, 5, 16, 15, 52, 38, 104, DateTimeKind.Local).AddTicks(3539), "44", "Kester", 1730, "Vlaams-Brabant", "Beschavingsstraat", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BE3524123diefstal" },
                    { 5, "BE59789nogmeerdiefstal", "Nie Neute", 4, null, new DateTime(2021, 5, 16, 15, 52, 38, 104, DateTimeKind.Local).AddTicks(3541), "24", "Merelbeke", 9300, "Oost-Vlaanderen", "Ledebergstraat", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BE3524789diefstal" }
                });

            migrationBuilder.InsertData(
                table: "AmenityBnB",
                columns: new[] { "AmenitiesAmenityId", "BnBsBnBId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 5 },
                    { 5, 4 },
                    { 1, 4 },
                    { 4, 3 },
                    { 3, 3 },
                    { 4, 5 },
                    { 1, 3 },
                    { 2, 3 },
                    { 5, 2 },
                    { 4, 1 },
                    { 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomId", "BnBId", "CreatedBy", "CreatedDate", "IsVacant", "Occupancy", "PetsAllowed", "Rate", "RoomName", "RoomSize", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 6, 2, null, new DateTime(2021, 5, 16, 15, 52, 38, 105, DateTimeKind.Local).AddTicks(5331), false, 2, false, 116.0, "Duizendpootkamer", 26, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 2, null, new DateTime(2021, 5, 16, 15, 52, 38, 105, DateTimeKind.Local).AddTicks(5326), true, 1, false, 97.0, "Bijenkamer", 35, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, null, new DateTime(2021, 5, 16, 15, 52, 38, 105, DateTimeKind.Local).AddTicks(5322), false, 3, false, 115.0, "Wespenkamer", 46, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, null, new DateTime(2021, 5, 16, 15, 52, 38, 105, DateTimeKind.Local).AddTicks(5307), true, 2, false, 100.0, "Rozenkamer", 28, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 3, null, new DateTime(2021, 5, 16, 15, 52, 38, 105, DateTimeKind.Local).AddTicks(5334), true, 2, false, 119.0, "Muggenkamer", 36, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 1, null, new DateTime(2021, 5, 16, 15, 52, 38, 104, DateTimeKind.Local).AddTicks(9657), true, 2, false, 105.0, "Hommelkamer", 36, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 4, null, new DateTime(2021, 5, 16, 15, 52, 38, 105, DateTimeKind.Local).AddTicks(5336), true, 3, false, 100.0, "Spinnenkamer", 28, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 4, null, new DateTime(2021, 5, 16, 15, 52, 38, 105, DateTimeKind.Local).AddTicks(5339), true, 2, false, 99.0, "Tulpenkamer", 36, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 4, null, new DateTime(2021, 5, 16, 15, 52, 38, 105, DateTimeKind.Local).AddTicks(5341), true, 1, false, 107.0, "Chrysantenkamer", 38, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 4, null, new DateTime(2021, 5, 16, 15, 52, 38, 105, DateTimeKind.Local).AddTicks(5344), true, 2, false, 108.0, "Freziakamer", 36, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 2, null, new DateTime(2021, 5, 16, 15, 52, 38, 105, DateTimeKind.Local).AddTicks(5328), true, 4, false, 124.0, "Mierenkamer", 29, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 5, null, new DateTime(2021, 5, 16, 15, 52, 38, 105, DateTimeKind.Local).AddTicks(5346), false, 5, false, 139.0, "Narcissenkamer", 44, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AmenityRoom",
                columns: new[] { "AmenitiesAmenityId", "RoomsRoomId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 4, 5 },
                    { 1, 7 },
                    { 3, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 1, 10 },
                    { 3, 10 },
                    { 1, 11 },
                    { 3, 11 },
                    { 4, 11 },
                    { 1, 12 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AmenityBnB",
                keyColumns: new[] { "AmenitiesAmenityId", "BnBsBnBId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AmenityBnB",
                keyColumns: new[] { "AmenitiesAmenityId", "BnBsBnBId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "AmenityBnB",
                keyColumns: new[] { "AmenitiesAmenityId", "BnBsBnBId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "AmenityBnB",
                keyColumns: new[] { "AmenitiesAmenityId", "BnBsBnBId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "AmenityBnB",
                keyColumns: new[] { "AmenitiesAmenityId", "BnBsBnBId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "AmenityBnB",
                keyColumns: new[] { "AmenitiesAmenityId", "BnBsBnBId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "AmenityBnB",
                keyColumns: new[] { "AmenitiesAmenityId", "BnBsBnBId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "AmenityBnB",
                keyColumns: new[] { "AmenitiesAmenityId", "BnBsBnBId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "AmenityBnB",
                keyColumns: new[] { "AmenitiesAmenityId", "BnBsBnBId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "AmenityBnB",
                keyColumns: new[] { "AmenitiesAmenityId", "BnBsBnBId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "AmenityBnB",
                keyColumns: new[] { "AmenitiesAmenityId", "BnBsBnBId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "AmenityBnB",
                keyColumns: new[] { "AmenitiesAmenityId", "BnBsBnBId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityId", "RoomsRoomId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityId", "RoomsRoomId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityId", "RoomsRoomId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityId", "RoomsRoomId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityId", "RoomsRoomId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityId", "RoomsRoomId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityId", "RoomsRoomId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityId", "RoomsRoomId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityId", "RoomsRoomId" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityId", "RoomsRoomId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityId", "RoomsRoomId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityId", "RoomsRoomId" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityId", "RoomsRoomId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityId", "RoomsRoomId" },
                keyValues: new object[] { 4, 11 });

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 4);
        }
    }
}
