using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseAccessLibrary.Migrations
{
    public partial class mcinitdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "motorcycles",
                columns: new[] { "Id", "Registration", "Size", "StartTime" },
                values: new object[,]
                {
                    { 1, "19AX641", 1, null },
                    { 2, "55AR583", 2, null },
                    { 3, "23AH141", 3, null },
                    { 4, "7AR1649", 4, null },
                    { 5, "52AD117", 5, null },
                    { 6, "35AA969", 6, null },
                    { 7, "35AZ101", 7, null },
                    { 8, "26AA587", 8, null },
                    { 9, "51AT445", 9, null },
                    { 10, "26AI615", 10, null },
                    { 11, "57AT653", 11, null },
                    { 12, "62AB104", 12, null },
                    { 13, "21AJ791", 13, null },
                    { 14, "52AZ687", 14, null },
                    { 15, "23AL427", 15, null },
                    { 16, "38AI537", 16, null },
                    { 17, "5AF5358", 17, null },
                    { 18, "35AA351", 18, null },
                    { 19, "55AN371", 19, null },
                    { 20, "24AO379", 20, null },
                    { 21, "64AR362", 21, null },
                    { 22, "34AF518", 22, null },
                    { 23, "38AQ555", 23, null },
                    { 24, "24AI416", 24, null },
                    { 25, "59AO966", 25, null },
                    { 26, "34AT620", 26, null },
                    { 27, "40AD140", 27, null },
                    { 28, "30AG809", 28, null },
                    { 29, "66AP991", 29, null },
                    { 30, "18AD512", 30, null },
                    { 31, "33AX623", 31, null },
                    { 32, "64AP580", 32, null },
                    { 33, "13AY794", 33, null },
                    { 34, "55AC734", 34, null },
                    { 35, "30AD500", 35, null },
                    { 36, "38AF650", 36, null },
                    { 37, "6AM1722", 37, null },
                    { 38, "11AP780", 38, null },
                    { 39, "54AG156", 39, null },
                    { 40, "61AY262", 40, null },
                    { 41, "62AK646", 41, null },
                    { 42, "45AO853", 42, null }
                });

            migrationBuilder.InsertData(
                table: "motorcycles",
                columns: new[] { "Id", "Registration", "Size", "StartTime" },
                values: new object[,]
                {
                    { 43, "20AF377", 43, null },
                    { 44, "30AQ301", 44, null },
                    { 45, "62AZ570", 45, null },
                    { 46, "61AS803", 46, null },
                    { 47, "25AG915", 47, null },
                    { 48, "12AR787", 48, null },
                    { 49, "11AV356", 49, null },
                    { 50, "51AX141", 50, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "motorcycles",
                keyColumn: "Id",
                keyValue: 50);
        }
    }
}
