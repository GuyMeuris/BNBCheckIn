﻿// <auto-generated />
using System;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(BnBDbContext))]
    partial class BnBDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AmenityBnB", b =>
                {
                    b.Property<int>("AmenitiesAmenityId")
                        .HasColumnType("int");

                    b.Property<int>("BnBsBnBId")
                        .HasColumnType("int");

                    b.HasKey("AmenitiesAmenityId", "BnBsBnBId");

                    b.HasIndex("BnBsBnBId");

                    b.ToTable("AmenityBnB");

                    b.HasData(
                        new
                        {
                            AmenitiesAmenityId = 1,
                            BnBsBnBId = 1
                        },
                        new
                        {
                            AmenitiesAmenityId = 1,
                            BnBsBnBId = 5
                        },
                        new
                        {
                            AmenitiesAmenityId = 1,
                            BnBsBnBId = 3
                        },
                        new
                        {
                            AmenitiesAmenityId = 1,
                            BnBsBnBId = 4
                        },
                        new
                        {
                            AmenitiesAmenityId = 2,
                            BnBsBnBId = 3
                        },
                        new
                        {
                            AmenitiesAmenityId = 3,
                            BnBsBnBId = 1
                        },
                        new
                        {
                            AmenitiesAmenityId = 3,
                            BnBsBnBId = 3
                        },
                        new
                        {
                            AmenitiesAmenityId = 4,
                            BnBsBnBId = 1
                        },
                        new
                        {
                            AmenitiesAmenityId = 4,
                            BnBsBnBId = 3
                        },
                        new
                        {
                            AmenitiesAmenityId = 4,
                            BnBsBnBId = 5
                        },
                        new
                        {
                            AmenitiesAmenityId = 5,
                            BnBsBnBId = 2
                        },
                        new
                        {
                            AmenitiesAmenityId = 5,
                            BnBsBnBId = 4
                        });
                });

            modelBuilder.Entity("AmenityRoom", b =>
                {
                    b.Property<int>("AmenitiesAmenityId")
                        .HasColumnType("int");

                    b.Property<int>("RoomsRoomId")
                        .HasColumnType("int");

                    b.HasKey("AmenitiesAmenityId", "RoomsRoomId");

                    b.HasIndex("RoomsRoomId");

                    b.ToTable("AmenityRoom");

                    b.HasData(
                        new
                        {
                            AmenitiesAmenityId = 1,
                            RoomsRoomId = 1
                        },
                        new
                        {
                            AmenitiesAmenityId = 1,
                            RoomsRoomId = 2
                        },
                        new
                        {
                            AmenitiesAmenityId = 1,
                            RoomsRoomId = 3
                        },
                        new
                        {
                            AmenitiesAmenityId = 1,
                            RoomsRoomId = 7
                        },
                        new
                        {
                            AmenitiesAmenityId = 1,
                            RoomsRoomId = 8
                        },
                        new
                        {
                            AmenitiesAmenityId = 1,
                            RoomsRoomId = 9
                        },
                        new
                        {
                            AmenitiesAmenityId = 1,
                            RoomsRoomId = 10
                        },
                        new
                        {
                            AmenitiesAmenityId = 1,
                            RoomsRoomId = 11
                        },
                        new
                        {
                            AmenitiesAmenityId = 1,
                            RoomsRoomId = 12
                        },
                        new
                        {
                            AmenitiesAmenityId = 3,
                            RoomsRoomId = 7
                        },
                        new
                        {
                            AmenitiesAmenityId = 3,
                            RoomsRoomId = 10
                        },
                        new
                        {
                            AmenitiesAmenityId = 3,
                            RoomsRoomId = 11
                        },
                        new
                        {
                            AmenitiesAmenityId = 4,
                            RoomsRoomId = 11
                        },
                        new
                        {
                            AmenitiesAmenityId = 4,
                            RoomsRoomId = 5
                        });
                });

            modelBuilder.Entity("DataAccess.Data.Amenity", b =>
                {
                    b.Property<int>("AmenityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AmenityDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AmenityIcon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AmenityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("AmenityRate")
                        .HasColumnType("float");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("AmenityId");

                    b.ToTable("Amenities");

                    b.HasData(
                        new
                        {
                            AmenityId = 1,
                            AmenityDescription = "We don't charge you for using our wifi.",
                            AmenityName = "free wifi",
                            AmenityRate = 0.0,
                            CreatedOn = new DateTime(2021, 5, 16, 15, 52, 38, 98, DateTimeKind.Local).AddTicks(4914),
                            UpdatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AmenityId = 2,
                            AmenityDescription = "We don't swim in your toilet, so please don't pee in our pool.",
                            AmenityName = "pool",
                            AmenityRate = 20.0,
                            CreatedOn = new DateTime(2021, 5, 16, 15, 52, 38, 101, DateTimeKind.Local).AddTicks(5059),
                            UpdatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AmenityId = 3,
                            AmenityDescription = "For people who like to sweat",
                            AmenityName = "sauna",
                            AmenityRate = 25.0,
                            CreatedOn = new DateTime(2021, 5, 16, 15, 52, 38, 101, DateTimeKind.Local).AddTicks(5096),
                            UpdatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AmenityId = 4,
                            AmenityDescription = "The relaxing kind, not the Japanese maffia.",
                            AmenityName = "jacuzzi",
                            AmenityRate = 33.0,
                            CreatedOn = new DateTime(2021, 5, 16, 15, 52, 38, 101, DateTimeKind.Local).AddTicks(5102),
                            UpdatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AmenityId = 5,
                            AmenityDescription = "For rainy days.",
                            AmenityName = "pingpongtafelke",
                            AmenityRate = 0.0,
                            CreatedOn = new DateTime(2021, 5, 16, 15, 52, 38, 101, DateTimeKind.Local).AddTicks(5234),
                            UpdatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("DataAccess.Data.BnB", b =>
                {
                    b.Property<int>("BnBId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BankAccountNr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BnBName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContactId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("HouseNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Municipality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostalCode")
                        .HasColumnType("int");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("VATnr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BnBId");

                    b.HasIndex("ContactId");

                    b.ToTable("BnBs");

                    b.HasData(
                        new
                        {
                            BnBId = 1,
                            BankAccountNr = "BE59889nogmeerdiefstal",
                            BnBName = "Boerenhol",
                            ContactId = 1,
                            CreatedOn = new DateTime(2021, 5, 16, 15, 52, 38, 103, DateTimeKind.Local).AddTicks(9234),
                            HouseNumber = "4",
                            Municipality = "Reningelst",
                            PostalCode = 8970,
                            Province = "West-Vlaanderen",
                            StreetName = "Driegoenstraat",
                            UpdatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VATnr = "BE3524874diefstal"
                        },
                        new
                        {
                            BnBId = 2,
                            BankAccountNr = "BE59654nogmeerdiefstal",
                            BnBName = "Boskant",
                            ContactId = 2,
                            CreatedOn = new DateTime(2021, 5, 16, 15, 52, 38, 104, DateTimeKind.Local).AddTicks(3519),
                            HouseNumber = "8",
                            Municipality = "Helchteren",
                            PostalCode = 3530,
                            Province = "Limburg",
                            StreetName = "Terrillstraat",
                            UpdatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VATnr = "BE3526654diefstal"
                        },
                        new
                        {
                            BnBId = 3,
                            BankAccountNr = "BE59987nogmeerdiefstal",
                            BnBName = "Scheldezicht",
                            ContactId = 2,
                            CreatedOn = new DateTime(2021, 5, 16, 15, 52, 38, 104, DateTimeKind.Local).AddTicks(3534),
                            HouseNumber = "88",
                            Municipality = "Linkeroever",
                            PostalCode = 2100,
                            Province = "Antwerpen",
                            StreetName = "Bollekeslei",
                            UpdatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VATnr = "BE3524987diefstal"
                        },
                        new
                        {
                            BnBId = 4,
                            BankAccountNr = "BE59123nogmeerdiefstal",
                            BnBName = "De Wieg",
                            ContactId = 3,
                            CreatedOn = new DateTime(2021, 5, 16, 15, 52, 38, 104, DateTimeKind.Local).AddTicks(3539),
                            HouseNumber = "44",
                            Municipality = "Kester",
                            PostalCode = 1730,
                            Province = "Vlaams-Brabant",
                            StreetName = "Beschavingsstraat",
                            UpdatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VATnr = "BE3524123diefstal"
                        },
                        new
                        {
                            BnBId = 5,
                            BankAccountNr = "BE59789nogmeerdiefstal",
                            BnBName = "Nie Neute",
                            ContactId = 4,
                            CreatedOn = new DateTime(2021, 5, 16, 15, 52, 38, 104, DateTimeKind.Local).AddTicks(3541),
                            HouseNumber = "24",
                            Municipality = "Merelbeke",
                            PostalCode = 9300,
                            Province = "Oost-Vlaanderen",
                            StreetName = "Ledebergstraat",
                            UpdatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VATnr = "BE3524789diefstal"
                        });
                });

            modelBuilder.Entity("DataAccess.Data.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactId");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            ContactId = 1,
                            ContactName = "Arthur Blanckaert",
                            CreatedOn = new DateTime(2021, 5, 16, 15, 52, 38, 103, DateTimeKind.Local).AddTicks(2180),
                            Email = "tuur@zanger.be",
                            PhoneNumber = "016/026.754",
                            UpdatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ContactId = 2,
                            ContactName = "Eddy Wally",
                            CreatedOn = new DateTime(2021, 5, 16, 15, 52, 38, 103, DateTimeKind.Local).AddTicks(3994),
                            Email = "wally@zanger.be",
                            PhoneNumber = "09/657.237",
                            UpdatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ContactId = 3,
                            ContactName = "Rocking Moustache",
                            CreatedOn = new DateTime(2021, 5, 16, 15, 52, 38, 103, DateTimeKind.Local).AddTicks(4008),
                            Email = "moustache@zanger.be",
                            PhoneNumber = "016/981.247",
                            UpdatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ContactId = 4,
                            ContactName = "Koen Crucke",
                            CreatedOn = new DateTime(2021, 5, 16, 15, 52, 38, 103, DateTimeKind.Local).AddTicks(4012),
                            Email = "crucke@zanger.be",
                            PhoneNumber = "03/026.754",
                            UpdatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ContactId = 5,
                            ContactName = "Bart Kaëll",
                            CreatedOn = new DateTime(2021, 5, 16, 15, 52, 38, 103, DateTimeKind.Local).AddTicks(4014),
                            Email = "kajell@zanger.be",
                            Password = "123",
                            UpdatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "snellenbeire"
                        },
                        new
                        {
                            ContactId = 6,
                            ContactName = "Luk Steeno",
                            CreatedOn = new DateTime(2021, 5, 16, 15, 52, 38, 103, DateTimeKind.Local).AddTicks(4817),
                            Email = "steeno@zanger.be",
                            Password = "123",
                            UpdatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "kasseisteeno"
                        });
                });

            modelBuilder.Entity("DataAccess.Data.Image", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BnBId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageSourceUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoomId")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("ImageId");

                    b.HasIndex("BnBId");

                    b.HasIndex("RoomId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("DataAccess.Data.Room", b =>
                {
                    b.Property<int>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BnBId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsVacant")
                        .HasColumnType("bit");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<bool>("PetsAllowed")
                        .HasColumnType("bit");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<string>("RoomName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoomSize")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("RoomId");

                    b.HasIndex("BnBId");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            RoomId = 1,
                            BnBId = 1,
                            CreatedDate = new DateTime(2021, 5, 16, 15, 52, 38, 104, DateTimeKind.Local).AddTicks(9657),
                            IsVacant = true,
                            Occupancy = 2,
                            PetsAllowed = false,
                            Rate = 105.0,
                            RoomName = "Hommelkamer",
                            RoomSize = 36,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            RoomId = 2,
                            BnBId = 1,
                            CreatedDate = new DateTime(2021, 5, 16, 15, 52, 38, 105, DateTimeKind.Local).AddTicks(5307),
                            IsVacant = true,
                            Occupancy = 2,
                            PetsAllowed = false,
                            Rate = 100.0,
                            RoomName = "Rozenkamer",
                            RoomSize = 28,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            RoomId = 3,
                            BnBId = 1,
                            CreatedDate = new DateTime(2021, 5, 16, 15, 52, 38, 105, DateTimeKind.Local).AddTicks(5322),
                            IsVacant = false,
                            Occupancy = 3,
                            PetsAllowed = false,
                            Rate = 115.0,
                            RoomName = "Wespenkamer",
                            RoomSize = 46,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            RoomId = 4,
                            BnBId = 2,
                            CreatedDate = new DateTime(2021, 5, 16, 15, 52, 38, 105, DateTimeKind.Local).AddTicks(5326),
                            IsVacant = true,
                            Occupancy = 1,
                            PetsAllowed = false,
                            Rate = 97.0,
                            RoomName = "Bijenkamer",
                            RoomSize = 35,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            RoomId = 5,
                            BnBId = 2,
                            CreatedDate = new DateTime(2021, 5, 16, 15, 52, 38, 105, DateTimeKind.Local).AddTicks(5328),
                            IsVacant = true,
                            Occupancy = 4,
                            PetsAllowed = false,
                            Rate = 124.0,
                            RoomName = "Mierenkamer",
                            RoomSize = 29,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            RoomId = 6,
                            BnBId = 2,
                            CreatedDate = new DateTime(2021, 5, 16, 15, 52, 38, 105, DateTimeKind.Local).AddTicks(5331),
                            IsVacant = false,
                            Occupancy = 2,
                            PetsAllowed = false,
                            Rate = 116.0,
                            RoomName = "Duizendpootkamer",
                            RoomSize = 26,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            RoomId = 7,
                            BnBId = 3,
                            CreatedDate = new DateTime(2021, 5, 16, 15, 52, 38, 105, DateTimeKind.Local).AddTicks(5334),
                            IsVacant = true,
                            Occupancy = 2,
                            PetsAllowed = false,
                            Rate = 119.0,
                            RoomName = "Muggenkamer",
                            RoomSize = 36,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            RoomId = 8,
                            BnBId = 4,
                            CreatedDate = new DateTime(2021, 5, 16, 15, 52, 38, 105, DateTimeKind.Local).AddTicks(5336),
                            IsVacant = true,
                            Occupancy = 3,
                            PetsAllowed = false,
                            Rate = 100.0,
                            RoomName = "Spinnenkamer",
                            RoomSize = 28,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            RoomId = 9,
                            BnBId = 4,
                            CreatedDate = new DateTime(2021, 5, 16, 15, 52, 38, 105, DateTimeKind.Local).AddTicks(5339),
                            IsVacant = true,
                            Occupancy = 2,
                            PetsAllowed = false,
                            Rate = 99.0,
                            RoomName = "Tulpenkamer",
                            RoomSize = 36,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            RoomId = 10,
                            BnBId = 4,
                            CreatedDate = new DateTime(2021, 5, 16, 15, 52, 38, 105, DateTimeKind.Local).AddTicks(5341),
                            IsVacant = true,
                            Occupancy = 1,
                            PetsAllowed = false,
                            Rate = 107.0,
                            RoomName = "Chrysantenkamer",
                            RoomSize = 38,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            RoomId = 11,
                            BnBId = 4,
                            CreatedDate = new DateTime(2021, 5, 16, 15, 52, 38, 105, DateTimeKind.Local).AddTicks(5344),
                            IsVacant = true,
                            Occupancy = 2,
                            PetsAllowed = false,
                            Rate = 108.0,
                            RoomName = "Freziakamer",
                            RoomSize = 36,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            RoomId = 12,
                            BnBId = 5,
                            CreatedDate = new DateTime(2021, 5, 16, 15, 52, 38, 105, DateTimeKind.Local).AddTicks(5346),
                            IsVacant = false,
                            Occupancy = 5,
                            PetsAllowed = false,
                            Rate = 139.0,
                            RoomName = "Narcissenkamer",
                            RoomSize = 44,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("AmenityBnB", b =>
                {
                    b.HasOne("DataAccess.Data.Amenity", null)
                        .WithMany()
                        .HasForeignKey("AmenitiesAmenityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Data.BnB", null)
                        .WithMany()
                        .HasForeignKey("BnBsBnBId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AmenityRoom", b =>
                {
                    b.HasOne("DataAccess.Data.Amenity", null)
                        .WithMany()
                        .HasForeignKey("AmenitiesAmenityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Data.Room", null)
                        .WithMany()
                        .HasForeignKey("RoomsRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Data.BnB", b =>
                {
                    b.HasOne("DataAccess.Data.Contact", "Contacts")
                        .WithMany()
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contacts");
                });

            modelBuilder.Entity("DataAccess.Data.Image", b =>
                {
                    b.HasOne("DataAccess.Data.BnB", "BnB")
                        .WithMany("Images")
                        .HasForeignKey("BnBId");

                    b.HasOne("DataAccess.Data.Room", "Room")
                        .WithMany("Images")
                        .HasForeignKey("RoomId");

                    b.Navigation("BnB");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("DataAccess.Data.Room", b =>
                {
                    b.HasOne("DataAccess.Data.BnB", "BnB")
                        .WithMany("Rooms")
                        .HasForeignKey("BnBId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BnB");
                });

            modelBuilder.Entity("DataAccess.Data.BnB", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("DataAccess.Data.Room", b =>
                {
                    b.Navigation("Images");
                });
#pragma warning restore 612, 618
        }
    }
}
