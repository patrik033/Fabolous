using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseAccessLibrary.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Size = table.Column<int>(type: "int", nullable: false),
                    Registration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Parkingspot = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "motorcycles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Registration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Parkingspot = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_motorcycles", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "cars",
                columns: new[] { "Id", "Parkingspot", "Registration", "Size", "StartTime" },
                values: new object[,]
                {
                    { 1, 1, "GBD5472", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, "7ZEE285", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, "T5540N", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 4, "LKY3494", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 5, "FXZ6807", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 6, "8236TE", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 7, "630XDK", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 8, "LOVE", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 9, "8739698", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 10, "KK9915", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 11, "BENCH", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 12, "HYB4966", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 13, "7K44135", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 14, "HTM4861", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 15, "5WAS727", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 16, "1076952", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 17, "QFX241", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 18, "7Z50T2", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 19, "6LME062", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, 20, "7UFH698", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 21, "EUG190", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 22, "X35FNH", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, 23, "KQVR90", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, 24, "8EYV287", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, 25, "6855OP", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, 26, "7AAA642", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, 27, "7YBK462", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, 28, "8DGP853", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, 29, "SC20365", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, 30, "BCF9407", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, 31, "CKH7844", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, 32, "BB9487", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, 33, "487TBS", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, 34, "SC20337", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, 35, "L4802T", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, 36, "BWN8988", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, 37, "DRG4N6", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, 38, "0AGVG0", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, 39, "DKVQ31", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, 40, "22528MC", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41, 41, "1CK7456", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42, 42, "AEH9540", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "cars",
                columns: new[] { "Id", "Parkingspot", "Registration", "Size", "StartTime" },
                values: new object[,]
                {
                    { 43, 43, "6JMW833", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44, 44, "535621B", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45, 45, "4JWR404", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46, 46, "N73EXY", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47, 47, "K9CRZY", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48, 48, "4GUG721", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, 49, "8GTS234", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, 50, "446AH", 4, new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "motorcycles",
                columns: new[] { "Id", "Parkingspot", "Registration", "StartTime" },
                values: new object[,]
                {
                    { 1, 51, "19AX641", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 52, "55AR583", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 53, "23AH141", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 54, "7AR1649", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 55, "52AD117", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 56, "35AA969", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 57, "35AZ101", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 58, "26AA587", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 59, "51AT445", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 60, "26AI615", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 61, "57AT653", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 62, "62AB104", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 63, "21AJ791", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 64, "52AZ687", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 65, "23AL427", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 66, "38AI537", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 67, "5AF5358", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 68, "35AA351", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 69, "55AN371", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, 70, "24AO379", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 71, "64AR362", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 72, "34AF518", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, 73, "38AQ555", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, 74, "24AI416", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, 75, "59AO966", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, 76, "34AT620", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, 77, "40AD140", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, 78, "30AG809", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, 79, "66AP991", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, 80, "18AD512", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, 81, "33AX623", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, 82, "64AP580", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, 83, "13AY794", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, 84, "55AC734", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "motorcycles",
                columns: new[] { "Id", "Parkingspot", "Registration", "StartTime" },
                values: new object[,]
                {
                    { 35, 85, "30AD500", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, 86, "38AF650", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, 87, "6AM1722", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, 88, "11AP780", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, 89, "54AG156", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, 90, "61AY262", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41, 91, "62AK646", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42, 92, "45AO853", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43, 93, "20AF377", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44, 94, "30AQ301", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45, 95, "62AZ570", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46, 96, "61AS803", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47, 97, "25AG915", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48, 98, "12AR787", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, 99, "11AV356", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, 100, "51AX141", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cars");

            migrationBuilder.DropTable(
                name: "motorcycles");
        }
    }
}
