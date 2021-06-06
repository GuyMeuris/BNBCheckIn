using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class CorrectionsRoomAndBnBAndContact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_BnBs_BnBId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_BnBId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15627186-384a-4d5b-9f78-3c0f12616fd3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1c35ba9e-4541-494c-b352-dc48445fc93b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35a800ae-e2d8-441d-b57c-42b2940c7143");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e61604e-72f8-4c13-abc1-a882991453b1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "70b53b83-c7fc-45fb-bc00-cc27ecfa6768");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82925e3c-119b-4aa5-9925-ac306ad8d5a1");

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
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "IsVacant",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "ContactId",
                table: "BnBs");

            migrationBuilder.DropColumn(
                name: "BnBId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "BnBEmail",
                table: "BnBs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BnBPhone",
                table: "BnBs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameOwner",
                table: "BnBs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 6, 13, 15, 29, 383, DateTimeKind.Local).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 6, 13, 15, 29, 385, DateTimeKind.Local).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 6, 13, 15, 29, 385, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 6, 13, 15, 29, 385, DateTimeKind.Local).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 6, 13, 15, 29, 385, DateTimeKind.Local).AddTicks(8835));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContactName", "CreatedOn", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedOn", "UserName" },
                values: new object[,]
                {
                    { "9e7e9cd1-6ca4-4548-9bba-b31f8e2d5e78", 0, "50679962-05a1-43b7-a225-4f6ebc552950", "Arthur Blanckaert", new DateTime(2021, 6, 6, 13, 15, 29, 387, DateTimeKind.Local).AddTicks(4212), "tuur@zanger.be", false, false, null, null, null, null, "016/026.754", false, "2145751b-d0d1-4a95-95c3-8e274500abe4", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { "e64d13b7-0202-4820-899a-db46a9a1213a", 0, "fcdc875e-101a-44d7-82c6-610a0230e10f", "Bart Kaëll", new DateTime(2021, 6, 6, 13, 15, 29, 387, DateTimeKind.Local).AddTicks(8113), "kajell@zanger.be", false, false, null, null, null, null, null, false, "b4168dc6-b41c-463c-b639-3edd5e15bb94", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { "059d9ac4-8f00-4652-a991-066bd470b2f2", 0, "c93524d7-5590-418f-b280-06d98ef0ff34", "Koen Crucke", new DateTime(2021, 6, 6, 13, 15, 29, 387, DateTimeKind.Local).AddTicks(8105), "crucke@zanger.be", false, false, null, null, null, null, "03/026.754", false, "6f3b8fff-d596-4aa1-9db7-e44bcc8bf1a0", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { "de31b137-ba8c-409b-b4ef-2df5922a9de0", 0, "fb1345e8-63ee-4a0a-b4ca-7dfd71370da7", "Rocking Moustache", new DateTime(2021, 6, 6, 13, 15, 29, 387, DateTimeKind.Local).AddTicks(8085), "moustache@zanger.be", false, false, null, null, null, null, "016/981.247", false, "83a090af-4952-4e56-82b6-6eb6e68f7bdb", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { "a617f3e8-12d7-4c38-94a2-e65d7fdc5200", 0, "a29a4a3c-ea50-44fd-b294-6fcba5ea8726", "Eddy Wally", new DateTime(2021, 6, 6, 13, 15, 29, 387, DateTimeKind.Local).AddTicks(8056), "wally@zanger.be", false, false, null, null, null, null, "09/657.237", false, "c4537204-f760-4ebf-8d84-5214614f3f82", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { "5af343e7-29e2-484b-979c-9463f610b16a", 0, "79605074-f49b-4a68-8ba2-0686d91b850e", "Luk Steeno", new DateTime(2021, 6, 6, 13, 15, 29, 387, DateTimeKind.Local).AddTicks(8121), "steeno@zanger.be", false, false, null, null, null, null, null, false, "37013e02-c670-4ed1-8ab0-bf4c540f994b", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 1,
                columns: new[] { "BnBDetails", "BnBEmail", "BnBPhone", "CreatedOn", "NameOwner" },
                values: new object[] { "details hier", "jos@mail", "0123", new DateTime(2021, 6, 6, 13, 15, 29, 388, DateTimeKind.Local).AddTicks(1774), "Jos" });

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 2,
                columns: new[] { "BnBDetails", "BnBEmail", "BnBPhone", "CreatedOn", "NameOwner" },
                values: new object[] { "details hier", "jos@mail", "0123", new DateTime(2021, 6, 6, 13, 15, 29, 388, DateTimeKind.Local).AddTicks(7391), "Jos" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "RoomDetails" },
                values: new object[] { new DateTime(2021, 6, 6, 13, 15, 29, 389, DateTimeKind.Local).AddTicks(1819), "details hier" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "RoomDetails" },
                values: new object[] { new DateTime(2021, 6, 6, 13, 15, 29, 389, DateTimeKind.Local).AddTicks(4873), "details hier" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "RoomDetails" },
                values: new object[] { new DateTime(2021, 6, 6, 13, 15, 29, 389, DateTimeKind.Local).AddTicks(4887), "details hier" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "RoomDetails" },
                values: new object[] { new DateTime(2021, 6, 6, 13, 15, 29, 389, DateTimeKind.Local).AddTicks(4890), "details hier" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "RoomDetails" },
                values: new object[] { new DateTime(2021, 6, 6, 13, 15, 29, 389, DateTimeKind.Local).AddTicks(4893), "details hier" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "RoomDetails" },
                values: new object[] { new DateTime(2021, 6, 6, 13, 15, 29, 389, DateTimeKind.Local).AddTicks(4896), "details hier" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "059d9ac4-8f00-4652-a991-066bd470b2f2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5af343e7-29e2-484b-979c-9463f610b16a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e7e9cd1-6ca4-4548-9bba-b31f8e2d5e78");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a617f3e8-12d7-4c38-94a2-e65d7fdc5200");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de31b137-ba8c-409b-b4ef-2df5922a9de0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e64d13b7-0202-4820-899a-db46a9a1213a");

            migrationBuilder.DropColumn(
                name: "BnBEmail",
                table: "BnBs");

            migrationBuilder.DropColumn(
                name: "BnBPhone",
                table: "BnBs");

            migrationBuilder.DropColumn(
                name: "NameOwner",
                table: "BnBs");

            migrationBuilder.AddColumn<bool>(
                name: "IsVacant",
                table: "Rooms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ContactId",
                table: "BnBs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BnBId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 3, 13, 27, 24, 320, DateTimeKind.Local).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 3, 13, 27, 24, 323, DateTimeKind.Local).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 3, 13, 27, 24, 323, DateTimeKind.Local).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 3, 13, 27, 24, 323, DateTimeKind.Local).AddTicks(5571));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 3, 13, 27, 24, 323, DateTimeKind.Local).AddTicks(5574));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BnBId", "ConcurrencyStamp", "ContactName", "CreatedOn", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedOn", "UserName" },
                values: new object[,]
                {
                    { "35a800ae-e2d8-441d-b57c-42b2940c7143", 0, null, "2f260a3c-9981-4fcd-9ec6-3c3246e2c48d", "Arthur Blanckaert", new DateTime(2021, 6, 3, 13, 27, 24, 324, DateTimeKind.Local).AddTicks(9338), "tuur@zanger.be", false, false, null, null, null, null, "016/026.754", false, "1e806deb-c9d7-49fa-b17c-0b0726b95cf4", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { "15627186-384a-4d5b-9f78-3c0f12616fd3", 0, null, "6d1f34c7-ecb7-43f7-aa34-58a0578f8e62", "Eddy Wally", new DateTime(2021, 6, 3, 13, 27, 24, 325, DateTimeKind.Local).AddTicks(6697), "wally@zanger.be", false, false, null, null, null, null, "09/657.237", false, "6d23316c-024f-4dee-a631-2a9cd3a8f287", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { "5e61604e-72f8-4c13-abc1-a882991453b1", 0, null, "5ce2ce81-e181-4125-abde-a288cddb7e25", "Rocking Moustache", new DateTime(2021, 6, 3, 13, 27, 24, 325, DateTimeKind.Local).AddTicks(6729), "moustache@zanger.be", false, false, null, null, null, null, "016/981.247", false, "ed248c33-4838-49d8-af58-f73c9da14ed6", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { "70b53b83-c7fc-45fb-bc00-cc27ecfa6768", 0, null, "93896b1d-e5f7-4eba-8ee8-5dbd3155d86b", "Koen Crucke", new DateTime(2021, 6, 3, 13, 27, 24, 325, DateTimeKind.Local).AddTicks(7796), "crucke@zanger.be", false, false, null, null, null, null, "03/026.754", false, "8a515f37-44b1-4600-8eae-79d654abdd0a", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { "82925e3c-119b-4aa5-9925-ac306ad8d5a1", 0, null, "0e3c2dbe-af66-4e73-bcd0-fe973887eeed", "Bart Kaëll", new DateTime(2021, 6, 3, 13, 27, 24, 325, DateTimeKind.Local).AddTicks(7808), "kajell@zanger.be", false, false, null, null, null, null, null, false, "c9a03915-2b38-4de8-8958-0ed6c7930e85", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { "1c35ba9e-4541-494c-b352-dc48445fc93b", 0, null, "ca447931-33e9-429f-ba61-5ce8bd743d66", "Luk Steeno", new DateTime(2021, 6, 3, 13, 27, 24, 325, DateTimeKind.Local).AddTicks(7820), "steeno@zanger.be", false, false, null, null, null, null, null, false, "2f347349-044e-4e20-b3e8-a8232dddd2b3", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 1,
                columns: new[] { "BnBDetails", "ContactId", "CreatedOn" },
                values: new object[] { null, 1, new DateTime(2021, 6, 3, 13, 27, 24, 326, DateTimeKind.Local).AddTicks(5094) });

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 2,
                columns: new[] { "BnBDetails", "ContactId", "CreatedOn" },
                values: new object[] { null, 2, new DateTime(2021, 6, 3, 13, 27, 24, 326, DateTimeKind.Local).AddTicks(9340) });

            migrationBuilder.InsertData(
                table: "BnBs",
                columns: new[] { "BnBId", "BankAccountNr", "BnBDetails", "BnBName", "ContactId", "CreatedBy", "CreatedOn", "HouseNumber", "Municipality", "PostalCode", "Province", "StreetName", "UpdatedBy", "UpdatedOn", "VATnr" },
                values: new object[,]
                {
                    { 3, "BE59987nogmeerdiefstal", null, "Scheldezicht", 2, null, new DateTime(2021, 6, 3, 13, 27, 24, 326, DateTimeKind.Local).AddTicks(9354), "88", "Linkeroever", 2100, "Antwerpen", "Bollekeslei", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BE3524987diefstal" },
                    { 5, "BE59789nogmeerdiefstal", null, "Nie Neute", 4, null, new DateTime(2021, 6, 3, 13, 27, 24, 326, DateTimeKind.Local).AddTicks(9361), "24", "Merelbeke", 9300, "Oost-Vlaanderen", "Ledebergstraat", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BE3524789diefstal" },
                    { 4, "BE59123nogmeerdiefstal", null, "De Wieg", 3, null, new DateTime(2021, 6, 3, 13, 27, 24, 326, DateTimeKind.Local).AddTicks(9358), "44", "Kester", 1730, "Vlaams-Brabant", "Beschavingsstraat", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BE3524123diefstal" }
                });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsVacant", "RoomDetails" },
                values: new object[] { new DateTime(2021, 6, 3, 13, 27, 24, 327, DateTimeKind.Local).AddTicks(5280), true, null });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IsVacant", "RoomDetails" },
                values: new object[] { new DateTime(2021, 6, 3, 13, 27, 24, 327, DateTimeKind.Local).AddTicks(8258), true, null });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "RoomDetails" },
                values: new object[] { new DateTime(2021, 6, 3, 13, 27, 24, 327, DateTimeKind.Local).AddTicks(8272), null });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "IsVacant", "RoomDetails" },
                values: new object[] { new DateTime(2021, 6, 3, 13, 27, 24, 327, DateTimeKind.Local).AddTicks(8275), true, null });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "IsVacant", "RoomDetails" },
                values: new object[] { new DateTime(2021, 6, 3, 13, 27, 24, 327, DateTimeKind.Local).AddTicks(8278), true, null });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "RoomDetails" },
                values: new object[] { new DateTime(2021, 6, 3, 13, 27, 24, 327, DateTimeKind.Local).AddTicks(8396), null });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomId", "BnBId", "CreatedBy", "CreatedDate", "IsVacant", "Occupancy", "PetsAllowed", "Rate", "RoomDetails", "RoomName", "RoomSize", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 7, 3, null, new DateTime(2021, 6, 3, 13, 27, 24, 327, DateTimeKind.Local).AddTicks(8401), true, 2, false, 119.0, null, "Muggenkamer", 36, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 4, null, new DateTime(2021, 6, 3, 13, 27, 24, 327, DateTimeKind.Local).AddTicks(8404), true, 3, false, 100.0, null, "Spinnenkamer", 28, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 4, null, new DateTime(2021, 6, 3, 13, 27, 24, 327, DateTimeKind.Local).AddTicks(8407), true, 2, false, 99.0, null, "Tulpenkamer", 36, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 4, null, new DateTime(2021, 6, 3, 13, 27, 24, 327, DateTimeKind.Local).AddTicks(8409), true, 1, false, 107.0, null, "Chrysantenkamer", 38, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 4, null, new DateTime(2021, 6, 3, 13, 27, 24, 327, DateTimeKind.Local).AddTicks(8412), true, 2, false, 108.0, null, "Freziakamer", 36, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 5, null, new DateTime(2021, 6, 3, 13, 27, 24, 327, DateTimeKind.Local).AddTicks(8414), false, 5, false, 139.0, null, "Narcissenkamer", 44, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_BnBId",
                table: "AspNetUsers",
                column: "BnBId",
                unique: true,
                filter: "[BnBId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_BnBs_BnBId",
                table: "AspNetUsers",
                column: "BnBId",
                principalTable: "BnBs",
                principalColumn: "BnBId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
