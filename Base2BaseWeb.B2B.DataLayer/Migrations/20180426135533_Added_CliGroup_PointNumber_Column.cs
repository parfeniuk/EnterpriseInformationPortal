using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Migrations
{
    public partial class Added_CliGroup_PointNumber_Column : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ChildName",
                table: "point",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PointNumber",
                table: "cli_group",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PointNumber",
                table: "cli_group");

            migrationBuilder.AlterColumn<string>(
                name: "ChildName",
                table: "point",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);
        }
    }
}
