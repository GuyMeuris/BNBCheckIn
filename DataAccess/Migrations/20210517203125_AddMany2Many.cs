using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddMany2Many : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AmenityBnB",
                columns: table => new
                {
                    AmenitiesAmenityId = table.Column<int>(type: "int", nullable: false),
                    BnBsBnBId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmenityBnB", x => new { x.AmenitiesAmenityId, x.BnBsBnBId });
                    table.ForeignKey(
                        name: "FK_AmenityBnB_Amenities_AmenitiesAmenityId",
                        column: x => x.AmenitiesAmenityId,
                        principalTable: "Amenities",
                        principalColumn: "AmenityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AmenityBnB_BnBs_BnBsBnBId",
                        column: x => x.BnBsBnBId,
                        principalTable: "BnBs",
                        principalColumn: "BnBId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AmenityRoom",
                columns: table => new
                {
                    AmenitiesAmenityId = table.Column<int>(type: "int", nullable: false),
                    RoomsRoomId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmenityRoom", x => new { x.AmenitiesAmenityId, x.RoomsRoomId });
                    table.ForeignKey(
                        name: "FK_AmenityRoom_Amenities_AmenitiesAmenityId",
                        column: x => x.AmenitiesAmenityId,
                        principalTable: "Amenities",
                        principalColumn: "AmenityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AmenityRoom_Rooms_RoomsRoomId",
                        column: x => x.RoomsRoomId,
                        principalTable: "Rooms",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "AmenityBnB",
                columns: new[] { "AmenitiesAmenityId", "BnBsBnBId" },
                values: new object[,]
                {
                    { 5, 4 },
                    { 5, 2 },
                    { 4, 5 },
                    { 1, 1 },
                    { 4, 1 },
                    { 1, 4 },
                    { 2, 3 },
                    { 4, 3 },
                    { 1, 3 },
                    { 1, 5 },
                    { 3, 1 },
                    { 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "AmenityRoom",
                columns: new[] { "AmenitiesAmenityId", "RoomsRoomId" },
                values: new object[,]
                {
                    { 1, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 1, 10 },
                    { 1, 2 },
                    { 1, 12 },
                    { 3, 7 },
                    { 3, 10 },
                    { 3, 11 },
                    { 4, 11 },
                    { 4, 5 },
                    { 1, 1 },
                    { 1, 3 },
                    { 1, 11 }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AmenityBnB_BnBsBnBId",
                table: "AmenityBnB",
                column: "BnBsBnBId");

            migrationBuilder.CreateIndex(
                name: "IX_AmenityRoom_RoomsRoomId",
                table: "AmenityRoom",
                column: "RoomsRoomId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AmenityBnB");

            migrationBuilder.DropTable(
                name: "AmenityRoom");

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 17, 20, 22, 13, 479, DateTimeKind.Local).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 17, 20, 22, 13, 481, DateTimeKind.Local).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 17, 20, 22, 13, 481, DateTimeKind.Local).AddTicks(9155));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 17, 20, 22, 13, 481, DateTimeKind.Local).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 17, 20, 22, 13, 481, DateTimeKind.Local).AddTicks(9163));

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 17, 20, 22, 13, 484, DateTimeKind.Local).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 17, 20, 22, 13, 484, DateTimeKind.Local).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 17, 20, 22, 13, 484, DateTimeKind.Local).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 17, 20, 22, 13, 484, DateTimeKind.Local).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 17, 20, 22, 13, 484, DateTimeKind.Local).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 17, 20, 22, 13, 483, DateTimeKind.Local).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 17, 20, 22, 13, 483, DateTimeKind.Local).AddTicks(5323));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 17, 20, 22, 13, 483, DateTimeKind.Local).AddTicks(5336));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 17, 20, 22, 13, 483, DateTimeKind.Local).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 17, 20, 22, 13, 483, DateTimeKind.Local).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 17, 20, 22, 13, 483, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 17, 20, 22, 13, 485, DateTimeKind.Local).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 17, 20, 22, 13, 485, DateTimeKind.Local).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 17, 20, 22, 13, 485, DateTimeKind.Local).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 17, 20, 22, 13, 485, DateTimeKind.Local).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 17, 20, 22, 13, 485, DateTimeKind.Local).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 17, 20, 22, 13, 485, DateTimeKind.Local).AddTicks(3413));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 17, 20, 22, 13, 485, DateTimeKind.Local).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 17, 20, 22, 13, 485, DateTimeKind.Local).AddTicks(3419));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 17, 20, 22, 13, 485, DateTimeKind.Local).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 17, 20, 22, 13, 485, DateTimeKind.Local).AddTicks(3424));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 17, 20, 22, 13, 485, DateTimeKind.Local).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 17, 20, 22, 13, 485, DateTimeKind.Local).AddTicks(3429));
        }
    }
}
