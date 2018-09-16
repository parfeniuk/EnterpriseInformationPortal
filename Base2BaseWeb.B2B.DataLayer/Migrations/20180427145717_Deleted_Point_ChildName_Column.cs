using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Migrations
{
    public partial class Deleted_Point_ChildName_Column : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChildName",
                table: "point");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ChildName",
                table: "point",
                maxLength: 255,
                nullable: true);
        }
    }
}
