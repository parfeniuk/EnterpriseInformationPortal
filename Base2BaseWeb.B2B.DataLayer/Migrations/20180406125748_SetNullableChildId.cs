using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Text;

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

            // Update NULL values before changing column type from NULLABLE to NOT NULLABLE
            StringBuilder updateNullPrintJobInfo_DocumentTemplateId = new StringBuilder();
            updateNullPrintJobInfo_DocumentTemplateId.Append("Delete from PrintJobInfo" + Environment.NewLine);
            updateNullPrintJobInfo_DocumentTemplateId.Append("Where DocumentTemplateId is Null" + Environment.NewLine);

            StringBuilder updateNullPrintJobInfo_BillSettingsInfoId = new StringBuilder();
            updateNullPrintJobInfo_BillSettingsInfoId.Append("Delete from PrintJobInfo" + Environment.NewLine);
            updateNullPrintJobInfo_BillSettingsInfoId.Append("Where BillSettingsInfoId is Null" + Environment.NewLine);

            StringBuilder updateNullFranchisingInfo_PointNumber = new StringBuilder();
            updateNullFranchisingInfo_PointNumber.Append("Delete from FranchisingInfo" + Environment.NewLine);
            updateNullFranchisingInfo_PointNumber.Append("Where PointNumber is Null" + Environment.NewLine);

            StringBuilder DocumentTemplate_DocumentTemplateCategoryId = new StringBuilder();
            DocumentTemplate_DocumentTemplateCategoryId.Append("Delete from DocumentTemplate" + Environment.NewLine);
            DocumentTemplate_DocumentTemplateCategoryId.Append("Where DocumentTemplateCategoryId is Null" + Environment.NewLine);

            StringBuilder DebtControlInfo_PointNumber = new StringBuilder();
            DebtControlInfo_PointNumber.Append("Delete from DebtControlInfo" + Environment.NewLine);
            DebtControlInfo_PointNumber.Append("Where PointNumber is Null" + Environment.NewLine);

            StringBuilder DebtCalcMethodInfo_DebtCalcMethodTypeId = new StringBuilder();
            DebtCalcMethodInfo_DebtCalcMethodTypeId.Append("Delete from DebtCalcMethodInfo" + Environment.NewLine);
            DebtCalcMethodInfo_DebtCalcMethodTypeId.Append("Where DebtCalcMethodTypeId is Null" + Environment.NewLine);

            StringBuilder ContactPhonelInfo_PointNumber = new StringBuilder();
            ContactPhonelInfo_PointNumber.Append("Delete from ContactPhonelInfo" + Environment.NewLine);
            ContactPhonelInfo_PointNumber.Append("Where PointNumber is Null" + Environment.NewLine);

            StringBuilder ContactEmailInfo_PointNumber = new StringBuilder();
            ContactEmailInfo_PointNumber.Append("Delete from ContactEmailInfo" + Environment.NewLine);
            ContactEmailInfo_PointNumber.Append("Where PointNumber is Null" + Environment.NewLine);

            StringBuilder ClientConnectionInfo_PointNumber = new StringBuilder();
            ClientConnectionInfo_PointNumber.Append("Delete from ClientConnectionInfo" + Environment.NewLine);
            ClientConnectionInfo_PointNumber.Append("Where PointNumber is Null" + Environment.NewLine);

            StringBuilder BillSettingsOptionsInfo_DocumentTemplateId = new StringBuilder();
            BillSettingsOptionsInfo_DocumentTemplateId.Append("Delete from BillSettingsOptionsInfo" + Environment.NewLine);
            BillSettingsOptionsInfo_DocumentTemplateId.Append("Where DocumentTemplateId is Null" + Environment.NewLine);

            StringBuilder BillSettingsOptionsInfo_BillSettingsInfoId = new StringBuilder();
            BillSettingsOptionsInfo_BillSettingsInfoId.Append("Delete from BillSettingsOptionsInfo" + Environment.NewLine);
            BillSettingsOptionsInfo_BillSettingsInfoId.Append("Where BillSettingsInfoId is Null" + Environment.NewLine);

            StringBuilder BillSettingsInfo_PointNumber = new StringBuilder();
            BillSettingsInfo_PointNumber.Append("Delete from BillSettingsInfo" + Environment.NewLine);
            BillSettingsInfo_PointNumber.Append("Where PointNumber is Null" + Environment.NewLine);

            StringBuilder BillSettingsInfo_DocumentTemplateId = new StringBuilder();
            BillSettingsInfo_DocumentTemplateId.Append("Delete from BillSettingsInfo" + Environment.NewLine);
            BillSettingsInfo_DocumentTemplateId.Append("Where DocumentTemplateId is Null" + Environment.NewLine);

            migrationBuilder.Sql(updateNullPrintJobInfo_DocumentTemplateId.ToString());
            migrationBuilder.Sql(updateNullPrintJobInfo_BillSettingsInfoId.ToString());
            migrationBuilder.Sql(updateNullFranchisingInfo_PointNumber.ToString());
            migrationBuilder.Sql(DocumentTemplate_DocumentTemplateCategoryId.ToString());
            migrationBuilder.Sql(DebtControlInfo_PointNumber.ToString());
            migrationBuilder.Sql(DebtCalcMethodInfo_DebtCalcMethodTypeId.ToString());
            migrationBuilder.Sql(ContactPhonelInfo_PointNumber.ToString());
            migrationBuilder.Sql(ContactEmailInfo_PointNumber.ToString());
            migrationBuilder.Sql(ClientConnectionInfo_PointNumber.ToString());
            migrationBuilder.Sql(BillSettingsOptionsInfo_DocumentTemplateId.ToString());
            migrationBuilder.Sql(BillSettingsOptionsInfo_BillSettingsInfoId.ToString());
            migrationBuilder.Sql(BillSettingsInfo_PointNumber.ToString());
            migrationBuilder.Sql(BillSettingsInfo_DocumentTemplateId.ToString());


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
