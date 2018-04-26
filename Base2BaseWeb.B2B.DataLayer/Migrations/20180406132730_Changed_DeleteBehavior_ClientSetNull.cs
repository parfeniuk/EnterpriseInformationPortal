using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Migrations
{
    public partial class Changed_DeleteBehavior_ClientSetNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillSettingsInfo_point_PointNumber",
                table: "BillSettingsInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_BillSettingsOptionsInfo_BillSettingsInfo_BillSettingsInfoId",
                table: "BillSettingsOptionsInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientConnectionInfo_point_PointNumber",
                table: "ClientConnectionInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactEmailInfo_point_PointNumber",
                table: "ContactEmailInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactPhonelInfo_point_PointNumber",
                table: "ContactPhonelInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_DebtCalcMethodInfo_DebtCalcMethodType_DebtCalcMethodTypeId",
                table: "DebtCalcMethodInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_DebtCalcMethodInfo_point_PointNumber",
                table: "DebtCalcMethodInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_DebtControlInfo_point_PointNumber",
                table: "DebtControlInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_DocumentTemplate_DocumentTemplateCategory_DocumentTemplateCategoryId",
                table: "DocumentTemplate");

            migrationBuilder.DropForeignKey(
                name: "FK_FranchisingInfo_FranchisingType_FranchisingTypeId",
                table: "FranchisingInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_FranchisingInfo_point_PointNumber",
                table: "FranchisingInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_PrintJobInfo_BillSettingsInfo_BillSettingsInfoId",
                table: "PrintJobInfo");

            migrationBuilder.AddForeignKey(
                name: "FK_BillSettingsInfo_point_PointNumber",
                table: "BillSettingsInfo",
                column: "PointNumber",
                principalTable: "point",
                principalColumn: "point_number",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BillSettingsOptionsInfo_BillSettingsInfo_BillSettingsInfoId",
                table: "BillSettingsOptionsInfo",
                column: "BillSettingsInfoId",
                principalTable: "BillSettingsInfo",
                principalColumn: "BillSettingsInfoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientConnectionInfo_point_PointNumber",
                table: "ClientConnectionInfo",
                column: "PointNumber",
                principalTable: "point",
                principalColumn: "point_number",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactEmailInfo_point_PointNumber",
                table: "ContactEmailInfo",
                column: "PointNumber",
                principalTable: "point",
                principalColumn: "point_number",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactPhonelInfo_point_PointNumber",
                table: "ContactPhonelInfo",
                column: "PointNumber",
                principalTable: "point",
                principalColumn: "point_number",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DebtCalcMethodInfo_DebtCalcMethodType_DebtCalcMethodTypeId",
                table: "DebtCalcMethodInfo",
                column: "DebtCalcMethodTypeId",
                principalTable: "DebtCalcMethodType",
                principalColumn: "DebtCalcMethodTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DebtCalcMethodInfo_point_PointNumber",
                table: "DebtCalcMethodInfo",
                column: "PointNumber",
                principalTable: "point",
                principalColumn: "point_number",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DebtControlInfo_point_PointNumber",
                table: "DebtControlInfo",
                column: "PointNumber",
                principalTable: "point",
                principalColumn: "point_number",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentTemplate_DocumentTemplateCategory_DocumentTemplateCategoryId",
                table: "DocumentTemplate",
                column: "DocumentTemplateCategoryId",
                principalTable: "DocumentTemplateCategory",
                principalColumn: "DocumentTemplateCategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FranchisingInfo_FranchisingType_FranchisingTypeId",
                table: "FranchisingInfo",
                column: "FranchisingTypeId",
                principalTable: "FranchisingType",
                principalColumn: "FranchisingTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FranchisingInfo_point_PointNumber",
                table: "FranchisingInfo",
                column: "PointNumber",
                principalTable: "point",
                principalColumn: "point_number",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PrintJobInfo_BillSettingsInfo_BillSettingsInfoId",
                table: "PrintJobInfo",
                column: "BillSettingsInfoId",
                principalTable: "BillSettingsInfo",
                principalColumn: "BillSettingsInfoId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillSettingsInfo_point_PointNumber",
                table: "BillSettingsInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_BillSettingsOptionsInfo_BillSettingsInfo_BillSettingsInfoId",
                table: "BillSettingsOptionsInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientConnectionInfo_point_PointNumber",
                table: "ClientConnectionInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactEmailInfo_point_PointNumber",
                table: "ContactEmailInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactPhonelInfo_point_PointNumber",
                table: "ContactPhonelInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_DebtCalcMethodInfo_DebtCalcMethodType_DebtCalcMethodTypeId",
                table: "DebtCalcMethodInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_DebtCalcMethodInfo_point_PointNumber",
                table: "DebtCalcMethodInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_DebtControlInfo_point_PointNumber",
                table: "DebtControlInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_DocumentTemplate_DocumentTemplateCategory_DocumentTemplateCategoryId",
                table: "DocumentTemplate");

            migrationBuilder.DropForeignKey(
                name: "FK_FranchisingInfo_FranchisingType_FranchisingTypeId",
                table: "FranchisingInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_FranchisingInfo_point_PointNumber",
                table: "FranchisingInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_PrintJobInfo_BillSettingsInfo_BillSettingsInfoId",
                table: "PrintJobInfo");

            migrationBuilder.AddForeignKey(
                name: "FK_BillSettingsInfo_point_PointNumber",
                table: "BillSettingsInfo",
                column: "PointNumber",
                principalTable: "point",
                principalColumn: "point_number",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BillSettingsOptionsInfo_BillSettingsInfo_BillSettingsInfoId",
                table: "BillSettingsOptionsInfo",
                column: "BillSettingsInfoId",
                principalTable: "BillSettingsInfo",
                principalColumn: "BillSettingsInfoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientConnectionInfo_point_PointNumber",
                table: "ClientConnectionInfo",
                column: "PointNumber",
                principalTable: "point",
                principalColumn: "point_number",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactEmailInfo_point_PointNumber",
                table: "ContactEmailInfo",
                column: "PointNumber",
                principalTable: "point",
                principalColumn: "point_number",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactPhonelInfo_point_PointNumber",
                table: "ContactPhonelInfo",
                column: "PointNumber",
                principalTable: "point",
                principalColumn: "point_number",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DebtCalcMethodInfo_DebtCalcMethodType_DebtCalcMethodTypeId",
                table: "DebtCalcMethodInfo",
                column: "DebtCalcMethodTypeId",
                principalTable: "DebtCalcMethodType",
                principalColumn: "DebtCalcMethodTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DebtCalcMethodInfo_point_PointNumber",
                table: "DebtCalcMethodInfo",
                column: "PointNumber",
                principalTable: "point",
                principalColumn: "point_number",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DebtControlInfo_point_PointNumber",
                table: "DebtControlInfo",
                column: "PointNumber",
                principalTable: "point",
                principalColumn: "point_number",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentTemplate_DocumentTemplateCategory_DocumentTemplateCategoryId",
                table: "DocumentTemplate",
                column: "DocumentTemplateCategoryId",
                principalTable: "DocumentTemplateCategory",
                principalColumn: "DocumentTemplateCategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FranchisingInfo_FranchisingType_FranchisingTypeId",
                table: "FranchisingInfo",
                column: "FranchisingTypeId",
                principalTable: "FranchisingType",
                principalColumn: "FranchisingTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FranchisingInfo_point_PointNumber",
                table: "FranchisingInfo",
                column: "PointNumber",
                principalTable: "point",
                principalColumn: "point_number",
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
