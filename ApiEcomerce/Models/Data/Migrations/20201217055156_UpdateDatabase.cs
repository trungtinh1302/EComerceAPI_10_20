using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiEcomerce.Models.Data.Migrations
{
    public partial class UpdateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountCategory",
                columns: table => new
                {
                    AccountCategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Avatar = table.Column<byte[]>(nullable: true),
                    Thumb = table.Column<byte[]>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Position = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountCategory", x => x.AccountCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "ArticleMainCategory",
                columns: table => new
                {
                    ArticleMainCategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Avatar = table.Column<byte[]>(nullable: true),
                    Thumb = table.Column<byte[]>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Position = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleMainCategory", x => x.ArticleMainCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "ContactCategory",
                columns: table => new
                {
                    ContactCategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Avatar = table.Column<byte[]>(nullable: true),
                    Thumb = table.Column<byte[]>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Position = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactCategory", x => x.ContactCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "ProductMainCategory",
                columns: table => new
                {
                    ProductMainCategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Avatar = table.Column<byte[]>(nullable: true),
                    Thumb = table.Column<byte[]>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Position = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductMainCategory", x => x.ProductMainCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    AccountID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Avatar = table.Column<byte[]>(nullable: true),
                    Thumb = table.Column<byte[]>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Mobi = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Gender = table.Column<bool>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    AccountCategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.AccountID);
                    table.ForeignKey(
                        name: "FK_Account_AccountCategory_AccountCategoryID",
                        column: x => x.AccountCategoryID,
                        principalTable: "AccountCategory",
                        principalColumn: "AccountCategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArticleCategory",
                columns: table => new
                {
                    ArticleCategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Avatar = table.Column<byte[]>(nullable: true),
                    Thumb = table.Column<byte[]>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Position = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<string>(nullable: true),
                    ArticleMainCategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleCategory", x => x.ArticleCategoryID);
                    table.ForeignKey(
                        name: "FK_ArticleCategory_ArticleMainCategory_ArticleMainCategoryID",
                        column: x => x.ArticleMainCategoryID,
                        principalTable: "ArticleMainCategory",
                        principalColumn: "ArticleMainCategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    ContactID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Mobi = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    AttachmentFile = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    ApproveBy = table.Column<string>(nullable: true),
                    ContactCategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.ContactID);
                    table.ForeignKey(
                        name: "FK_Contact_ContactCategory_ContactCategoryID",
                        column: x => x.ContactCategoryID,
                        principalTable: "ContactCategory",
                        principalColumn: "ContactCategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategory",
                columns: table => new
                {
                    ProductCategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Avatar = table.Column<byte[]>(nullable: true),
                    Thumb = table.Column<byte[]>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Position = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<string>(nullable: true),
                    ProductMainCategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategory", x => x.ProductCategoryID);
                    table.ForeignKey(
                        name: "FK_ProductCategory_ProductMainCategory_ProductMainCategoryID",
                        column: x => x.ProductMainCategoryID,
                        principalTable: "ProductMainCategory",
                        principalColumn: "ProductMainCategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Article",
                columns: table => new
                {
                    ArticleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Avatar = table.Column<byte[]>(nullable: true),
                    Thumb = table.Column<byte[]>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    Keyword = table.Column<string>(nullable: true),
                    ImageList = table.Column<byte[]>(nullable: true),
                    SourcePage = table.Column<string>(nullable: true),
                    AttachmentFile = table.Column<string>(nullable: true),
                    ViewTime = table.Column<int>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    Position = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<string>(nullable: true),
                    ArticleCategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Article", x => x.ArticleID);
                    table.ForeignKey(
                        name: "FK_Article_ArticleCategory_ArticleCategoryID",
                        column: x => x.ArticleCategoryID,
                        principalTable: "ArticleCategory",
                        principalColumn: "ArticleCategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Avatar = table.Column<byte[]>(nullable: true),
                    Thumb = table.Column<byte[]>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    Keyword = table.Column<string>(nullable: true),
                    ImageList = table.Column<byte[]>(nullable: true),
                    GalleryImageList = table.Column<byte[]>(nullable: true),
                    SourcePage = table.Column<string>(nullable: true),
                    SourceLink = table.Column<string>(nullable: true),
                    ViewTime = table.Column<int>(nullable: false),
                    AttachmentFile = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    OldPrice = table.Column<double>(nullable: false),
                    Promotions = table.Column<string>(nullable: true),
                    WarrantyPolicy = table.Column<string>(nullable: true),
                    Specifications = table.Column<string>(nullable: true),
                    Accessories = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    Position = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<string>(nullable: true),
                    ProductCategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Product_ProductCategory_ProductCategoryID",
                        column: x => x.ProductCategoryID,
                        principalTable: "ProductCategory",
                        principalColumn: "ProductCategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AccountCategory",
                columns: new[] { "AccountCategoryID", "Avatar", "Description", "Position", "Status", "Thumb", "Title" },
                values: new object[,]
                {
                    { 1, null, "Tài khoản khách hàng 1", 1, true, null, "Client Account 1" },
                    { 2, null, "Tài khoản khách hàng 2", 1, true, null, "Client Account 2" }
                });

            migrationBuilder.InsertData(
                table: "ProductMainCategory",
                columns: new[] { "ProductMainCategoryID", "Avatar", "Code", "CreateBy", "CreateTime", "Description", "Position", "Status", "Thumb", "Title" },
                values: new object[,]
                {
                    { 1, null, "1", null, new DateTime(2020, 12, 17, 12, 51, 55, 667, DateTimeKind.Local).AddTicks(9811), "Danh mục áo", 1, true, null, "Áo" },
                    { 2, null, "2", null, new DateTime(2020, 12, 17, 12, 51, 55, 669, DateTimeKind.Local).AddTicks(562), "Danh mục quần", 2, true, null, "Quần" },
                    { 3, null, "3", null, new DateTime(2020, 12, 17, 12, 51, 55, 669, DateTimeKind.Local).AddTicks(618), "Danh mục giày", 3, true, null, "Giày" },
                    { 4, null, "4", null, new DateTime(2020, 12, 17, 12, 51, 55, 669, DateTimeKind.Local).AddTicks(621), "Danh mục phụ kiện", 4, true, null, "Phụ kiện" },
                    { 5, null, "5", null, new DateTime(2020, 12, 17, 12, 51, 55, 669, DateTimeKind.Local).AddTicks(622), "Danh mục bộ sưu tập", 5, true, null, "Collection" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Account_AccountCategoryID",
                table: "Account",
                column: "AccountCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Article_ArticleCategoryID",
                table: "Article",
                column: "ArticleCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleCategory_ArticleMainCategoryID",
                table: "ArticleCategory",
                column: "ArticleMainCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_ContactCategoryID",
                table: "Contact",
                column: "ContactCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductCategoryID",
                table: "Product",
                column: "ProductCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategory_ProductMainCategoryID",
                table: "ProductCategory",
                column: "ProductMainCategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Article");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "AccountCategory");

            migrationBuilder.DropTable(
                name: "ArticleCategory");

            migrationBuilder.DropTable(
                name: "ContactCategory");

            migrationBuilder.DropTable(
                name: "ProductCategory");

            migrationBuilder.DropTable(
                name: "ArticleMainCategory");

            migrationBuilder.DropTable(
                name: "ProductMainCategory");
        }
    }
}
