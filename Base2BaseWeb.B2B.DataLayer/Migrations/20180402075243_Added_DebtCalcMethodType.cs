using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Migrations
{
    public partial class Added_DebtCalcMethodType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_point_cli_group_CliGroupNumber1",
            //    table: "point");

            //migrationBuilder.DropIndex(
            //    name: "IX_point_CliGroupNumber1",
            //    table: "point");

            migrationBuilder.DropIndex(
                name: "IX_DebtCalcMethodInfo_Name",
                table: "DebtCalcMethodInfo");

            //migrationBuilder.DropColumn(
            //    name: "CliGroupNumber1",
            //    table: "point");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "DebtCalcMethodInfo");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "DebtCalcMethodInfo");

            migrationBuilder.AddColumn<int>(
                name: "DebtCalcMethodTypeId",
                table: "DebtCalcMethodInfo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DebtCalcMethodType",
                columns: table => new
                {
                    DebtCalcMethodTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DebtCalcMethodType", x => x.DebtCalcMethodTypeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DebtCalcMethodInfo_DebtCalcMethodTypeId",
                table: "DebtCalcMethodInfo",
                column: "DebtCalcMethodTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DebtCalcMethodType_Name",
                table: "DebtCalcMethodType",
                column: "Name",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DebtCalcMethodInfo_DebtCalcMethodType_DebtCalcMethodTypeId",
                table: "DebtCalcMethodInfo",
                column: "DebtCalcMethodTypeId",
                principalTable: "DebtCalcMethodType",
                principalColumn: "DebtCalcMethodTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DebtCalcMethodInfo_DebtCalcMethodType_DebtCalcMethodTypeId",
                table: "DebtCalcMethodInfo");

            migrationBuilder.DropTable(
                name: "DebtCalcMethodType");

            migrationBuilder.DropIndex(
                name: "IX_DebtCalcMethodInfo_DebtCalcMethodTypeId",
                table: "DebtCalcMethodInfo");

            migrationBuilder.DropColumn(
                name: "DebtCalcMethodTypeId",
                table: "DebtCalcMethodInfo");

            //migrationBuilder.AddColumn<int>(
            //    name: "CliGroupNumber1",
            //    table: "point",
            //    nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "DebtCalcMethodInfo",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "DebtCalcMethodInfo",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            //migrationBuilder.CreateIndex(
            //    name: "IX_point_CliGroupNumber1",
            //    table: "point",
            //    column: "CliGroupNumber1");

            migrationBuilder.CreateIndex(
                name: "IX_DebtCalcMethodInfo_Name",
                table: "DebtCalcMethodInfo",
                column: "Name",
                unique: true);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_point_cli_group_CliGroupNumber1",
            //    table: "point",
            //    column: "CliGroupNumber1",
            //    principalTable: "cli_group",
            //    principalColumn: "cli_group_number",
            //    onDelete: ReferentialAction.Restrict);
        }
    }
}
