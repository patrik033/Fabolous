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
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Size = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_motorcycles", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "cars",
                columns: new[] { "Id", "Registration", "Size", "StartTime" },
                values: new object[,]
                {
                    { 1, "GBD5472", 1, null },
                    { 2, "7ZEE285", 2, null },
                    { 3, "T5540N", 3, null },
                    { 4, "LKY3494", 4, null },
                    { 5, "FXZ6807", 5, null },
                    { 6, "8236TE", 6, null },
                    { 7, "630XDK", 7, null },
                    { 8, "LOVE", 8, null },
                    { 9, "8739698", 9, null },
                    { 10, "KK9915", 10, null },
                    { 11, "BENCH", 11, null },
                    { 12, "HYB4966", 12, null },
                    { 13, "7K44135", 13, null },
                    { 14, "HTM4861", 14, null },
                    { 15, "5WAS727", 15, null },
                    { 16, "1076952", 16, null },
                    { 17, "QFX241", 17, null },
                    { 18, "7Z50T2", 18, null },
                    { 19, "6LME062", 19, null },
                    { 20, "7UFH698", 20, null },
                    { 21, "EUG190", 21, null },
                    { 22, "X35FNH", 22, null },
                    { 23, "KQVR90", 23, null },
                    { 24, "8EYV287", 24, null },
                    { 25, "6855OP", 25, null },
                    { 26, "7AAA642", 26, null },
                    { 27, "7YBK462", 27, null },
                    { 28, "8DGP853", 28, null },
                    { 29, "SC20365", 29, null },
                    { 30, "BCF9407", 30, null },
                    { 31, "CKH7844", 31, null },
                    { 32, "BB9487", 32, null },
                    { 33, "487TBS", 33, null },
                    { 34, "SC20337", 34, null },
                    { 35, "L4802T", 35, null },
                    { 36, "BWN8988", 36, null },
                    { 37, "DRG4N6", 37, null },
                    { 38, "0AGVG0", 38, null },
                    { 39, "DKVQ31", 39, null },
                    { 40, "22528MC", 40, null },
                    { 41, "1CK7456", 41, null },
                    { 42, "AEH9540", 42, null }
                });

            migrationBuilder.InsertData(
                table: "cars",
                columns: new[] { "Id", "Registration", "Size", "StartTime" },
                values: new object[,]
                {
                    { 43, "6JMW833", 43, null },
                    { 44, "535621B", 44, null },
                    { 45, "4JWR404", 45, null },
                    { 46, "N73EXY", 46, null },
                    { 47, "K9CRZY", 47, null },
                    { 48, "4GUG721", 48, null },
                    { 49, "8GTS234", 49, null },
                    { 50, "446AH", 50, null }
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
