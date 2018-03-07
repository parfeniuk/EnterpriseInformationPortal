using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Base2BaseWeb.DataLayer.Migrations
{
    public partial class ProductSubCategories_Deleted_ProductSubCategoriesName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductSubCategoryName",
                table: "ProductSubCategories");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductSubCategoryName",
                table: "ProductSubCategories",
                nullable: true);
        }
    }
}
