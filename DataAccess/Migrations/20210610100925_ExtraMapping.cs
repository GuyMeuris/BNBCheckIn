using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class ExtraMapping : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                column: "CreatedOn",
                value: new DateTime(2021, 6, 6, 13, 15, 29, 388, DateTimeKind.Local).AddTicks(1774));

            migrationBuilder.UpdateData(
                table: "BnBs",
                keyColumn: "BnBId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 6, 13, 15, 29, 388, DateTimeKind.Local).AddTicks(7391));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 6, 13, 15, 29, 389, DateTimeKind.Local).AddTicks(1819));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 6, 13, 15, 29, 389, DateTimeKind.Local).AddTicks(4873));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 6, 13, 15, 29, 389, DateTimeKind.Local).AddTicks(4887));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 6, 13, 15, 29, 389, DateTimeKind.Local).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 6, 13, 15, 29, 389, DateTimeKind.Local).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 6, 13, 15, 29, 389, DateTimeKind.Local).AddTicks(4896));
        }
    }
}
