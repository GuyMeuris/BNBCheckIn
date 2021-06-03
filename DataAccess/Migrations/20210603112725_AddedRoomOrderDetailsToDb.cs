using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddedRoomOrderDetailsToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0a901eab-e90b-43f5-a8d4-fdb25a618b42");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "441f0d6e-8895-4aa9-9166-fe78b092f243");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55a9596e-76f5-4de5-8534-d5fb85ca4b01");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57e549ba-0b86-4505-a1f8-0af24ec50eec");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "671e29c3-c61c-4874-991b-a21b0baca6c8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6e1d118f-f82d-4a6b-8cdc-7422313ddec0");

            migrationBuilder.CreateTable(
                name: "RoomOrderDetails",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StripeSessionId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CheckInDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckOutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActualCheckInDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActualCheckOutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalCost = table.Column<double>(type: "float", nullable: false),
                    IsPaymentSuccessful = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomOrderDetails", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_RoomOrderDetails_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                column: "CreatedOn",
                value: new DateTime(2021, 6, 3, 13, 27, 24, 326, DateTimeKind.Local).AddTicks(5094));

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 3, 13, 27, 24, 326, DateTimeKind.Local).AddTicks(9340));

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 3, 13, 27, 24, 326, DateTimeKind.Local).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 3, 13, 27, 24, 326, DateTimeKind.Local).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 3, 13, 27, 24, 326, DateTimeKind.Local).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 3, 13, 27, 24, 327, DateTimeKind.Local).AddTicks(5280));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 3, 13, 27, 24, 327, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 3, 13, 27, 24, 327, DateTimeKind.Local).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 3, 13, 27, 24, 327, DateTimeKind.Local).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 3, 13, 27, 24, 327, DateTimeKind.Local).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 3, 13, 27, 24, 327, DateTimeKind.Local).AddTicks(8396));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 3, 13, 27, 24, 327, DateTimeKind.Local).AddTicks(8401));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 3, 13, 27, 24, 327, DateTimeKind.Local).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 3, 13, 27, 24, 327, DateTimeKind.Local).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 3, 13, 27, 24, 327, DateTimeKind.Local).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 3, 13, 27, 24, 327, DateTimeKind.Local).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 3, 13, 27, 24, 327, DateTimeKind.Local).AddTicks(8414));

            migrationBuilder.CreateIndex(
                name: "IX_RoomOrderDetails_RoomId",
                table: "RoomOrderDetails",
                column: "RoomId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoomOrderDetails");

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

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 28, 10, 59, 6, 520, DateTimeKind.Local).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 28, 10, 59, 6, 524, DateTimeKind.Local).AddTicks(7576));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 28, 10, 59, 6, 524, DateTimeKind.Local).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 28, 10, 59, 6, 524, DateTimeKind.Local).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 28, 10, 59, 6, 524, DateTimeKind.Local).AddTicks(7674));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BnBId", "ConcurrencyStamp", "ContactName", "CreatedOn", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedOn", "UserName" },
                values: new object[,]
                {
                    { "55a9596e-76f5-4de5-8534-d5fb85ca4b01", 0, null, "12ef35fd-06f7-4fe0-abcc-516cb6d80582", "Arthur Blanckaert", new DateTime(2021, 5, 28, 10, 59, 6, 529, DateTimeKind.Local).AddTicks(1001), "tuur@zanger.be", false, false, null, null, null, null, "016/026.754", false, "ef851768-1be4-470c-87c4-9f0c74be0369", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { "0a901eab-e90b-43f5-a8d4-fdb25a618b42", 0, null, "d8d33334-8f0c-441b-8247-208c6cd2b5a2", "Eddy Wally", new DateTime(2021, 5, 28, 10, 59, 6, 529, DateTimeKind.Local).AddTicks(3181), "wally@zanger.be", false, false, null, null, null, null, "09/657.237", false, "319034f2-bd95-4c84-9956-adb4f805e36c", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { "441f0d6e-8895-4aa9-9166-fe78b092f243", 0, null, "62b3b5db-4df8-4884-83a4-370cbec3bc8e", "Rocking Moustache", new DateTime(2021, 5, 28, 10, 59, 6, 529, DateTimeKind.Local).AddTicks(3282), "moustache@zanger.be", false, false, null, null, null, null, "016/981.247", false, "f4be213b-6eae-4495-956e-16585daf8f56", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { "671e29c3-c61c-4874-991b-a21b0baca6c8", 0, null, "4487bf00-e8d6-48c0-b6dd-052af5d7487f", "Koen Crucke", new DateTime(2021, 5, 28, 10, 59, 6, 529, DateTimeKind.Local).AddTicks(3320), "crucke@zanger.be", false, false, null, null, null, null, "03/026.754", false, "e20058fc-2453-4ad3-887f-b03fe1aabcd4", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { "6e1d118f-f82d-4a6b-8cdc-7422313ddec0", 0, null, "651e8b42-26c9-4e20-aa74-5bc253f6080f", "Bart Kaëll", new DateTime(2021, 5, 28, 10, 59, 6, 529, DateTimeKind.Local).AddTicks(3335), "kajell@zanger.be", false, false, null, null, null, null, null, false, "306a0703-b52f-4c6e-bd62-89260d82f79d", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { "57e549ba-0b86-4505-a1f8-0af24ec50eec", 0, null, "7aeb035a-678d-4177-b769-c45317af13a7", "Luk Steeno", new DateTime(2021, 5, 28, 10, 59, 6, 529, DateTimeKind.Local).AddTicks(3349), "steeno@zanger.be", false, false, null, null, null, null, null, false, "84fd7526-1c8e-4811-a630-2b611cadcdbd", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 28, 10, 59, 6, 529, DateTimeKind.Local).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 28, 10, 59, 6, 530, DateTimeKind.Local).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 28, 10, 59, 6, 530, DateTimeKind.Local).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 28, 10, 59, 6, 530, DateTimeKind.Local).AddTicks(4414));

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 28, 10, 59, 6, 530, DateTimeKind.Local).AddTicks(4418));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 28, 10, 59, 6, 531, DateTimeKind.Local).AddTicks(2527));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 28, 10, 59, 6, 531, DateTimeKind.Local).AddTicks(5554));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 28, 10, 59, 6, 531, DateTimeKind.Local).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 28, 10, 59, 6, 531, DateTimeKind.Local).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 28, 10, 59, 6, 531, DateTimeKind.Local).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 28, 10, 59, 6, 531, DateTimeKind.Local).AddTicks(5584));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 28, 10, 59, 6, 531, DateTimeKind.Local).AddTicks(5587));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 28, 10, 59, 6, 531, DateTimeKind.Local).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 28, 10, 59, 6, 531, DateTimeKind.Local).AddTicks(5594));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 28, 10, 59, 6, 531, DateTimeKind.Local).AddTicks(5597));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 28, 10, 59, 6, 531, DateTimeKind.Local).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 28, 10, 59, 6, 531, DateTimeKind.Local).AddTicks(5604));
        }
    }
}
