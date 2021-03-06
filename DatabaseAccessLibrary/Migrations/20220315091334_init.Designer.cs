// <auto-generated />
using System;
using DatabaseAccessLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DatabaseAccessLibrary.Migrations
{
    [DbContext(typeof(FabolousDbContext))]
    [Migration("20220315091334_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BussinessLogicLibrary.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Parkingspot")
                        .HasColumnType("int");

                    b.Property<string>("Registration")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Parkingspot = 1,
                            Registration = "GBD5472",
                            Size = 4,
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Parkingspot = 2,
                            Registration = "7ZEE285",
                            Size = 4,
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Parkingspot = 3,
                            Registration = "T5540N",
                            Size = 4,
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Parkingspot = 4,
                            Registration = "LKY3494",
                            Size = 4,
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Parkingspot = 5,
                            Registration = "FXZ6807",
                            Size = 4,
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            Parkingspot = 6,
                            Registration = "8236TE",
                            Size = 4,
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            Parkingspot = 7,
                            Registration = "630XDK",
                            Size = 4,
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            Parkingspot = 8,
                            Registration = "LOVE",
                            Size = 4,
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9,
                            Parkingspot = 9,
                            Registration = "8739698",
                            Size = 4,
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10,
                            Parkingspot = 10,
                            Registration = "KK9915",
                            Size = 4,
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 11,
                            Parkingspot = 11,
                            Registration = "BENCH",
                            Size = 4,
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 12,
                            Parkingspot = 12,
                            Registration = "HYB4966",
                            Size = 4,
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 13,
                            Parkingspot = 13,
                            Registration = "7K44135",
                            Size = 4,
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 14,
                            Parkingspot = 14,
                            Registration = "HTM4861",
                            Size = 4,
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 15,
                            Parkingspot = 15,
                            Registration = "5WAS727",
                            Size = 4,
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 16,
                            Parkingspot = 16,
                            Registration = "1076952",
                            Size = 4,
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 17,
                            Parkingspot = 17,
                            Registration = "QFX241",
                            Size = 4,
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 18,
                            Parkingspot = 18,
                            Registration = "7Z50T2",
                            Size = 4,
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 19,
                            Parkingspot = 19,
                            Registration = "6LME062",
                            Size = 4,
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 20,
                            Parkingspot = 20,
                            Registration = "7UFH698",
                            Size = 4,
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 21,
                            Parkingspot = 21,
                            Registration = "EUG190",
                            Size = 4,
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 22,
                            Parkingspot = 22,
                            Registration = "X35FNH",
                            Size = 4,
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 23,
                            Parkingspot = 23,
                            Registration = "KQVR90",
                            Size = 4,
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 24,
                            Parkingspot = 24,
                            Registration = "8EYV287",
                            Size = 4,
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 25,
                            Parkingspot = 25,
                            Registration = "6855OP",
                            Size = 4,
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 26,
                            Parkingspot = 26,
                            Registration = "7AAA642",
                            Size = 4,
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 27,
                            Parkingspot = 27,
                            Registration = "7YBK462",
                            Size = 4,
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 28,
                            Parkingspot = 28,
                            Registration = "8DGP853",
                            Size = 4,
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 29,
                            Parkingspot = 29,
                            Registration = "SC20365",
                            Size = 4,
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 30,
                            Parkingspot = 30,
                            Registration = "BCF9407",
                            Size = 4,
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 31,
                            Parkingspot = 31,
                            Registration = "CKH7844",
                            Size = 4,
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 32,
                            Parkingspot = 32,
                            Registration = "BB9487",
                            Size = 4,
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 33,
                            Parkingspot = 33,
                            Registration = "487TBS",
                            Size = 4,
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 34,
                            Parkingspot = 34,
                            Registration = "SC20337",
                            Size = 4,
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 35,
                            Parkingspot = 35,
                            Registration = "L4802T",
                            Size = 4,
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 36,
                            Parkingspot = 36,
                            Registration = "BWN8988",
                            Size = 4,
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 37,
                            Parkingspot = 37,
                            Registration = "DRG4N6",
                            Size = 4,
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 38,
                            Parkingspot = 38,
                            Registration = "0AGVG0",
                            Size = 4,
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 39,
                            Parkingspot = 39,
                            Registration = "DKVQ31",
                            Size = 4,
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("BussinessLogicLibrary.Motorcycle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Parkingspot")
                        .HasColumnType("int");

                    b.Property<string>("Registration")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("motorcycles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Parkingspot = 51,
                            Registration = "19AX641",
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Parkingspot = 52,
                            Registration = "55AR583",
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Parkingspot = 53,
                            Registration = "23AH141",
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Parkingspot = 54,
                            Registration = "7AR1649",
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Parkingspot = 55,
                            Registration = "52AD117",
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            Parkingspot = 56,
                            Registration = "35AA969",
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            Parkingspot = 57,
                            Registration = "35AZ101",
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            Parkingspot = 58,
                            Registration = "26AA587",
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9,
                            Parkingspot = 59,
                            Registration = "51AT445",
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10,
                            Parkingspot = 60,
                            Registration = "26AI615",
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 11,
                            Parkingspot = 61,
                            Registration = "57AT653",
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 12,
                            Parkingspot = 62,
                            Registration = "62AB104",
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 13,
                            Parkingspot = 63,
                            Registration = "21AJ791",
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 14,
                            Parkingspot = 64,
                            Registration = "52AZ687",
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 15,
                            Parkingspot = 65,
                            Registration = "23AL427",
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 16,
                            Parkingspot = 66,
                            Registration = "38AI537",
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 17,
                            Parkingspot = 67,
                            Registration = "5AF5358",
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 18,
                            Parkingspot = 68,
                            Registration = "35AA351",
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 19,
                            Parkingspot = 69,
                            Registration = "55AN371",
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 20,
                            Parkingspot = 70,
                            Registration = "24AO379",
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 21,
                            Parkingspot = 71,
                            Registration = "64AR362",
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 22,
                            Parkingspot = 72,
                            Registration = "34AF518",
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 23,
                            Parkingspot = 73,
                            Registration = "38AQ555",
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 24,
                            Parkingspot = 74,
                            Registration = "24AI416",
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 25,
                            Parkingspot = 75,
                            Registration = "59AO966",
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 26,
                            Parkingspot = 76,
                            Registration = "34AT620",
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 27,
                            Parkingspot = 77,
                            Registration = "40AD140",
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 28,
                            Parkingspot = 78,
                            Registration = "30AG809",
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 29,
                            Parkingspot = 79,
                            Registration = "66AP991",
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 30,
                            Parkingspot = 80,
                            Registration = "18AD512",
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 31,
                            Parkingspot = 81,
                            Registration = "33AX623",
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 32,
                            Parkingspot = 82,
                            Registration = "64AP580",
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 33,
                            Parkingspot = 83,
                            Registration = "13AY794",
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 34,
                            Parkingspot = 84,
                            Registration = "55AC734",
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 35,
                            Parkingspot = 85,
                            Registration = "30AD500",
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 36,
                            Parkingspot = 86,
                            Registration = "38AF650",
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 37,
                            Parkingspot = 87,
                            Registration = "6AM1722",
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 38,
                            Parkingspot = 88,
                            Registration = "11AP780",
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 39,
                            Parkingspot = 89,
                            Registration = "54AG156",
                            StartTime = new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
