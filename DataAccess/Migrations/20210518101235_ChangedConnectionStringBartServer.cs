using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class ChangedConnectionStringBartServer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 18, 12, 12, 34, 897, DateTimeKind.Local).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 18, 12, 12, 34, 900, DateTimeKind.Local).AddTicks(9823));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 18, 12, 12, 34, 900, DateTimeKind.Local).AddTicks(9898));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 18, 12, 12, 34, 900, DateTimeKind.Local).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 18, 12, 12, 34, 900, DateTimeKind.Local).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 18, 12, 12, 34, 905, DateTimeKind.Local).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 18, 12, 12, 34, 907, DateTimeKind.Local).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 18, 12, 12, 34, 907, DateTimeKind.Local).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 18, 12, 12, 34, 907, DateTimeKind.Local).AddTicks(3439));

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 18, 12, 12, 34, 907, DateTimeKind.Local).AddTicks(3445));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 18, 12, 12, 34, 904, DateTimeKind.Local).AddTicks(1003));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 18, 12, 12, 34, 904, DateTimeKind.Local).AddTicks(3762));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 18, 12, 12, 34, 904, DateTimeKind.Local).AddTicks(3786));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 18, 12, 12, 34, 904, DateTimeKind.Local).AddTicks(3791));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 18, 12, 12, 34, 904, DateTimeKind.Local).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 18, 12, 12, 34, 904, DateTimeKind.Local).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 18, 12, 12, 34, 909, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 18, 12, 12, 34, 909, DateTimeKind.Local).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 18, 12, 12, 34, 909, DateTimeKind.Local).AddTicks(5515));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 18, 12, 12, 34, 909, DateTimeKind.Local).AddTicks(5521));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 18, 12, 12, 34, 909, DateTimeKind.Local).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 18, 12, 12, 34, 909, DateTimeKind.Local).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 18, 12, 12, 34, 909, DateTimeKind.Local).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 18, 12, 12, 34, 909, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 18, 12, 12, 34, 909, DateTimeKind.Local).AddTicks(5544));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 18, 12, 12, 34, 909, DateTimeKind.Local).AddTicks(5549));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 18, 12, 12, 34, 909, DateTimeKind.Local).AddTicks(5557));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 18, 12, 12, 34, 909, DateTimeKind.Local).AddTicks(5561));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 17, 22, 31, 25, 253, DateTimeKind.Local).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 17, 22, 31, 25, 255, DateTimeKind.Local).AddTicks(6565));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 17, 22, 31, 25, 255, DateTimeKind.Local).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 17, 22, 31, 25, 255, DateTimeKind.Local).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 17, 22, 31, 25, 255, DateTimeKind.Local).AddTicks(6606));

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 17, 22, 31, 25, 257, DateTimeKind.Local).AddTicks(7841));

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 17, 22, 31, 25, 258, DateTimeKind.Local).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 17, 22, 31, 25, 258, DateTimeKind.Local).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 17, 22, 31, 25, 258, DateTimeKind.Local).AddTicks(1990));

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 17, 22, 31, 25, 258, DateTimeKind.Local).AddTicks(1993));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 17, 22, 31, 25, 257, DateTimeKind.Local).AddTicks(826));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 17, 22, 31, 25, 257, DateTimeKind.Local).AddTicks(2641));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 17, 22, 31, 25, 257, DateTimeKind.Local).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 17, 22, 31, 25, 257, DateTimeKind.Local).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 17, 22, 31, 25, 257, DateTimeKind.Local).AddTicks(2661));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 17, 22, 31, 25, 257, DateTimeKind.Local).AddTicks(3465));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 17, 22, 31, 25, 258, DateTimeKind.Local).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 17, 22, 31, 25, 259, DateTimeKind.Local).AddTicks(892));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 17, 22, 31, 25, 259, DateTimeKind.Local).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 17, 22, 31, 25, 259, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 17, 22, 31, 25, 259, DateTimeKind.Local).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 17, 22, 31, 25, 259, DateTimeKind.Local).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 17, 22, 31, 25, 259, DateTimeKind.Local).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 17, 22, 31, 25, 259, DateTimeKind.Local).AddTicks(922));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 17, 22, 31, 25, 259, DateTimeKind.Local).AddTicks(925));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 17, 22, 31, 25, 259, DateTimeKind.Local).AddTicks(927));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 17, 22, 31, 25, 259, DateTimeKind.Local).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 17, 22, 31, 25, 259, DateTimeKind.Local).AddTicks(932));
        }
    }
}
