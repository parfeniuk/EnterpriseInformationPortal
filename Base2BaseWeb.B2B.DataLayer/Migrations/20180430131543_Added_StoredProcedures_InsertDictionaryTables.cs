using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Migrations
{
    public partial class Added_StoredProcedures_InsertDictionaryTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            StringBuilder insertCommand = new StringBuilder();
            // Initialize FranchisingType values
            insertCommand.Append("if not exists(select 1 from FranchisingType)" + Environment.NewLine);
            insertCommand.Append("SET IDENTITY_INSERT FranchisingType ON" + Environment.NewLine);
            insertCommand.Append("Insert Into FranchisingType(FranchisingTypeId,Name)" + Environment.NewLine);
            insertCommand.Append("Values(1,'Франчайзер (держатель франшизы)')" + Environment.NewLine);
            insertCommand.Append("Insert Into FranchisingType(FranchisingTypeId,Name)" + Environment.NewLine);
            insertCommand.Append("Values(2,'Франчайзи (пользователь франшизы)')" + Environment.NewLine);
            insertCommand.Append("SET IDENTITY_INSERT FranchisingType OFF" + Environment.NewLine);
            insertCommand.Append("Go" + Environment.NewLine);
            migrationBuilder.Sql(insertCommand.ToString());
            insertCommand.Clear();
            // Initialize DebtCalcMethodType values
            insertCommand.Append("if not exists(select 1 from DebtCalcMethodType)" + Environment.NewLine);
            insertCommand.Append("SET IDENTITY_INSERT DebtCalcMethodType ON" + Environment.NewLine);
            insertCommand.Append("Insert Into DebtCalcMethodType(DebtCalcMethodTypeId,Active,Name)" + Environment.NewLine);
            insertCommand.Append("Values(1,1,'Расчет по отработанным дням')" + Environment.NewLine);
            insertCommand.Append("Insert Into DebtCalcMethodType(DebtCalcMethodTypeId,Active,Name)" + Environment.NewLine);
            insertCommand.Append("Values(2,1,'Расчет по месяцам')" + Environment.NewLine);
            insertCommand.Append("SET IDENTITY_INSERT DebtCalcMethodType OFF" + Environment.NewLine);
            insertCommand.Append("Go" + Environment.NewLine);
            migrationBuilder.Sql(insertCommand.ToString());
            insertCommand.Clear();
            // Initialize DocumentTemplateCategory values
            insertCommand.Append("if not exists(select 1 from DocumentTemplateCategory)" + Environment.NewLine);
            insertCommand.Append("SET IDENTITY_INSERT DocumentTemplateCategory ON" + Environment.NewLine);
            insertCommand.Append("Insert Into DocumentTemplateCategory(DocumentTemplateCategoryId,Name)" + Environment.NewLine);
            insertCommand.Append("Values(1,'Акты')" + Environment.NewLine);
            insertCommand.Append("Insert Into DocumentTemplateCategory(DocumentTemplateCategoryId,Name)" + Environment.NewLine);
            insertCommand.Append("Values(2,'Счета')" + Environment.NewLine);
            insertCommand.Append("SET IDENTITY_INSERT DocumentTemplateCategory OFF" + Environment.NewLine);
            insertCommand.Append("Go" + Environment.NewLine);
            migrationBuilder.Sql(insertCommand.ToString());
            insertCommand.Clear();
            // Initialize DocumentTemplate values
            insertCommand.Append("if not exists(select 1 from DocumentTemplate)" + Environment.NewLine);
            insertCommand.Append("SET IDENTITY_INSERT DocumentTemplate ON" + Environment.NewLine);
            insertCommand.Append("Insert Into DocumentTemplate(DocumentTemplateId,DocumentTemplateCategoryId,Name)" + Environment.NewLine);
            insertCommand.Append("Values(1,2,'Счет Б2Б (Печать).xml')" + Environment.NewLine);
            insertCommand.Append("Insert Into DocumentTemplate(DocumentTemplateId,DocumentTemplateCategoryId,Name)" + Environment.NewLine);
            insertCommand.Append("Values(2,2,'Счет Б2Б.xml')" + Environment.NewLine);
            insertCommand.Append("Insert Into DocumentTemplate(DocumentTemplateId,DocumentTemplateCategoryId,Name)" + Environment.NewLine);
            insertCommand.Append("Values(3,1,'Акт Б2Б.xml')" + Environment.NewLine);
            insertCommand.Append("SET IDENTITY_INSERT DocumentTemplate OFF" + Environment.NewLine);
            insertCommand.Append("Go" + Environment.NewLine);
            migrationBuilder.Sql(insertCommand.ToString());
            insertCommand.Clear();
            // Initialize ServicePlaceholderType values
            insertCommand.Append("if not exists(select 1 from ServicePlaceholderType)" + Environment.NewLine);
            insertCommand.Append("SET IDENTITY_INSERT ServicePlaceholderType ON" + Environment.NewLine);
            insertCommand.Append("Insert Into ServicePlaceholderType(ServicePlaceholderTypeId,Name)" + Environment.NewLine);
            insertCommand.Append("Values(1,'Оброблення даних.....')" + Environment.NewLine);
            insertCommand.Append("SET IDENTITY_INSERT ServicePlaceholderType OFF" + Environment.NewLine);
            insertCommand.Append("Go" + Environment.NewLine);
            migrationBuilder.Sql(insertCommand.ToString());
            insertCommand.Clear();
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
