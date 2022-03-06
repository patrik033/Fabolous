using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseAccessLibrary.Migrations
{
    public partial class init : Migration
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
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    Size = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    { 1, 1, "GBD5472", 1, null },
                    { 2, 2, "7ZEE285", 2, null },
                    { 3, 3, "T5540N", 3, null },
                    { 4, 4, "LKY3494", 4, null },
                    { 5, 5, "FXZ6807", 5, null },
                    { 6, 6, "8236TE", 6, null },
                    { 7, 7, "630XDK", 7, null },
                    { 8, 8, "LOVE", 8, null },
                    { 9, 9, "8739698", 9, null },
                    { 10, 10, "KK9915", 10, null },
                    { 11, 11, "BENCH", 11, null },
                    { 12, 12, "HYB4966", 12, null },
                    { 13, 13, "7K44135", 13, null },
                    { 14, 14, "HTM4861", 14, null },
                    { 15, 15, "5WAS727", 15, null },
                    { 16, 16, "1076952", 16, null },
                    { 17, 17, "QFX241", 17, null },
                    { 18, 18, "7Z50T2", 18, null },
                    { 19, 19, "6LME062", 19, null },
                    { 20, 20, "7UFH698", 20, null },
                    { 21, 21, "EUG190", 21, null },
                    { 22, 22, "X35FNH", 22, null },
                    { 23, 23, "KQVR90", 23, null },
                    { 24, 24, "8EYV287", 24, null },
                    { 25, 25, "6855OP", 25, null },
                    { 26, 26, "7AAA642", 26, null },
                    { 27, 27, "7YBK462", 27, null },
                    { 28, 28, "8DGP853", 28, null },
                    { 29, 29, "SC20365", 29, null },
                    { 30, 30, "BCF9407", 30, null },
                    { 31, 31, "CKH7844", 31, null },
                    { 32, 32, "BB9487", 32, null },
                    { 33, 33, "487TBS", 33, null },
                    { 34, 34, "SC20337", 34, null },
                    { 35, 35, "L4802T", 35, null },
                    { 36, 36, "BWN8988", 36, null },
                    { 37, 37, "DRG4N6", 37, null },
                    { 38, 38, "0AGVG0", 38, null },
                    { 39, 39, "DKVQ31", 39, null },
                    { 40, 40, "22528MC", 40, null },
                    { 41, 41, "1CK7456", 41, null },
                    { 42, 42, "AEH9540", 42, null }
                });

            migrationBuilder.InsertData(
                table: "cars",
                columns: new[] { "Id", "Parkingspot", "Registration", "Size", "StartTime" },
                values: new object[,]
                {
                    { 43, 43, "6JMW833", 43, null },
                    { 44, 44, "535621B", 44, null },
                    { 45, 45, "4JWR404", 45, null },
                    { 46, 46, "N73EXY", 46, null },
                    { 47, 47, "K9CRZY", 47, null },
                    { 48, 48, "4GUG721", 48, null },
                    { 49, 49, "8GTS234", 49, null },
                    { 50, 50, "446AH", 50, null }
                });

            migrationBuilder.InsertData(
                table: "motorcycles",
                columns: new[] { "Id", "Parkingspot", "Registration", "Size", "StartTime" },
                values: new object[,]
                {
                    { 1, 0, "19AX641", 1, null },
                    { 2, 0, "55AR583", 2, null },
                    { 3, 0, "23AH141", 3, null },
                    { 4, 0, "7AR1649", 4, null },
                    { 5, 0, "52AD117", 5, null },
                    { 6, 0, "35AA969", 6, null },
                    { 7, 0, "35AZ101", 7, null },
                    { 8, 0, "26AA587", 8, null },
                    { 9, 0, "51AT445", 9, null },
                    { 10, 0, "26AI615", 10, null },
                    { 11, 0, "57AT653", 11, null },
                    { 12, 0, "62AB104", 12, null },
                    { 13, 0, "21AJ791", 13, null },
                    { 14, 0, "52AZ687", 14, null },
                    { 15, 0, "23AL427", 15, null },
                    { 16, 0, "38AI537", 16, null },
                    { 17, 0, "5AF5358", 17, null },
                    { 18, 0, "35AA351", 18, null },
                    { 19, 0, "55AN371", 19, null },
                    { 20, 0, "24AO379", 20, null },
                    { 21, 0, "64AR362", 21, null },
                    { 22, 0, "34AF518", 22, null },
                    { 23, 0, "38AQ555", 23, null },
                    { 24, 0, "24AI416", 24, null },
                    { 25, 0, "59AO966", 25, null },
                    { 26, 0, "34AT620", 26, null },
                    { 27, 0, "40AD140", 27, null },
                    { 28, 0, "30AG809", 28, null },
                    { 29, 0, "66AP991", 29, null },
                    { 30, 0, "18AD512", 30, null },
                    { 31, 0, "33AX623", 31, null },
                    { 32, 0, "64AP580", 32, null },
                    { 33, 0, "13AY794", 33, null },
                    { 34, 0, "55AC734", 34, null }
                });

            migrationBuilder.InsertData(
                table: "motorcycles",
                columns: new[] { "Id", "Parkingspot", "Registration", "Size", "StartTime" },
                values: new object[,]
                {
                    { 35, 0, "30AD500", 35, null },
                    { 36, 0, "38AF650", 36, null },
                    { 37, 0, "6AM1722", 37, null },
                    { 38, 0, "11AP780", 38, null },
                    { 39, 0, "54AG156", 39, null },
                    { 40, 0, "61AY262", 40, null },
                    { 41, 0, "62AK646", 41, null },
                    { 42, 0, "45AO853", 42, null },
                    { 43, 0, "20AF377", 43, null },
                    { 44, 0, "30AQ301", 44, null },
                    { 45, 0, "62AZ570", 45, null },
                    { 46, 0, "61AS803", 46, null },
                    { 47, 0, "25AG915", 47, null },
                    { 48, 0, "12AR787", 48, null },
                    { 49, 0, "11AV356", 49, null },
                    { 50, 0, "51AX141", 50, null }
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
