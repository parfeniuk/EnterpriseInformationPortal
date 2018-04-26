using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Migrations
{
    public partial class Added_TicketExtentions_RequiredColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TicketSubject_TicketSubjectName",
                table: "TicketSubject");

            migrationBuilder.DropIndex(
                name: "IX_TicketStatus_TicketStatusName",
                table: "TicketStatus");

            migrationBuilder.AlterColumn<string>(
                name: "TicketSubjectName",
                table: "TicketSubject",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TicketStatusName",
                table: "TicketStatus",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TicketSubject_TicketSubjectName",
                table: "TicketSubject",
                column: "TicketSubjectName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TicketStatus_TicketStatusName",
                table: "TicketStatus",
                column: "TicketStatusName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TicketSubject_TicketSubjectName",
                table: "TicketSubject");

            migrationBuilder.DropIndex(
                name: "IX_TicketStatus_TicketStatusName",
                table: "TicketStatus");

            migrationBuilder.AlterColumn<string>(
                name: "TicketSubjectName",
                table: "TicketSubject",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "TicketStatusName",
                table: "TicketStatus",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.CreateIndex(
                name: "IX_TicketSubject_TicketSubjectName",
                table: "TicketSubject",
                column: "TicketSubjectName",
                unique: true,
                filter: "[TicketSubjectName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TicketStatus_TicketStatusName",
                table: "TicketStatus",
                column: "TicketStatusName",
                unique: true,
                filter: "[TicketStatusName] IS NOT NULL");
        }
    }
}
