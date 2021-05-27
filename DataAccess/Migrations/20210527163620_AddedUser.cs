using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddedUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 27, 18, 36, 20, 12, DateTimeKind.Local).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 27, 18, 36, 20, 16, DateTimeKind.Local).AddTicks(3464));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 27, 18, 36, 20, 16, DateTimeKind.Local).AddTicks(3509));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 27, 18, 36, 20, 16, DateTimeKind.Local).AddTicks(3515));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 27, 18, 36, 20, 16, DateTimeKind.Local).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 27, 18, 36, 20, 18, DateTimeKind.Local).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 27, 18, 36, 20, 19, DateTimeKind.Local).AddTicks(656));

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 27, 18, 36, 20, 19, DateTimeKind.Local).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 27, 18, 36, 20, 19, DateTimeKind.Local).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 27, 18, 36, 20, 19, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 27, 18, 36, 20, 17, DateTimeKind.Local).AddTicks(9591));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 27, 18, 36, 20, 18, DateTimeKind.Local).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 27, 18, 36, 20, 18, DateTimeKind.Local).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 27, 18, 36, 20, 18, DateTimeKind.Local).AddTicks(1208));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 27, 18, 36, 20, 18, DateTimeKind.Local).AddTicks(1211));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 27, 18, 36, 20, 18, DateTimeKind.Local).AddTicks(1896));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 27, 18, 36, 20, 19, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 27, 18, 36, 20, 20, DateTimeKind.Local).AddTicks(388));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 27, 18, 36, 20, 20, DateTimeKind.Local).AddTicks(405));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 27, 18, 36, 20, 20, DateTimeKind.Local).AddTicks(408));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 27, 18, 36, 20, 20, DateTimeKind.Local).AddTicks(412));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 27, 18, 36, 20, 20, DateTimeKind.Local).AddTicks(415));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 27, 18, 36, 20, 20, DateTimeKind.Local).AddTicks(418));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 27, 18, 36, 20, 20, DateTimeKind.Local).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 27, 18, 36, 20, 20, DateTimeKind.Local).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 27, 18, 36, 20, 20, DateTimeKind.Local).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 27, 18, 36, 20, 20, DateTimeKind.Local).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 27, 18, 36, 20, 20, DateTimeKind.Local).AddTicks(432));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 24, 14, 11, 43, 256, DateTimeKind.Local).AddTicks(4129));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 24, 14, 11, 43, 259, DateTimeKind.Local).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 24, 14, 11, 43, 259, DateTimeKind.Local).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 24, 14, 11, 43, 259, DateTimeKind.Local).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 24, 14, 11, 43, 259, DateTimeKind.Local).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 24, 14, 11, 43, 262, DateTimeKind.Local).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 24, 14, 11, 43, 262, DateTimeKind.Local).AddTicks(9698));

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 24, 14, 11, 43, 262, DateTimeKind.Local).AddTicks(9716));

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 24, 14, 11, 43, 262, DateTimeKind.Local).AddTicks(9720));

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 24, 14, 11, 43, 262, DateTimeKind.Local).AddTicks(9725));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 24, 14, 11, 43, 261, DateTimeKind.Local).AddTicks(4788));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 24, 14, 11, 43, 261, DateTimeKind.Local).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 24, 14, 11, 43, 261, DateTimeKind.Local).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 24, 14, 11, 43, 261, DateTimeKind.Local).AddTicks(7341));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 24, 14, 11, 43, 261, DateTimeKind.Local).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 24, 14, 11, 43, 261, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 14, 11, 43, 263, DateTimeKind.Local).AddTicks(7721));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 14, 11, 43, 264, DateTimeKind.Local).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 14, 11, 43, 264, DateTimeKind.Local).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 14, 11, 43, 264, DateTimeKind.Local).AddTicks(3327));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 14, 11, 43, 264, DateTimeKind.Local).AddTicks(3331));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 14, 11, 43, 264, DateTimeKind.Local).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 14, 11, 43, 264, DateTimeKind.Local).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 14, 11, 43, 264, DateTimeKind.Local).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 14, 11, 43, 264, DateTimeKind.Local).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 14, 11, 43, 264, DateTimeKind.Local).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 14, 11, 43, 264, DateTimeKind.Local).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 14, 11, 43, 264, DateTimeKind.Local).AddTicks(3360));
        }
    }
}
