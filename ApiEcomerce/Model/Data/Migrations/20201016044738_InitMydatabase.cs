using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiEcomerce.Model.Data.Migrations
{
    public partial class InitMydatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountCategories",
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
                    table.PrimaryKey("PK_AccountCategories", x => x.AccountCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "ArticleMainCategories",
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
                    table.PrimaryKey("PK_ArticleMainCategories", x => x.ArticleMainCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "ContactCategories",
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
                    table.PrimaryKey("PK_ContactCategories", x => x.ContactCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "ProductMainCategories",
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
                    table.PrimaryKey("PK_ProductMainCategories", x => x.ProductMainCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
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
                    table.PrimaryKey("PK_Accounts", x => x.AccountID);
                    table.ForeignKey(
                        name: "FK_Accounts_AccountCategories_AccountCategoryID",
                        column: x => x.AccountCategoryID,
                        principalTable: "AccountCategories",
                        principalColumn: "AccountCategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArticleCategories",
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
                    table.PrimaryKey("PK_ArticleCategories", x => x.ArticleCategoryID);
                    table.ForeignKey(
                        name: "FK_ArticleCategories_ArticleMainCategories_ArticleMainCategoryID",
                        column: x => x.ArticleMainCategoryID,
                        principalTable: "ArticleMainCategories",
                        principalColumn: "ArticleMainCategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
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
                    table.PrimaryKey("PK_Contacts", x => x.ContactID);
                    table.ForeignKey(
                        name: "FK_Contacts_ContactCategories_ContactCategoryID",
                        column: x => x.ContactCategoryID,
                        principalTable: "ContactCategories",
                        principalColumn: "ContactCategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
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
                    table.PrimaryKey("PK_ProductCategories", x => x.ProductCategoryID);
                    table.ForeignKey(
                        name: "FK_ProductCategories_ProductMainCategories_ProductMainCategoryID",
                        column: x => x.ProductMainCategoryID,
                        principalTable: "ProductMainCategories",
                        principalColumn: "ProductMainCategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
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
                    table.PrimaryKey("PK_Articles", x => x.ArticleID);
                    table.ForeignKey(
                        name: "FK_Articles_ArticleCategories_ArticleCategoryID",
                        column: x => x.ArticleCategoryID,
                        principalTable: "ArticleCategories",
                        principalColumn: "ArticleCategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
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
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategories_ProductCategoryID",
                        column: x => x.ProductCategoryID,
                        principalTable: "ProductCategories",
                        principalColumn: "ProductCategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_AccountCategoryID",
                table: "Accounts",
                column: "AccountCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleCategories_ArticleMainCategoryID",
                table: "ArticleCategories",
                column: "ArticleMainCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ArticleCategoryID",
                table: "Articles",
                column: "ArticleCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_ContactCategoryID",
                table: "Contacts",
                column: "ContactCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_ProductMainCategoryID",
                table: "ProductCategories",
                column: "ProductMainCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCategoryID",
                table: "Products",
                column: "ProductCategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AccountCategories");

            migrationBuilder.DropTable(
                name: "ArticleCategories");

            migrationBuilder.DropTable(
                name: "ContactCategories");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "ArticleMainCategories");

            migrationBuilder.DropTable(
                name: "ProductMainCategories");
        }
    }
}
