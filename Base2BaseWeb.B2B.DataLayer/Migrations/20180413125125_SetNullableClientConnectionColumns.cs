using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Migrations
{
    public partial class SetNullableClientConnectionColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ClientConnectionInfo_ServerName_DatabaseName_Login_PasswordHash",
                table: "ClientConnectionInfo");

            migrationBuilder.AlterColumn<string>(
                name: "ServerName",
                table: "ClientConnectionInfo",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "ClientConnectionInfo",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Login",
                table: "ClientConnectionInfo",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "DatabaseName",
                table: "ClientConnectionInfo",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.CreateIndex(
                name: "IX_ClientConnectionInfo_ServerName_DatabaseName_Login_PasswordHash",
                table: "ClientConnectionInfo",
                columns: new[] { "ServerName", "DatabaseName", "Login", "PasswordHash" },
                unique: true,
                filter: "[ServerName] IS NOT NULL AND [DatabaseName] IS NOT NULL AND [Login] IS NOT NULL AND [PasswordHash] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ClientConnectionInfo_ServerName_DatabaseName_Login_PasswordHash",
                table: "ClientConnectionInfo");

            migrationBuilder.AlterColumn<string>(
                name: "ServerName",
                table: "ClientConnectionInfo",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "ClientConnectionInfo",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Login",
                table: "ClientConnectionInfo",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DatabaseName",
                table: "ClientConnectionInfo",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ClientConnectionInfo_ServerName_DatabaseName_Login_PasswordHash",
                table: "ClientConnectionInfo",
                columns: new[] { "ServerName", "DatabaseName", "Login", "PasswordHash" },
                unique: true);
        }
    }
}
