using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Migrations
{
    public partial class Added_FranchisingType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DebtCalcMethodInfo_DebtCalcMethodType_DebtCalcMethodTypeId",
                table: "DebtCalcMethodInfo");

            migrationBuilder.DropColumn(
                name: "IsFranchisee",
                table: "FranchisingInfo");

            migrationBuilder.DropColumn(
                name: "IsFranchisor",
                table: "FranchisingInfo");

            migrationBuilder.DropColumn(
                name: "UseFranchising",
                table: "FranchisingInfo");

            migrationBuilder.AddColumn<int>(
                name: "FranchisingTypeId",
                table: "FranchisingInfo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "FranchisingType",
                columns: table => new
                {
                    FranchisingTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FranchisingType", x => x.FranchisingTypeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FranchisingInfo_FranchisingTypeId",
                table: "FranchisingInfo",
                column: "FranchisingTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_FranchisingType_Name",
                table: "FranchisingType",
                column: "Name",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DebtCalcMethodInfo_DebtCalcMethodType_DebtCalcMethodTypeId",
                table: "DebtCalcMethodInfo",
                column: "DebtCalcMethodTypeId",
                principalTable: "DebtCalcMethodType",
                principalColumn: "DebtCalcMethodTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FranchisingInfo_FranchisingType_FranchisingTypeId",
                table: "FranchisingInfo",
                column: "FranchisingTypeId",
                principalTable: "FranchisingType",
                principalColumn: "FranchisingTypeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DebtCalcMethodInfo_DebtCalcMethodType_DebtCalcMethodTypeId",
                table: "DebtCalcMethodInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_FranchisingInfo_FranchisingType_FranchisingTypeId",
                table: "FranchisingInfo");

            migrationBuilder.DropTable(
                name: "FranchisingType");

            migrationBuilder.DropIndex(
                name: "IX_FranchisingInfo_FranchisingTypeId",
                table: "FranchisingInfo");

            migrationBuilder.DropColumn(
                name: "FranchisingTypeId",
                table: "FranchisingInfo");

            migrationBuilder.AddColumn<bool>(
                name: "IsFranchisee",
                table: "FranchisingInfo",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsFranchisor",
                table: "FranchisingInfo",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "UseFranchising",
                table: "FranchisingInfo",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_DebtCalcMethodInfo_DebtCalcMethodType_DebtCalcMethodTypeId",
                table: "DebtCalcMethodInfo",
                column: "DebtCalcMethodTypeId",
                principalTable: "DebtCalcMethodType",
                principalColumn: "DebtCalcMethodTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
