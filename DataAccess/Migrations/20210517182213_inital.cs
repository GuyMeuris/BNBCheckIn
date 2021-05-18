using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Amenities",
                columns: table => new
                {
                    AmenityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AmenityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AmenityRate = table.Column<double>(type: "float", nullable: false),
                    AmenityIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AmenityDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amenities", x => x.AmenityId);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });

            migrationBuilder.CreateTable(
                name: "BnBs",
                columns: table => new
                {
                    BnBId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BnBName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HouseNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<int>(type: "int", nullable: false),
                    Municipality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VATnr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankAccountNr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BnBDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContactId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BnBs", x => x.BnBId);
                    table.ForeignKey(
                        name: "FK_BnBs_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "ContactId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    RoomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Occupancy = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false),
                    RoomSize = table.Column<int>(type: "int", nullable: false),
                    IsVacant = table.Column<bool>(type: "bit", nullable: false),
                    PetsAllowed = table.Column<bool>(type: "bit", nullable: false),
                    RoomDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BnBId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.RoomId);
                    table.ForeignKey(
                        name: "FK_Rooms_BnBs_BnBId",
                        column: x => x.BnBId,
                        principalTable: "BnBs",
                        principalColumn: "BnBId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ImageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageSourceUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BnBId = table.Column<int>(type: "int", nullable: true),
                    RoomId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ImageId);
                    table.ForeignKey(
                        name: "FK_Images_BnBs_BnBId",
                        column: x => x.BnBId,
                        principalTable: "BnBs",
                        principalColumn: "BnBId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Images_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Amenities",
                columns: new[] { "AmenityId", "AmenityDescription", "AmenityIcon", "AmenityName", "AmenityRate", "CreatedBy", "CreatedOn", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, "We don't charge you for using our wifi.", null, "free wifi", 0.0, null, new DateTime(2021, 5, 17, 20, 22, 13, 479, DateTimeKind.Local).AddTicks(6726), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "We don't swim in your toilet, so please don't pee in our pool.", null, "pool", 20.0, null, new DateTime(2021, 5, 17, 20, 22, 13, 481, DateTimeKind.Local).AddTicks(9123), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "For people who like to sweat", null, "sauna", 25.0, null, new DateTime(2021, 5, 17, 20, 22, 13, 481, DateTimeKind.Local).AddTicks(9155), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "The relaxing kind, not the Japanese maffia.", null, "jacuzzi", 33.0, null, new DateTime(2021, 5, 17, 20, 22, 13, 481, DateTimeKind.Local).AddTicks(9160), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "For rainy days.", null, "pingpongtafelke", 0.0, null, new DateTime(2021, 5, 17, 20, 22, 13, 481, DateTimeKind.Local).AddTicks(9163), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "ContactName", "CreatedBy", "CreatedOn", "Email", "Password", "PhoneNumber", "UpdatedBy", "UpdatedOn", "UserName" },
                values: new object[,]
                {
                    { 1, "Arthur Blanckaert", null, new DateTime(2021, 5, 17, 20, 22, 13, 483, DateTimeKind.Local).AddTicks(3545), "tuur@zanger.be", null, "016/026.754", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, "Eddy Wally", null, new DateTime(2021, 5, 17, 20, 22, 13, 483, DateTimeKind.Local).AddTicks(5323), "wally@zanger.be", null, "09/657.237", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, "Rocking Moustache", null, new DateTime(2021, 5, 17, 20, 22, 13, 483, DateTimeKind.Local).AddTicks(5336), "moustache@zanger.be", null, "016/981.247", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, "Koen Crucke", null, new DateTime(2021, 5, 17, 20, 22, 13, 483, DateTimeKind.Local).AddTicks(5340), "crucke@zanger.be", null, "03/026.754", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, "Bart Kaëll", null, new DateTime(2021, 5, 17, 20, 22, 13, 483, DateTimeKind.Local).AddTicks(5342), "kajell@zanger.be", "123", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "snellenbeire" },
                    { 6, "Luk Steeno", null, new DateTime(2021, 5, 17, 20, 22, 13, 483, DateTimeKind.Local).AddTicks(6142), "steeno@zanger.be", "123", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kasseisteeno" }
                });

            migrationBuilder.InsertData(
                table: "BnBs",
                columns: new[] { "BnBId", "BankAccountNr", "BnBDetails", "BnBName", "ContactId", "CreatedBy", "CreatedOn", "HouseNumber", "Municipality", "PostalCode", "Province", "StreetName", "UpdatedBy", "UpdatedOn", "VATnr" },
                values: new object[,]
                {
                    { 1, "BE59889nogmeerdiefstal", null, "Boerenhol", 1, null, new DateTime(2021, 5, 17, 20, 22, 13, 484, DateTimeKind.Local).AddTicks(513), "4", "Reningelst", 8970, "West-Vlaanderen", "Driegoenstraat", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BE3524874diefstal" },
                    { 2, "BE59654nogmeerdiefstal", null, "Boskant", 2, null, new DateTime(2021, 5, 17, 20, 22, 13, 484, DateTimeKind.Local).AddTicks(4583), "8", "Helchteren", 3530, "Limburg", "Terrillstraat", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BE3526654diefstal" },
                    { 3, "BE59987nogmeerdiefstal", null, "Scheldezicht", 2, null, new DateTime(2021, 5, 17, 20, 22, 13, 484, DateTimeKind.Local).AddTicks(4597), "88", "Linkeroever", 2100, "Antwerpen", "Bollekeslei", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BE3524987diefstal" },
                    { 4, "BE59123nogmeerdiefstal", null, "De Wieg", 3, null, new DateTime(2021, 5, 17, 20, 22, 13, 484, DateTimeKind.Local).AddTicks(4601), "44", "Kester", 1730, "Vlaams-Brabant", "Beschavingsstraat", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BE3524123diefstal" },
                    { 5, "BE59789nogmeerdiefstal", null, "Nie Neute", 4, null, new DateTime(2021, 5, 17, 20, 22, 13, 484, DateTimeKind.Local).AddTicks(4604), "24", "Merelbeke", 9300, "Oost-Vlaanderen", "Ledebergstraat", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BE3524789diefstal" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomId", "BnBId", "CreatedBy", "CreatedDate", "IsVacant", "Occupancy", "PetsAllowed", "Rate", "RoomDetails", "RoomName", "RoomSize", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2021, 5, 17, 20, 22, 13, 485, DateTimeKind.Local).AddTicks(477), true, 2, false, 105.0, null, "Hommelkamer", 36, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, null, new DateTime(2021, 5, 17, 20, 22, 13, 485, DateTimeKind.Local).AddTicks(3390), true, 2, false, 100.0, null, "Rozenkamer", 28, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, null, new DateTime(2021, 5, 17, 20, 22, 13, 485, DateTimeKind.Local).AddTicks(3404), false, 3, false, 115.0, null, "Wespenkamer", 46, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 2, null, new DateTime(2021, 5, 17, 20, 22, 13, 485, DateTimeKind.Local).AddTicks(3407), true, 1, false, 97.0, null, "Bijenkamer", 35, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 2, null, new DateTime(2021, 5, 17, 20, 22, 13, 485, DateTimeKind.Local).AddTicks(3410), true, 4, false, 124.0, null, "Mierenkamer", 29, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 2, null, new DateTime(2021, 5, 17, 20, 22, 13, 485, DateTimeKind.Local).AddTicks(3413), false, 2, false, 116.0, null, "Duizendpootkamer", 26, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 3, null, new DateTime(2021, 5, 17, 20, 22, 13, 485, DateTimeKind.Local).AddTicks(3416), true, 2, false, 119.0, null, "Muggenkamer", 36, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 4, null, new DateTime(2021, 5, 17, 20, 22, 13, 485, DateTimeKind.Local).AddTicks(3419), true, 3, false, 100.0, null, "Spinnenkamer", 28, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 4, null, new DateTime(2021, 5, 17, 20, 22, 13, 485, DateTimeKind.Local).AddTicks(3421), true, 2, false, 99.0, null, "Tulpenkamer", 36, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 4, null, new DateTime(2021, 5, 17, 20, 22, 13, 485, DateTimeKind.Local).AddTicks(3424), true, 1, false, 107.0, null, "Chrysantenkamer", 38, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 4, null, new DateTime(2021, 5, 17, 20, 22, 13, 485, DateTimeKind.Local).AddTicks(3426), true, 2, false, 108.0, null, "Freziakamer", 36, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 5, null, new DateTime(2021, 5, 17, 20, 22, 13, 485, DateTimeKind.Local).AddTicks(3429), false, 5, false, 139.0, null, "Narcissenkamer", 44, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BnBs_ContactId",
                table: "BnBs",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_BnBId",
                table: "Images",
                column: "BnBId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_RoomId",
                table: "Images",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_BnBId",
                table: "Rooms",
                column: "BnBId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Amenities");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "BnBs");

            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
