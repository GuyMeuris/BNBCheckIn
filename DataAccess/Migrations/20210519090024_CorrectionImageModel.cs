using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class CorrectionImageModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "Images");

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 19, 11, 0, 24, 63, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 19, 11, 0, 24, 65, DateTimeKind.Local).AddTicks(6616));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 19, 11, 0, 24, 65, DateTimeKind.Local).AddTicks(6647));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 19, 11, 0, 24, 65, DateTimeKind.Local).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 19, 11, 0, 24, 65, DateTimeKind.Local).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 19, 11, 0, 24, 67, DateTimeKind.Local).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 19, 11, 0, 24, 68, DateTimeKind.Local).AddTicks(1828));

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 19, 11, 0, 24, 68, DateTimeKind.Local).AddTicks(1841));

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 19, 11, 0, 24, 68, DateTimeKind.Local).AddTicks(1846));

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 19, 11, 0, 24, 68, DateTimeKind.Local).AddTicks(1849));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 19, 11, 0, 24, 67, DateTimeKind.Local).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 19, 11, 0, 24, 67, DateTimeKind.Local).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 19, 11, 0, 24, 67, DateTimeKind.Local).AddTicks(2682));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 19, 11, 0, 24, 67, DateTimeKind.Local).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 19, 11, 0, 24, 67, DateTimeKind.Local).AddTicks(2688));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 19, 11, 0, 24, 67, DateTimeKind.Local).AddTicks(3475));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 19, 11, 0, 24, 68, DateTimeKind.Local).AddTicks(7866));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 19, 11, 0, 24, 69, DateTimeKind.Local).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 19, 11, 0, 24, 69, DateTimeKind.Local).AddTicks(791));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 19, 11, 0, 24, 69, DateTimeKind.Local).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 19, 11, 0, 24, 69, DateTimeKind.Local).AddTicks(797));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 19, 11, 0, 24, 69, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 19, 11, 0, 24, 69, DateTimeKind.Local).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 19, 11, 0, 24, 69, DateTimeKind.Local).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 19, 11, 0, 24, 69, DateTimeKind.Local).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 19, 11, 0, 24, 69, DateTimeKind.Local).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 19, 11, 0, 24, 69, DateTimeKind.Local).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 19, 11, 0, 24, 69, DateTimeKind.Local).AddTicks(815));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Images",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
