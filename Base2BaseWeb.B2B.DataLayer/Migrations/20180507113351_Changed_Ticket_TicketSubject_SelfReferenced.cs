using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Migrations
{
    public partial class Changed_Ticket_TicketSubject_SelfReferenced : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ParentTicketSubjectId",
                table: "TicketSubject",
                newName: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketSubject_ParentId",
                table: "TicketSubject",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_TicketSubject_TicketSubject_ParentId",
                table: "TicketSubject",
                column: "ParentId",
                principalTable: "TicketSubject",
                principalColumn: "TicketSubjectId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TicketSubject_TicketSubject_ParentId",
                table: "TicketSubject");

            migrationBuilder.DropIndex(
                name: "IX_TicketSubject_ParentId",
                table: "TicketSubject");

            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "TicketSubject",
                newName: "ParentTicketSubjectId");
        }
    }
}
