using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddingDummyData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_BnBs_BnBId",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_BnBId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "BnBId",
                table: "Contacts");

            migrationBuilder.RenameColumn(
                name: "StreetNumber",
                table: "BnBs",
                newName: "HouseNumber");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<double>(
                name: "AmenityRate",
                table: "Amenities",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "Amenities",
                columns: new[] { "AmenityId", "AmenityDescription", "AmenityIcon", "AmenityName", "AmenityRate", "CreatedBy", "CreatedOn", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, "We don't charge you for using our wifi.", null, "free wifi", 0.0, null, new DateTime(2021, 5, 13, 17, 10, 6, 764, DateTimeKind.Local).AddTicks(5001), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "We don't swim in your toilet, so please don't pee in our pool.", null, "pool", 20.0, null, new DateTime(2021, 5, 13, 17, 10, 6, 767, DateTimeKind.Local).AddTicks(1213), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "For people who like to sweat", null, "sauna", 25.0, null, new DateTime(2021, 5, 13, 17, 10, 6, 767, DateTimeKind.Local).AddTicks(1243), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "The relaxing kind, not the Japanese maffia.", null, "jacuzzi", 33.0, null, new DateTime(2021, 5, 13, 17, 10, 6, 767, DateTimeKind.Local).AddTicks(1248), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "For rainy days.", null, "pingpongtafelke", 0.0, null, new DateTime(2021, 5, 13, 17, 10, 6, 767, DateTimeKind.Local).AddTicks(1251), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "ContactName", "CreatedBy", "CreatedOn", "Email", "Password", "PhoneNumber", "UpdatedBy", "UpdatedOn", "UserName" },
                values: new object[,]
                {
                    { 1, "Arthur Blanckaert", null, new DateTime(2021, 5, 13, 17, 10, 6, 768, DateTimeKind.Local).AddTicks(5777), "tuur@zanger.be", null, "016/026.754", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, "Eddy Wally", null, new DateTime(2021, 5, 13, 17, 10, 6, 768, DateTimeKind.Local).AddTicks(7612), "wally@zanger.be", null, "09/657.237", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, "Rocking Moustache", null, new DateTime(2021, 5, 13, 17, 10, 6, 768, DateTimeKind.Local).AddTicks(7625), "moustache@zanger.be", null, "016/981.247", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, "Koen Crucke", null, new DateTime(2021, 5, 13, 17, 10, 6, 768, DateTimeKind.Local).AddTicks(7628), "crucke@zanger.be", null, "03/026.754", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, "Bart Kaëll", null, new DateTime(2021, 5, 13, 17, 10, 6, 768, DateTimeKind.Local).AddTicks(7631), "kajell@zanger.be", "123", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "snellenbeire" },
                    { 6, "Luk Steeno", null, new DateTime(2021, 5, 13, 17, 10, 6, 768, DateTimeKind.Local).AddTicks(8421), "steeno@zanger.be", "123", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kasseisteeno" }
                });

            migrationBuilder.InsertData(
                table: "BnBs",
                columns: new[] { "BnBId", "BankAccountNr", "BnBName", "ContactId", "CreatedBy", "CreatedOn", "HouseNumber", "Municipality", "PostalCode", "Province", "StreetName", "UpdatedBy", "UpdatedOn", "VATnr" },
                values: new object[,]
                {
                    { 1, "BE59889nogmeerdiefstal", "Boerenhol", 1, null, new DateTime(2021, 5, 13, 17, 10, 6, 769, DateTimeKind.Local).AddTicks(2932), "4", "Reningelst", 8970, "West-Vlaanderen", "Driegoenstraat", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BE3524874diefstal" },
                    { 2, "BE59654nogmeerdiefstal", "Boskant", 2, null, new DateTime(2021, 5, 13, 17, 10, 6, 769, DateTimeKind.Local).AddTicks(7026), "8", "Helchteren", 3530, "Limburg", "Terrillstraat", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BE3526654diefstal" },
                    { 3, "BE59987nogmeerdiefstal", "Scheldezicht", 2, null, new DateTime(2021, 5, 13, 17, 10, 6, 769, DateTimeKind.Local).AddTicks(7040), "88", "Linkeroever", 2100, "Antwerpen", "Bollekeslei", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BE3524987diefstal" },
                    { 4, "BE59123nogmeerdiefstal", "De Wieg", 3, null, new DateTime(2021, 5, 13, 17, 10, 6, 769, DateTimeKind.Local).AddTicks(7044), "44", "Kester", 1730, "Vlaams-Brabant", "Beschavingsstraat", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BE3524123diefstal" },
                    { 5, "BE59789nogmeerdiefstal", "Nie Neute", 4, null, new DateTime(2021, 5, 13, 17, 10, 6, 769, DateTimeKind.Local).AddTicks(7046), "24", "Merelbeke", 9300, "Oost-Vlaanderen", "Ledebergstraat", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BE3524789diefstal" }
                });

            migrationBuilder.InsertData(
                table: "AmenityBnB",
                columns: new[] { "AmenitiesAmenityId", "BnBsBnBId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 4, 5 },
                    { 1, 5 },
                    { 5, 4 },
                    { 1, 4 },
                    { 4, 3 },
                    { 3, 3 },
                    { 1, 3 },
                    { 2, 3 },
                    { 3, 1 },
                    { 5, 2 },
                    { 4, 1 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "BnBId", "CreatedBy", "CreatedOn", "ImageDescription", "ImageName", "ImageSourceUrl", "RoomId", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 2, 1, null, new DateTime(2021, 5, 13, 17, 10, 6, 771, DateTimeKind.Local).AddTicks(6255), "schoon fotooke van een grasperk", "polaroid", "~/css/images/polaroid.png", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 5, null, new DateTime(2021, 5, 13, 17, 10, 6, 771, DateTimeKind.Local).AddTicks(7142), "schoon fotooke van een tuintje", "plaatje", "~/css/images/plaatje.png", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomId", "BnBId", "CreatedBy", "CreatedDate", "IsVacant", "Occupancy", "PetsAllowed", "Rate", "RoomName", "RoomSize", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 11, 4, null, new DateTime(2021, 5, 13, 17, 10, 6, 770, DateTimeKind.Local).AddTicks(6234), true, 2, false, 108.0, "Freziakamer", 36, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 4, null, new DateTime(2021, 5, 13, 17, 10, 6, 770, DateTimeKind.Local).AddTicks(6184), true, 1, false, 107.0, "Chrysantenkamer", 38, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 4, null, new DateTime(2021, 5, 13, 17, 10, 6, 770, DateTimeKind.Local).AddTicks(6181), true, 2, false, 99.0, "Tulpenkamer", 36, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 4, null, new DateTime(2021, 5, 13, 17, 10, 6, 770, DateTimeKind.Local).AddTicks(6179), true, 3, false, 100.0, "Spinnenkamer", 28, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 2, null, new DateTime(2021, 5, 13, 17, 10, 6, 770, DateTimeKind.Local).AddTicks(6171), true, 4, false, 124.0, "Mierenkamer", 29, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 1, null, new DateTime(2021, 5, 13, 17, 10, 6, 770, DateTimeKind.Local).AddTicks(3159), true, 2, false, 105.0, "Hommelkamer", 36, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 3, null, new DateTime(2021, 5, 13, 17, 10, 6, 770, DateTimeKind.Local).AddTicks(6176), true, 2, false, 119.0, "Muggenkamer", 36, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, null, new DateTime(2021, 5, 13, 17, 10, 6, 770, DateTimeKind.Local).AddTicks(6151), true, 2, false, 100.0, "Rozenkamer", 28, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, null, new DateTime(2021, 5, 13, 17, 10, 6, 770, DateTimeKind.Local).AddTicks(6164), false, 3, false, 115.0, "Wespenkamer", 46, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 2, null, new DateTime(2021, 5, 13, 17, 10, 6, 770, DateTimeKind.Local).AddTicks(6174), false, 2, false, 116.0, "Duizendpootkamer", 26, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 2, null, new DateTime(2021, 5, 13, 17, 10, 6, 770, DateTimeKind.Local).AddTicks(6168), true, 1, false, 97.0, "Bijenkamer", 35, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 5, null, new DateTime(2021, 5, 13, 17, 10, 6, 770, DateTimeKind.Local).AddTicks(6237), false, 5, false, 139.0, "Narcissenkamer", 44, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AmenityRoom",
                columns: new[] { "AmenitiesAmenityId", "RoomsRoomId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 3, 11 },
                    { 1, 11 },
                    { 3, 10 },
                    { 1, 10 },
                    { 1, 9 },
                    { 1, 8 },
                    { 4, 11 },
                    { 1, 12 },
                    { 1, 7 },
                    { 4, 5 },
                    { 1, 3 },
                    { 1, 2 },
                    { 3, 7 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "BnBId", "CreatedBy", "CreatedOn", "ImageDescription", "ImageName", "ImageSourceUrl", "RoomId", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 4, null, null, new DateTime(2021, 5, 13, 17, 10, 6, 771, DateTimeKind.Local).AddTicks(7138), "schoon fotooke van een weideke", "prentje", "~/css/images/prentje.png", 9, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, null, new DateTime(2021, 5, 13, 17, 10, 6, 771, DateTimeKind.Local).AddTicks(7119), "schoon fotooke van ne gazon", "imageke", "~/css/images/imageke.png", 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, null, null, new DateTime(2021, 5, 13, 17, 10, 6, 771, DateTimeKind.Local).AddTicks(3561), "schoon fotooke van een grasplein", "fotooke", "~/css/images/fotooke.png", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, null, null, new DateTime(2021, 5, 13, 17, 10, 6, 771, DateTimeKind.Local).AddTicks(7145), "schoon fotooke van een shrubbery", "kaartje", "~/css/images/kaartje.png", 7, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BnBs_ContactId",
                table: "BnBs",
                column: "ContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_BnBs_Contacts_ContactId",
                table: "BnBs",
                column: "ContactId",
                principalTable: "Contacts",
                principalColumn: "ContactId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BnBs_Contacts_ContactId",
                table: "BnBs");

            migrationBuilder.DropIndex(
                name: "IX_BnBs_ContactId",
                table: "BnBs");

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
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
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

            migrationBuilder.DropColumn(
                name: "AmenityRate",
                table: "Amenities");

            migrationBuilder.RenameColumn(
                name: "HouseNumber",
                table: "BnBs",
                newName: "StreetNumber");

            migrationBuilder.AlterColumn<int>(
                name: "UserName",
                table: "Contacts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BnBId",
                table: "Contacts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_BnBId",
                table: "Contacts",
                column: "BnBId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_BnBs_BnBId",
                table: "Contacts",
                column: "BnBId",
                principalTable: "BnBs",
                principalColumn: "BnBId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
