using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Migrations
{
    public partial class Changed_Relations_DocumentTemplate_ServicePlaceholder_Tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PrintJobInfo_DocumentTemplateId",
                table: "PrintJobInfo");

            migrationBuilder.DropIndex(
                name: "IX_BillSettingsOptionsInfo_DocumentTemplateId",
                table: "BillSettingsOptionsInfo");

            migrationBuilder.DropIndex(
                name: "IX_BillSettingsInfo_DocumentTemplateId",
                table: "BillSettingsInfo");

            migrationBuilder.DropIndex(
                name: "IX_BillSettingsInfo_ServicePlaceholderTypeId",
                table: "BillSettingsInfo");

            migrationBuilder.CreateIndex(
                name: "IX_PrintJobInfo_DocumentTemplateId",
                table: "PrintJobInfo",
                column: "DocumentTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_BillSettingsOptionsInfo_DocumentTemplateId",
                table: "BillSettingsOptionsInfo",
                column: "DocumentTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_BillSettingsInfo_DocumentTemplateId",
                table: "BillSettingsInfo",
                column: "DocumentTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_BillSettingsInfo_ServicePlaceholderTypeId",
                table: "BillSettingsInfo",
                column: "ServicePlaceholderTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PrintJobInfo_DocumentTemplateId",
                table: "PrintJobInfo");

            migrationBuilder.DropIndex(
                name: "IX_BillSettingsOptionsInfo_DocumentTemplateId",
                table: "BillSettingsOptionsInfo");

            migrationBuilder.DropIndex(
                name: "IX_BillSettingsInfo_DocumentTemplateId",
                table: "BillSettingsInfo");

            migrationBuilder.DropIndex(
                name: "IX_BillSettingsInfo_ServicePlaceholderTypeId",
                table: "BillSettingsInfo");

            migrationBuilder.CreateIndex(
                name: "IX_PrintJobInfo_DocumentTemplateId",
                table: "PrintJobInfo",
                column: "DocumentTemplateId",
                unique: true,
                filter: "[DocumentTemplateId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BillSettingsOptionsInfo_DocumentTemplateId",
                table: "BillSettingsOptionsInfo",
                column: "DocumentTemplateId",
                unique: true,
                filter: "[DocumentTemplateId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BillSettingsInfo_DocumentTemplateId",
                table: "BillSettingsInfo",
                column: "DocumentTemplateId",
                unique: true,
                filter: "[DocumentTemplateId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BillSettingsInfo_ServicePlaceholderTypeId",
                table: "BillSettingsInfo",
                column: "ServicePlaceholderTypeId",
                unique: true,
                filter: "[ServicePlaceholderTypeId] IS NOT NULL");
        }
    }
}
