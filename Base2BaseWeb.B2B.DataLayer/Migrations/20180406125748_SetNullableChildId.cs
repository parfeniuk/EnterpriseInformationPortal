using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Migrations
{
    public partial class SetNullableChildId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillSettingsInfo_DocumentTemplate_DocumentTemplateId",
                table: "BillSettingsInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_BillSettingsOptionsInfo_DocumentTemplate_DocumentTemplateId",
                table: "BillSettingsOptionsInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_PrintJobInfo_DocumentTemplate_DocumentTemplateId",
                table: "PrintJobInfo");

            migrationBuilder.DropIndex(
                name: "IX_PrintJobInfo_DocumentTemplateId",
                table: "PrintJobInfo");

            migrationBuilder.DropIndex(
                name: "IX_FranchisingInfo_PointNumber",
                table: "FranchisingInfo");

            migrationBuilder.DropIndex(
                name: "IX_DebtControlInfo_PointNumber",
                table: "DebtControlInfo");

            migrationBuilder.DropIndex(
                name: "IX_DebtCalcMethodInfo_PointNumber",
                table: "DebtCalcMethodInfo");

            migrationBuilder.DropIndex(
                name: "IX_ClientConnectionInfo_PointNumber",
                table: "ClientConnectionInfo");

            migrationBuilder.DropIndex(
                name: "IX_BillSettingsOptionsInfo_DocumentTemplateId",
                table: "BillSettingsOptionsInfo");

            migrationBuilder.DropIndex(
                name: "IX_BillSettingsInfo_DocumentTemplateId",
                table: "BillSettingsInfo");

            migrationBuilder.DropIndex(
                name: "IX_BillSettingsInfo_PointNumber",
                table: "BillSettingsInfo");

            migrationBuilder.AlterColumn<int>(
                name: "DocumentTemplateId",
                table: "PrintJobInfo",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "BillSettingsInfoId",
                table: "PrintJobInfo",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "PointNumber",
                table: "FranchisingInfo",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "DocumentTemplateCategoryId",
                table: "DocumentTemplate",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "PointNumber",
                table: "DebtControlInfo",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "PointNumber",
                table: "DebtCalcMethodInfo",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "DebtCalcMethodTypeId",
                table: "DebtCalcMethodInfo",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "PointNumber",
                table: "ContactPhonelInfo",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "PointNumber",
                table: "ContactEmailInfo",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "PointNumber",
                table: "ClientConnectionInfo",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "DocumentTemplateId",
                table: "BillSettingsOptionsInfo",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "BillSettingsInfoId",
                table: "BillSettingsOptionsInfo",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "PointNumber",
                table: "BillSettingsInfo",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "DocumentTemplateId",
                table: "BillSettingsInfo",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_PrintJobInfo_DocumentTemplateId",
                table: "PrintJobInfo",
                column: "DocumentTemplateId",
                unique: true,
                filter: "[DocumentTemplateId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_FranchisingInfo_PointNumber",
                table: "FranchisingInfo",
                column: "PointNumber",
                unique: true,
                filter: "[PointNumber] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DebtControlInfo_PointNumber",
                table: "DebtControlInfo",
                column: "PointNumber",
                unique: true,
                filter: "[PointNumber] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DebtCalcMethodInfo_PointNumber",
                table: "DebtCalcMethodInfo",
                column: "PointNumber",
                unique: true,
                filter: "[PointNumber] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ClientConnectionInfo_PointNumber",
                table: "ClientConnectionInfo",
                column: "PointNumber",
                unique: true,
                filter: "[PointNumber] IS NOT NULL");

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
                name: "IX_BillSettingsInfo_PointNumber",
                table: "BillSettingsInfo",
                column: "PointNumber",
                unique: true,
                filter: "[PointNumber] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_BillSettingsInfo_DocumentTemplate_DocumentTemplateId",
                table: "BillSettingsInfo",
                column: "DocumentTemplateId",
                principalTable: "DocumentTemplate",
                principalColumn: "DocumentTemplateId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BillSettingsOptionsInfo_DocumentTemplate_DocumentTemplateId",
                table: "BillSettingsOptionsInfo",
                column: "DocumentTemplateId",
                principalTable: "DocumentTemplate",
                principalColumn: "DocumentTemplateId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PrintJobInfo_DocumentTemplate_DocumentTemplateId",
                table: "PrintJobInfo",
                column: "DocumentTemplateId",
                principalTable: "DocumentTemplate",
                principalColumn: "DocumentTemplateId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillSettingsInfo_DocumentTemplate_DocumentTemplateId",
                table: "BillSettingsInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_BillSettingsOptionsInfo_DocumentTemplate_DocumentTemplateId",
                table: "BillSettingsOptionsInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_PrintJobInfo_DocumentTemplate_DocumentTemplateId",
                table: "PrintJobInfo");

            migrationBuilder.DropIndex(
                name: "IX_PrintJobInfo_DocumentTemplateId",
                table: "PrintJobInfo");

            migrationBuilder.DropIndex(
                name: "IX_FranchisingInfo_PointNumber",
                table: "FranchisingInfo");

            migrationBuilder.DropIndex(
                name: "IX_DebtControlInfo_PointNumber",
                table: "DebtControlInfo");

            migrationBuilder.DropIndex(
                name: "IX_DebtCalcMethodInfo_PointNumber",
                table: "DebtCalcMethodInfo");

            migrationBuilder.DropIndex(
                name: "IX_ClientConnectionInfo_PointNumber",
                table: "ClientConnectionInfo");

            migrationBuilder.DropIndex(
                name: "IX_BillSettingsOptionsInfo_DocumentTemplateId",
                table: "BillSettingsOptionsInfo");

            migrationBuilder.DropIndex(
                name: "IX_BillSettingsInfo_DocumentTemplateId",
                table: "BillSettingsInfo");

            migrationBuilder.DropIndex(
                name: "IX_BillSettingsInfo_PointNumber",
                table: "BillSettingsInfo");

            migrationBuilder.AlterColumn<int>(
                name: "DocumentTemplateId",
                table: "PrintJobInfo",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BillSettingsInfoId",
                table: "PrintJobInfo",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PointNumber",
                table: "FranchisingInfo",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DocumentTemplateCategoryId",
                table: "DocumentTemplate",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PointNumber",
                table: "DebtControlInfo",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PointNumber",
                table: "DebtCalcMethodInfo",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DebtCalcMethodTypeId",
                table: "DebtCalcMethodInfo",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PointNumber",
                table: "ContactPhonelInfo",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PointNumber",
                table: "ContactEmailInfo",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PointNumber",
                table: "ClientConnectionInfo",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DocumentTemplateId",
                table: "BillSettingsOptionsInfo",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BillSettingsInfoId",
                table: "BillSettingsOptionsInfo",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PointNumber",
                table: "BillSettingsInfo",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DocumentTemplateId",
                table: "BillSettingsInfo",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PrintJobInfo_DocumentTemplateId",
                table: "PrintJobInfo",
                column: "DocumentTemplateId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FranchisingInfo_PointNumber",
                table: "FranchisingInfo",
                column: "PointNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DebtControlInfo_PointNumber",
                table: "DebtControlInfo",
                column: "PointNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DebtCalcMethodInfo_PointNumber",
                table: "DebtCalcMethodInfo",
                column: "PointNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ClientConnectionInfo_PointNumber",
                table: "ClientConnectionInfo",
                column: "PointNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BillSettingsOptionsInfo_DocumentTemplateId",
                table: "BillSettingsOptionsInfo",
                column: "DocumentTemplateId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BillSettingsInfo_DocumentTemplateId",
                table: "BillSettingsInfo",
                column: "DocumentTemplateId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BillSettingsInfo_PointNumber",
                table: "BillSettingsInfo",
                column: "PointNumber",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BillSettingsInfo_DocumentTemplate_DocumentTemplateId",
                table: "BillSettingsInfo",
                column: "DocumentTemplateId",
                principalTable: "DocumentTemplate",
                principalColumn: "DocumentTemplateId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BillSettingsOptionsInfo_DocumentTemplate_DocumentTemplateId",
                table: "BillSettingsOptionsInfo",
                column: "DocumentTemplateId",
                principalTable: "DocumentTemplate",
                principalColumn: "DocumentTemplateId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PrintJobInfo_DocumentTemplate_DocumentTemplateId",
                table: "PrintJobInfo",
                column: "DocumentTemplateId",
                principalTable: "DocumentTemplate",
                principalColumn: "DocumentTemplateId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
