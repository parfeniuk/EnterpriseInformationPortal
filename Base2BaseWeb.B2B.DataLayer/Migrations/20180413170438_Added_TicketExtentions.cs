using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Migrations
{
    public partial class Added_TicketExtentions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TicketStatus",
                columns: table => new
                {
                    TicketStatusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TicketStatusName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketStatus", x => x.TicketStatusId);
                });

            migrationBuilder.CreateTable(
                name: "TicketSubject",
                columns: table => new
                {
                    TicketSubjectId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TicketSubjectName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketSubject", x => x.TicketSubjectId);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    TicketId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateFinished = table.Column<DateTime>(nullable: true),
                    PointNumber = table.Column<int>(nullable: true),
                    TicketStatusId = table.Column<int>(nullable: true),
                    TicketSubjectId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.TicketId);
                    table.ForeignKey(
                        name: "FK_Ticket_point_PointNumber",
                        column: x => x.PointNumber,
                        principalTable: "point",
                        principalColumn: "point_number",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ticket_TicketStatus_TicketStatusId",
                        column: x => x.TicketStatusId,
                        principalTable: "TicketStatus",
                        principalColumn: "TicketStatusId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ticket_TicketSubject_TicketSubjectId",
                        column: x => x.TicketSubjectId,
                        principalTable: "TicketSubject",
                        principalColumn: "TicketSubjectId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_PointNumber",
                table: "Ticket",
                column: "PointNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_TicketStatusId",
                table: "Ticket",
                column: "TicketStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_TicketSubjectId",
                table: "Ticket",
                column: "TicketSubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketStatus_TicketStatusName",
                table: "TicketStatus",
                column: "TicketStatusName",
                unique: true,
                filter: "[TicketStatusName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TicketSubject_TicketSubjectName",
                table: "TicketSubject",
                column: "TicketSubjectName",
                unique: true,
                filter: "[TicketSubjectName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "TicketStatus");

            migrationBuilder.DropTable(
                name: "TicketSubject");
        }
    }
}
