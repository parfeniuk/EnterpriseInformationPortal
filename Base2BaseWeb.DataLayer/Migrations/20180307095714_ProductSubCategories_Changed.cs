using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Base2BaseWeb.DataLayer.Migrations
{
    public partial class ProductSubCategories_Changed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ProductSubCategories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShortDescription",
                table: "ProductSubCategories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "ProductSubCategories",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductSubCategoryFeature",
                columns: table => new
                {
                    ProductSubCategoryFeatureId = table.Column<Guid>(nullable: false),
                    FontIconName = table.Column<string>(nullable: true),
                    FontType = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ProductSubCategoryId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSubCategoryFeature", x => x.ProductSubCategoryFeatureId);
                    table.ForeignKey(
                        name: "FK_ProductSubCategoryFeature_ProductSubCategories_ProductSubCategoryId",
                        column: x => x.ProductSubCategoryId,
                        principalTable: "ProductSubCategories",
                        principalColumn: "ProductSubCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductSubCategoryImage",
                columns: table => new
                {
                    ProductSubCategoryImageId = table.Column<Guid>(nullable: false),
                    IsPoster = table.Column<bool>(nullable: false),
                    Path = table.Column<string>(nullable: true),
                    ProductSubCategoryId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSubCategoryImage", x => x.ProductSubCategoryImageId);
                    table.ForeignKey(
                        name: "FK_ProductSubCategoryImage_ProductSubCategories_ProductSubCategoryId",
                        column: x => x.ProductSubCategoryId,
                        principalTable: "ProductSubCategories",
                        principalColumn: "ProductSubCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductSubCategoryFeature_ProductSubCategoryId",
                table: "ProductSubCategoryFeature",
                column: "ProductSubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSubCategoryImage_ProductSubCategoryId",
                table: "ProductSubCategoryImage",
                column: "ProductSubCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductSubCategoryFeature");

            migrationBuilder.DropTable(
                name: "ProductSubCategoryImage");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "ProductSubCategories");

            migrationBuilder.DropColumn(
                name: "ShortDescription",
                table: "ProductSubCategories");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "ProductSubCategories");
        }
    }
}
