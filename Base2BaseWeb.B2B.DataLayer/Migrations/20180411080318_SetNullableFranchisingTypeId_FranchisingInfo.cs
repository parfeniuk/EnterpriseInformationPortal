using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Text;

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
            // Update NULL values before changing column type from NULLABLE to NOT NULLABLE
            StringBuilder updateNull = new StringBuilder();
            updateNull.Append("Delete from FranchisingInfo" + Environment.NewLine);
            updateNull.Append("Where FranchisingTypeId is Null" + Environment.NewLine);
            migrationBuilder.Sql(updateNull.ToString());

            migrationBuilder.AlterColumn<int>(
                name: "FranchisingTypeId",
                table: "FranchisingInfo",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
