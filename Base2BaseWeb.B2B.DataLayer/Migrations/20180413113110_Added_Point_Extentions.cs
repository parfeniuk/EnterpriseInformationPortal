using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Migrations
{
    public partial class Added_Point_Extentions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillSettingsOptionsInfo_BillSettingsInfo_BillSettingsInfoId",
                table: "BillSettingsOptionsInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_PrintJobInfo_BillSettingsInfo_BillSettingsInfoId",
                table: "PrintJobInfo");

            migrationBuilder.DropColumn(
                name: "ReplaceServiceList",
                table: "BillSettingsInfo");

            migrationBuilder.RenameColumn(
                name: "BillSettingsInfoId",
                table: "PrintJobInfo",
                newName: "PointNumber");

            migrationBuilder.RenameIndex(
                name: "IX_PrintJobInfo_BillSettingsInfoId",
                table: "PrintJobInfo",
                newName: "IX_PrintJobInfo_PointNumber");

            migrationBuilder.RenameColumn(
                name: "BillSettingsInfoId",
                table: "BillSettingsOptionsInfo",
                newName: "PointNumber");

            migrationBuilder.RenameColumn(
                name: "BillSettingsOptionsInfoId",
                table: "BillSettingsOptionsInfo",
                newName: "BillOptionsInfoId");

            migrationBuilder.RenameIndex(
                name: "IX_BillSettingsOptionsInfo_BillSettingsInfoId",
                table: "BillSettingsOptionsInfo",
                newName: "IX_BillSettingsOptionsInfo_PointNumber");

            migrationBuilder.AddColumn<int>(
                name: "ServicePlaceholderTypeId",
                table: "BillSettingsInfo",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ServicePlaceholderType",
                columns: table => new
                {
                    ServicePlaceholderTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicePlaceholderType", x => x.ServicePlaceholderTypeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BillSettingsInfo_ServicePlaceholderTypeId",
                table: "BillSettingsInfo",
                column: "ServicePlaceholderTypeId",
                unique: true,
                filter: "[ServicePlaceholderTypeId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ServicePlaceholderType_Name",
                table: "ServicePlaceholderType",
                column: "Name",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BillSettingsInfo_ServicePlaceholderType_ServicePlaceholderTypeId",
                table: "BillSettingsInfo",
                column: "ServicePlaceholderTypeId",
                principalTable: "ServicePlaceholderType",
                principalColumn: "ServicePlaceholderTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BillSettingsOptionsInfo_point_PointNumber",
                table: "BillSettingsOptionsInfo",
                column: "PointNumber",
                principalTable: "point",
                principalColumn: "point_number",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PrintJobInfo_point_PointNumber",
                table: "PrintJobInfo",
                column: "PointNumber",
                principalTable: "point",
                principalColumn: "point_number",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillSettingsInfo_ServicePlaceholderType_ServicePlaceholderTypeId",
                table: "BillSettingsInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_BillSettingsOptionsInfo_point_PointNumber",
                table: "BillSettingsOptionsInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_PrintJobInfo_point_PointNumber",
                table: "PrintJobInfo");

            migrationBuilder.DropTable(
                name: "ServicePlaceholderType");

            migrationBuilder.DropIndex(
                name: "IX_BillSettingsInfo_ServicePlaceholderTypeId",
                table: "BillSettingsInfo");

            migrationBuilder.DropColumn(
                name: "ServicePlaceholderTypeId",
                table: "BillSettingsInfo");

            migrationBuilder.RenameColumn(
                name: "PointNumber",
                table: "PrintJobInfo",
                newName: "BillSettingsInfoId");

            migrationBuilder.RenameIndex(
                name: "IX_PrintJobInfo_PointNumber",
                table: "PrintJobInfo",
                newName: "IX_PrintJobInfo_BillSettingsInfoId");

            migrationBuilder.RenameColumn(
                name: "PointNumber",
                table: "BillSettingsOptionsInfo",
                newName: "BillSettingsInfoId");

            migrationBuilder.RenameColumn(
                name: "BillOptionsInfoId",
                table: "BillSettingsOptionsInfo",
                newName: "BillSettingsOptionsInfoId");

            migrationBuilder.RenameIndex(
                name: "IX_BillSettingsOptionsInfo_PointNumber",
                table: "BillSettingsOptionsInfo",
                newName: "IX_BillSettingsOptionsInfo_BillSettingsInfoId");

            migrationBuilder.AddColumn<bool>(
                name: "ReplaceServiceList",
                table: "BillSettingsInfo",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_BillSettingsOptionsInfo_BillSettingsInfo_BillSettingsInfoId",
                table: "BillSettingsOptionsInfo",
                column: "BillSettingsInfoId",
                principalTable: "BillSettingsInfo",
                principalColumn: "BillSettingsInfoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PrintJobInfo_BillSettingsInfo_BillSettingsInfoId",
                table: "PrintJobInfo",
                column: "BillSettingsInfoId",
                principalTable: "BillSettingsInfo",
                principalColumn: "BillSettingsInfoId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
