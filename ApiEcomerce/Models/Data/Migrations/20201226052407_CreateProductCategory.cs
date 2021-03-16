using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiEcomerce.Models.Data.Migrations
{
    public partial class CreateProductCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "ProductCategoryID", "Avatar", "Code", "CreateBy", "CreateTime", "Description", "Position", "ProductMainCategoryID", "Status", "Thumb", "Title" },
                values: new object[,]
                {
                    { 1, null, "", null, new DateTime(2020, 12, 26, 12, 24, 7, 357, DateTimeKind.Local).AddTicks(5707), "Danh mục áo thun", 1, 1, true, null, "Áo thun" },
                    { 2, null, "", null, new DateTime(2020, 12, 26, 12, 24, 7, 358, DateTimeKind.Local).AddTicks(5839), "Danh mục áo thun", 2, 1, true, null, "Áo Sơmi" },
                    { 3, null, "", null, new DateTime(2020, 12, 26, 12, 24, 7, 358, DateTimeKind.Local).AddTicks(5872), "Danh mục áo thun", 1, 3, true, null, "Áo Khoác" },
                    { 4, null, "", null, new DateTime(2020, 12, 26, 12, 24, 7, 358, DateTimeKind.Local).AddTicks(5875), "Danh mục quần jean", 4, 2, true, null, "Quần Jean" },
                    { 5, null, "", null, new DateTime(2020, 12, 26, 12, 24, 7, 358, DateTimeKind.Local).AddTicks(5877), "Danh mục quần kaki", 5, 2, true, null, "Quần Kaki" },
                    { 6, null, "", null, new DateTime(2020, 12, 26, 12, 24, 7, 358, DateTimeKind.Local).AddTicks(5879), "Danh mục quần Jogger", 6, 2, true, null, "Quần Jogger" },
                    { 7, null, "", null, new DateTime(2020, 12, 26, 12, 24, 7, 358, DateTimeKind.Local).AddTicks(5881), "Danh mục quần tây", 7, 2, true, null, "Quần Tây" },
                    { 8, null, "", null, new DateTime(2020, 12, 26, 12, 24, 7, 358, DateTimeKind.Local).AddTicks(5883), "Danh mục quần short", 7, 2, true, null, "Quần Short" }
                });

            migrationBuilder.UpdateData(
                table: "ProductMainCategory",
                keyColumn: "ProductMainCategoryID",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2020, 12, 26, 12, 24, 7, 359, DateTimeKind.Local).AddTicks(2701));

            migrationBuilder.UpdateData(
                table: "ProductMainCategory",
                keyColumn: "ProductMainCategoryID",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2020, 12, 26, 12, 24, 7, 359, DateTimeKind.Local).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "ProductMainCategory",
                keyColumn: "ProductMainCategoryID",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2020, 12, 26, 12, 24, 7, 359, DateTimeKind.Local).AddTicks(4774));

            migrationBuilder.UpdateData(
                table: "ProductMainCategory",
                keyColumn: "ProductMainCategoryID",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2020, 12, 26, 12, 24, 7, 359, DateTimeKind.Local).AddTicks(4777));

            migrationBuilder.UpdateData(
                table: "ProductMainCategory",
                keyColumn: "ProductMainCategoryID",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2020, 12, 26, 12, 24, 7, 359, DateTimeKind.Local).AddTicks(4779));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "ProductMainCategory",
                keyColumn: "ProductMainCategoryID",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2020, 12, 17, 12, 51, 55, 667, DateTimeKind.Local).AddTicks(9811));

            migrationBuilder.UpdateData(
                table: "ProductMainCategory",
                keyColumn: "ProductMainCategoryID",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2020, 12, 17, 12, 51, 55, 669, DateTimeKind.Local).AddTicks(562));

            migrationBuilder.UpdateData(
                table: "ProductMainCategory",
                keyColumn: "ProductMainCategoryID",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2020, 12, 17, 12, 51, 55, 669, DateTimeKind.Local).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "ProductMainCategory",
                keyColumn: "ProductMainCategoryID",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2020, 12, 17, 12, 51, 55, 669, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "ProductMainCategory",
                keyColumn: "ProductMainCategoryID",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2020, 12, 17, 12, 51, 55, 669, DateTimeKind.Local).AddTicks(622));
        }
    }
}
