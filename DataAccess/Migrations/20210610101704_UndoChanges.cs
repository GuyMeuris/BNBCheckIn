using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class UndoChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 10, 12, 17, 3, 564, DateTimeKind.Local).AddTicks(267));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 10, 12, 17, 3, 566, DateTimeKind.Local).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 10, 12, 17, 3, 566, DateTimeKind.Local).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 10, 12, 17, 3, 566, DateTimeKind.Local).AddTicks(4256));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 10, 12, 17, 3, 566, DateTimeKind.Local).AddTicks(4259));

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 10, 12, 17, 3, 567, DateTimeKind.Local).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 10, 12, 17, 3, 568, DateTimeKind.Local).AddTicks(2911));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 10, 12, 17, 3, 568, DateTimeKind.Local).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 10, 12, 17, 3, 569, DateTimeKind.Local).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 10, 12, 17, 3, 569, DateTimeKind.Local).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 10, 12, 17, 3, 569, DateTimeKind.Local).AddTicks(532));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 10, 12, 17, 3, 569, DateTimeKind.Local).AddTicks(535));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 10, 12, 17, 3, 569, DateTimeKind.Local).AddTicks(538));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 10, 12, 9, 24, 681, DateTimeKind.Local).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 10, 12, 9, 24, 683, DateTimeKind.Local).AddTicks(8961));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 10, 12, 9, 24, 683, DateTimeKind.Local).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 10, 12, 9, 24, 683, DateTimeKind.Local).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 10, 12, 9, 24, 683, DateTimeKind.Local).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 10, 12, 9, 24, 685, DateTimeKind.Local).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 10, 12, 9, 24, 685, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 10, 12, 9, 24, 686, DateTimeKind.Local).AddTicks(3074));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 10, 12, 9, 24, 686, DateTimeKind.Local).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 10, 12, 9, 24, 686, DateTimeKind.Local).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 10, 12, 9, 24, 686, DateTimeKind.Local).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 10, 12, 9, 24, 686, DateTimeKind.Local).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 10, 12, 9, 24, 686, DateTimeKind.Local).AddTicks(6258));
        }
    }
}
