using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Migrations
{
    public partial class Changed_PhoneEmailFields_AllowNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ContactPhonelInfo_ContactFullName_PhoneNumber",
                table: "ContactPhonelInfo");

            migrationBuilder.DropIndex(
                name: "IX_ContactEmailInfo_Email",
                table: "ContactEmailInfo");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "ContactPhonelInfo",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ContactFullName",
                table: "ContactPhonelInfo",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "ContactEmailInfo",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.CreateIndex(
                name: "IX_ContactPhonelInfo_ContactFullName_PhoneNumber",
                table: "ContactPhonelInfo",
                columns: new[] { "ContactFullName", "PhoneNumber" },
                unique: true,
                filter: "[ContactFullName] IS NOT NULL AND [PhoneNumber] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ContactEmailInfo_Email",
                table: "ContactEmailInfo",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ContactPhonelInfo_ContactFullName_PhoneNumber",
                table: "ContactPhonelInfo");

            migrationBuilder.DropIndex(
                name: "IX_ContactEmailInfo_Email",
                table: "ContactEmailInfo");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "ContactPhonelInfo",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactFullName",
                table: "ContactPhonelInfo",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "ContactEmailInfo",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContactPhonelInfo_ContactFullName_PhoneNumber",
                table: "ContactPhonelInfo",
                columns: new[] { "ContactFullName", "PhoneNumber" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContactEmailInfo_Email",
                table: "ContactEmailInfo",
                column: "Email",
                unique: true);
        }
    }
}
