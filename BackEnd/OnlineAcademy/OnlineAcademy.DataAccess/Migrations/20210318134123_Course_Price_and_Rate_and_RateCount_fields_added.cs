using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineAcademy.DataAccess.Migrations
{
    public partial class Course_Price_and_Rate_and_RateCount_fields_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Courses",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Rate",
                table: "Courses",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "RateCount",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 18, 16, 41, 21, 964, DateTimeKind.Local).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 18, 16, 41, 21, 965, DateTimeKind.Local).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 18, 16, 41, 21, 965, DateTimeKind.Local).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 18, 16, 41, 21, 965, DateTimeKind.Local).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 18, 16, 41, 21, 965, DateTimeKind.Local).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 18, 16, 41, 21, 965, DateTimeKind.Local).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 18, 16, 41, 21, 974, DateTimeKind.Local).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 18, 16, 41, 21, 974, DateTimeKind.Local).AddTicks(9062));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 18, 16, 41, 21, 990, DateTimeKind.Local).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 18, 16, 41, 21, 990, DateTimeKind.Local).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 18, 16, 41, 21, 998, DateTimeKind.Local).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 18, 16, 41, 21, 998, DateTimeKind.Local).AddTicks(918));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 18, 16, 41, 21, 998, DateTimeKind.Local).AddTicks(923));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 18, 16, 41, 22, 0, DateTimeKind.Local).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 18, 16, 41, 22, 0, DateTimeKind.Local).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 18, 16, 41, 22, 0, DateTimeKind.Local).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 18, 16, 41, 22, 0, DateTimeKind.Local).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 18, 16, 41, 22, 3, DateTimeKind.Local).AddTicks(6428));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 18, 16, 41, 22, 3, DateTimeKind.Local).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 18, 16, 41, 22, 3, DateTimeKind.Local).AddTicks(6533));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 18, 16, 41, 22, 6, DateTimeKind.Local).AddTicks(7852));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 18, 16, 41, 22, 6, DateTimeKind.Local).AddTicks(7911));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 18, 16, 41, 22, 6, DateTimeKind.Local).AddTicks(7915));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 18, 16, 41, 22, 6, DateTimeKind.Local).AddTicks(7919));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Rate",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "RateCount",
                table: "Courses");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 17, 12, 58, 56, 141, DateTimeKind.Local).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 17, 12, 58, 56, 141, DateTimeKind.Local).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 17, 12, 58, 56, 141, DateTimeKind.Local).AddTicks(7014));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 17, 12, 58, 56, 141, DateTimeKind.Local).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 17, 12, 58, 56, 141, DateTimeKind.Local).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 17, 12, 58, 56, 141, DateTimeKind.Local).AddTicks(7026));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 17, 12, 58, 56, 150, DateTimeKind.Local).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 17, 12, 58, 56, 150, DateTimeKind.Local).AddTicks(9638));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 17, 12, 58, 56, 166, DateTimeKind.Local).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 17, 12, 58, 56, 166, DateTimeKind.Local).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 17, 12, 58, 56, 173, DateTimeKind.Local).AddTicks(9949));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 17, 12, 58, 56, 174, DateTimeKind.Local).AddTicks(6));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 17, 12, 58, 56, 174, DateTimeKind.Local).AddTicks(11));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 17, 12, 58, 56, 176, DateTimeKind.Local).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 17, 12, 58, 56, 176, DateTimeKind.Local).AddTicks(2925));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 17, 12, 58, 56, 176, DateTimeKind.Local).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 17, 12, 58, 56, 176, DateTimeKind.Local).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 17, 12, 58, 56, 179, DateTimeKind.Local).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 17, 12, 58, 56, 179, DateTimeKind.Local).AddTicks(3147));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 17, 12, 58, 56, 179, DateTimeKind.Local).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 17, 12, 58, 56, 182, DateTimeKind.Local).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 17, 12, 58, 56, 182, DateTimeKind.Local).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 17, 12, 58, 56, 182, DateTimeKind.Local).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 17, 12, 58, 56, 182, DateTimeKind.Local).AddTicks(1971));
        }
    }
}
