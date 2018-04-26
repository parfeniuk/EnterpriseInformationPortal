using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Migrations
{
    public partial class Changed_PhoneEmailIndexes_NotUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ContactPhonelInfo_ContactFullName_PhoneNumber",
                table: "ContactPhonelInfo");

            migrationBuilder.DropIndex(
                name: "IX_ContactEmailInfo_Email",
                table: "ContactEmailInfo");

            migrationBuilder.CreateIndex(
                name: "IX_ContactPhonelInfo_ContactFullName_PhoneNumber",
                table: "ContactPhonelInfo",
                columns: new[] { "ContactFullName", "PhoneNumber" });

            migrationBuilder.CreateIndex(
                name: "IX_ContactEmailInfo_Email",
                table: "ContactEmailInfo",
                column: "Email");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ContactPhonelInfo_ContactFullName_PhoneNumber",
                table: "ContactPhonelInfo");

            migrationBuilder.DropIndex(
                name: "IX_ContactEmailInfo_Email",
                table: "ContactEmailInfo");

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
    }
}
