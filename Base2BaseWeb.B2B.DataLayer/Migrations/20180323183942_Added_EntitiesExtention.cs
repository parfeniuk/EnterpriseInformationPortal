using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Migrations
{
    public partial class Added_EntitiesExtention : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            ///* Added cli_group_number with 0 value */
            //StringBuilder insertCliGroup = new StringBuilder();
            //insertCliGroup.Append("SET IDENTITY_INSERT cli_group ON" + Environment.NewLine);
            //insertCliGroup.Append("insert into cli_group (cli_group_number,cli_group_name,post)" + Environment.NewLine);
            //insertCliGroup.Append("values(0,'Бэйстубейс',1)" + Environment.NewLine);
            //insertCliGroup.Append("SET IDENTITY_INSERT cli_group OFF" + Environment.NewLine);
            //migrationBuilder.Sql(insertCliGroup.ToString());

            ///* Added Foreign Key Constraint on Point */
            //StringBuilder FK_Constraint = new StringBuilder();
            //FK_Constraint.Append("ALTER TABLE [dbo].[point]  WITH CHECK" + Environment.NewLine);
            //FK_Constraint.Append("ADD  CONSTRAINT [FK_point_cli_group_cli_group_number]" + Environment.NewLine);
            //FK_Constraint.Append("FOREIGN KEY([cli_group_number])" + Environment.NewLine);
            //FK_Constraint.Append("REFERENCES [dbo].[cli_group] ([cli_group_number])" + Environment.NewLine);
            //migrationBuilder.Sql(FK_Constraint.ToString());

            ///* Added Check Constraint on Point */
            //StringBuilder Check_Constraint = new StringBuilder();
            //Check_Constraint.Append("ALTER TABLE [dbo].[point]" + Environment.NewLine);
            //Check_Constraint.Append("CHECK CONSTRAINT [FK_point_cli_group_cli_group_number]" + Environment.NewLine);
            //migrationBuilder.Sql(Check_Constraint.ToString());

            migrationBuilder.CreateTable(
                name: "ClientConnectionInfo",
                columns: table => new
                {
                    ClientConnectionInfoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DatabaseName = table.Column<string>(maxLength: 100, nullable: false),
                    Login = table.Column<string>(maxLength: 50, nullable: false),
                    PasswordHash = table.Column<string>(maxLength: 100, nullable: false),
                    PointNumber = table.Column<int>(nullable: false),
                    ServerName = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientConnectionInfo", x => x.ClientConnectionInfoId);
                    table.ForeignKey(
                        name: "FK_ClientConnectionInfo_point_PointNumber",
                        column: x => x.PointNumber,
                        principalTable: "point",
                        principalColumn: "point_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContactEmailInfo",
                columns: table => new
                {
                    ContactEmailInfoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(maxLength: 100, nullable: false),
                    IncludeToMailList = table.Column<bool>(nullable: false),
                    PointNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactEmailInfo", x => x.ContactEmailInfoId);
                    table.ForeignKey(
                        name: "FK_ContactEmailInfo_point_PointNumber",
                        column: x => x.PointNumber,
                        principalTable: "point",
                        principalColumn: "point_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContactPhonelInfo",
                columns: table => new
                {
                    ContactPhoneInfoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContactFullName = table.Column<string>(maxLength: 200, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 50, nullable: false),
                    PointNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactPhonelInfo", x => x.ContactPhoneInfoId);
                    table.ForeignKey(
                        name: "FK_ContactPhonelInfo_point_PointNumber",
                        column: x => x.PointNumber,
                        principalTable: "point",
                        principalColumn: "point_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DebtCalcMethodInfo",
                columns: table => new
                {
                    DebtCalcMethodInfoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    PointNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DebtCalcMethodInfo", x => x.DebtCalcMethodInfoId);
                    table.ForeignKey(
                        name: "FK_DebtCalcMethodInfo_point_PointNumber",
                        column: x => x.PointNumber,
                        principalTable: "point",
                        principalColumn: "point_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DebtControlInfo",
                columns: table => new
                {
                    DebtControlInfoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DebtLimit = table.Column<double>(nullable: false),
                    GracePeriod = table.Column<int>(nullable: false),
                    NotificationFrequency = table.Column<int>(nullable: false),
                    NotifyByEmail = table.Column<bool>(nullable: false),
                    NotifyBySms = table.Column<bool>(nullable: false),
                    NotifyByViber = table.Column<bool>(nullable: false),
                    PointNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DebtControlInfo", x => x.DebtControlInfoId);
                    table.ForeignKey(
                        name: "FK_DebtControlInfo_point_PointNumber",
                        column: x => x.PointNumber,
                        principalTable: "point",
                        principalColumn: "point_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DocumentTemplateCategory",
                columns: table => new
                {
                    DocumentTemplateCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentTemplateCategory", x => x.DocumentTemplateCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "FranchisingInfo",
                columns: table => new
                {
                    FranchisingInfoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsFranchisee = table.Column<bool>(nullable: false),
                    IsFranchisor = table.Column<bool>(nullable: false),
                    PointNumber = table.Column<int>(nullable: false),
                    UseFranchising = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FranchisingInfo", x => x.FranchisingInfoId);
                    table.ForeignKey(
                        name: "FK_FranchisingInfo_point_PointNumber",
                        column: x => x.PointNumber,
                        principalTable: "point",
                        principalColumn: "point_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DocumentTemplate",
                columns: table => new
                {
                    DocumentTemplateId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DocumentTemplateCategoryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentTemplate", x => x.DocumentTemplateId);
                    table.ForeignKey(
                        name: "FK_DocumentTemplate_DocumentTemplateCategory_DocumentTemplateCategoryId",
                        column: x => x.DocumentTemplateCategoryId,
                        principalTable: "DocumentTemplateCategory",
                        principalColumn: "DocumentTemplateCategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BillSettingsInfo",
                columns: table => new
                {
                    BillSettingsInfoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AutomaticBilling = table.Column<bool>(nullable: false),
                    DocumentTemplateId = table.Column<int>(nullable: false),
                    PointNumber = table.Column<int>(nullable: false),
                    ReplaceServiceList = table.Column<bool>(nullable: false),
                    SendByEmail = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillSettingsInfo", x => x.BillSettingsInfoId);
                    table.ForeignKey(
                        name: "FK_BillSettingsInfo_DocumentTemplate_DocumentTemplateId",
                        column: x => x.DocumentTemplateId,
                        principalTable: "DocumentTemplate",
                        principalColumn: "DocumentTemplateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BillSettingsInfo_point_PointNumber",
                        column: x => x.PointNumber,
                        principalTable: "point",
                        principalColumn: "point_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BillSettingsOptionsInfo",
                columns: table => new
                {
                    BillSettingsOptionsInfoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BillSettingsInfoId = table.Column<int>(nullable: false),
                    DocumentTemplateId = table.Column<int>(nullable: false),
                    Limit = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillSettingsOptionsInfo", x => x.BillSettingsOptionsInfoId);
                    table.ForeignKey(
                        name: "FK_BillSettingsOptionsInfo_BillSettingsInfo_BillSettingsInfoId",
                        column: x => x.BillSettingsInfoId,
                        principalTable: "BillSettingsInfo",
                        principalColumn: "BillSettingsInfoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BillSettingsOptionsInfo_DocumentTemplate_DocumentTemplateId",
                        column: x => x.DocumentTemplateId,
                        principalTable: "DocumentTemplate",
                        principalColumn: "DocumentTemplateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrintJobInfo",
                columns: table => new
                {
                    PrintJobInfoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BillSettingsInfoId = table.Column<int>(nullable: false),
                    DocumentTemplateId = table.Column<int>(nullable: false),
                    DocumentToPrintCopies = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrintJobInfo", x => x.PrintJobInfoId);
                    table.ForeignKey(
                        name: "FK_PrintJobInfo_BillSettingsInfo_BillSettingsInfoId",
                        column: x => x.BillSettingsInfoId,
                        principalTable: "BillSettingsInfo",
                        principalColumn: "BillSettingsInfoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PrintJobInfo_DocumentTemplate_DocumentTemplateId",
                        column: x => x.DocumentTemplateId,
                        principalTable: "DocumentTemplate",
                        principalColumn: "DocumentTemplateId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_BillSettingsOptionsInfo_BillSettingsInfoId",
                table: "BillSettingsOptionsInfo",
                column: "BillSettingsInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_BillSettingsOptionsInfo_DocumentTemplateId",
                table: "BillSettingsOptionsInfo",
                column: "DocumentTemplateId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ClientConnectionInfo_PointNumber",
                table: "ClientConnectionInfo",
                column: "PointNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ClientConnectionInfo_ServerName_DatabaseName_Login_PasswordHash",
                table: "ClientConnectionInfo",
                columns: new[] { "ServerName", "DatabaseName", "Login", "PasswordHash" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContactEmailInfo_Email",
                table: "ContactEmailInfo",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContactEmailInfo_PointNumber",
                table: "ContactEmailInfo",
                column: "PointNumber");

            migrationBuilder.CreateIndex(
                name: "IX_ContactPhonelInfo_PointNumber",
                table: "ContactPhonelInfo",
                column: "PointNumber");

            migrationBuilder.CreateIndex(
                name: "IX_ContactPhonelInfo_ContactFullName_PhoneNumber",
                table: "ContactPhonelInfo",
                columns: new[] { "ContactFullName", "PhoneNumber" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DebtCalcMethodInfo_Name",
                table: "DebtCalcMethodInfo",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DebtCalcMethodInfo_PointNumber",
                table: "DebtCalcMethodInfo",
                column: "PointNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DebtControlInfo_PointNumber",
                table: "DebtControlInfo",
                column: "PointNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DocumentTemplate_DocumentTemplateCategoryId",
                table: "DocumentTemplate",
                column: "DocumentTemplateCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentTemplate_Name",
                table: "DocumentTemplate",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DocumentTemplateCategory_Name",
                table: "DocumentTemplateCategory",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FranchisingInfo_PointNumber",
                table: "FranchisingInfo",
                column: "PointNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PrintJobInfo_BillSettingsInfoId",
                table: "PrintJobInfo",
                column: "BillSettingsInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_PrintJobInfo_DocumentTemplateId",
                table: "PrintJobInfo",
                column: "DocumentTemplateId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            ///* Added cli_group_number with 0 value */
            //StringBuilder deleteCliGroup = new StringBuilder();
            //deleteCliGroup.Append("delete from cli_group" + Environment.NewLine);
            //deleteCliGroup.Append("where cli_group_number=0" + Environment.NewLine);
            //migrationBuilder.Sql(deleteCliGroup.ToString());

            ///* Added Foreign Key Constraint on Point */
            //StringBuilder FK_Constraint = new StringBuilder();
            //FK_Constraint.Append("ALTER TABLE [dbo].[point]" + Environment.NewLine);
            //FK_Constraint.Append("DROP  CONSTRAINT [FK_point_cli_group_cli_group_number]" + Environment.NewLine);
            //migrationBuilder.Sql(FK_Constraint.ToString());

            migrationBuilder.DropTable(
                name: "BillSettingsOptionsInfo");

            migrationBuilder.DropTable(
                name: "ClientConnectionInfo");

            migrationBuilder.DropTable(
                name: "ContactEmailInfo");

            migrationBuilder.DropTable(
                name: "ContactPhonelInfo");

            migrationBuilder.DropTable(
                name: "DebtCalcMethodInfo");

            migrationBuilder.DropTable(
                name: "DebtControlInfo");

            migrationBuilder.DropTable(
                name: "FranchisingInfo");

            migrationBuilder.DropTable(
                name: "PrintJobInfo");

            migrationBuilder.DropTable(
                name: "BillSettingsInfo");

            migrationBuilder.DropTable(
                name: "DocumentTemplate");

            migrationBuilder.DropTable(
                name: "DocumentTemplateCategory");
        }
    }
}
