using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Migrations
{
    public partial class SetNullableFranchisingTypeId_FranchisingInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FranchisingTypeId",
                table: "FranchisingInfo",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FranchisingTypeId",
                table: "FranchisingInfo",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
