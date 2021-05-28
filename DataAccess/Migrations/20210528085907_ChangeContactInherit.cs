using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class ChangeContactInherit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BnBs_Contacts_ContactId",
                table: "BnBs");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_BnBs_ContactId",
                table: "BnBs");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "AspNetUsers",
                newName: "ContactName");

            migrationBuilder.AddColumn<int>(
                name: "BnBId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "BnBId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "ContactName",
                table: "AspNetUsers",
                newName: "Name");

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });

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

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "ContactName", "CreatedBy", "CreatedOn", "Email", "Password", "PhoneNumber", "UpdatedBy", "UpdatedOn", "UserName" },
                values: new object[,]
                {
                    { 1, "Arthur Blanckaert", null, new DateTime(2021, 5, 27, 18, 36, 20, 17, DateTimeKind.Local).AddTicks(9591), "tuur@zanger.be", null, "016/026.754", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, "Bart Kaëll", null, new DateTime(2021, 5, 27, 18, 36, 20, 18, DateTimeKind.Local).AddTicks(1211), "kajell@zanger.be", "123", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "snellenbeire" },
                    { 4, "Koen Crucke", null, new DateTime(2021, 5, 27, 18, 36, 20, 18, DateTimeKind.Local).AddTicks(1208), "crucke@zanger.be", null, "03/026.754", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, "Luk Steeno", null, new DateTime(2021, 5, 27, 18, 36, 20, 18, DateTimeKind.Local).AddTicks(1896), "steeno@zanger.be", "123", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kasseisteeno" },
                    { 3, "Rocking Moustache", null, new DateTime(2021, 5, 27, 18, 36, 20, 18, DateTimeKind.Local).AddTicks(1205), "moustache@zanger.be", null, "016/981.247", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, "Eddy Wally", null, new DateTime(2021, 5, 27, 18, 36, 20, 18, DateTimeKind.Local).AddTicks(1188), "wally@zanger.be", null, "09/657.237", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

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
    }
}
