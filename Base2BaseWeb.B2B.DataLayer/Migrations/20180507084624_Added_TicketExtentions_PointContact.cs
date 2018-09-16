using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Migrations
{
    public partial class Added_TicketExtentions_PointContact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TicketSubjectName",
                table: "TicketSubject",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AddColumn<int>(
                name: "ParentTicketSubjectId",
                table: "TicketSubject",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PointCommunicationTypeId",
                table: "Ticket",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PointContactPersonId",
                table: "Ticket",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Ticket",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "PointCommunicationType",
                columns: table => new
                {
                    PointCommunicationTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PointCommunicationType", x => x.PointCommunicationTypeId);
                });

            migrationBuilder.CreateTable(
                name: "PointContactPersonPositionType",
                columns: table => new
                {
                    PointContactPersonPositionTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PointContactPersonPositionType", x => x.PointContactPersonPositionTypeId);
                });

            migrationBuilder.CreateTable(
                name: "PointContactPerson",
                columns: table => new
                {
                    PointContactPersonId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 100, nullable: true),
                    LastName = table.Column<string>(maxLength: 100, nullable: true),
                    MiddleName = table.Column<string>(maxLength: 100, nullable: true),
                    PointContactPersonPositionTypeId = table.Column<int>(nullable: true),
                    PointNumber = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PointContactPerson", x => x.PointContactPersonId);
                    table.ForeignKey(
                        name: "FK_PointContactPerson_PointContactPersonPositionType_PointContactPersonPositionTypeId",
                        column: x => x.PointContactPersonPositionTypeId,
                        principalTable: "PointContactPersonPositionType",
                        principalColumn: "PointContactPersonPositionTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PointContactPerson_point_PointNumber",
                        column: x => x.PointNumber,
                        principalTable: "point",
                        principalColumn: "point_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PointContactEmail",
                columns: table => new
                {
                    PointContactEmailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(maxLength: 255, nullable: false),
                    PointContactPersonId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PointContactEmail", x => x.PointContactEmailId);
                    table.ForeignKey(
                        name: "FK_PointContactEmail_PointContactPerson_PointContactPersonId",
                        column: x => x.PointContactPersonId,
                        principalTable: "PointContactPerson",
                        principalColumn: "PointContactPersonId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PointContactPhone",
                columns: table => new
                {
                    PointContactPhoneId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Phone = table.Column<string>(maxLength: 50, nullable: false),
                    PointContactPersonId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PointContactPhone", x => x.PointContactPhoneId);
                    table.ForeignKey(
                        name: "FK_PointContactPhone_PointContactPerson_PointContactPersonId",
                        column: x => x.PointContactPersonId,
                        principalTable: "PointContactPerson",
                        principalColumn: "PointContactPersonId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_PointCommunicationTypeId",
                table: "Ticket",
                column: "PointCommunicationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_PointContactPersonId",
                table: "Ticket",
                column: "PointContactPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PointContactEmail_PointContactPersonId",
                table: "PointContactEmail",
                column: "PointContactPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PointContactPerson_PointContactPersonPositionTypeId",
                table: "PointContactPerson",
                column: "PointContactPersonPositionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PointContactPerson_PointNumber",
                table: "PointContactPerson",
                column: "PointNumber");

            migrationBuilder.CreateIndex(
                name: "IX_PointContactPhone_PointContactPersonId",
                table: "PointContactPhone",
                column: "PointContactPersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_PointCommunicationType_PointCommunicationTypeId",
                table: "Ticket",
                column: "PointCommunicationTypeId",
                principalTable: "PointCommunicationType",
                principalColumn: "PointCommunicationTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_PointContactPerson_PointContactPersonId",
                table: "Ticket",
                column: "PointContactPersonId",
                principalTable: "PointContactPerson",
                principalColumn: "PointContactPersonId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_PointCommunicationType_PointCommunicationTypeId",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_PointContactPerson_PointContactPersonId",
                table: "Ticket");

            migrationBuilder.DropTable(
                name: "PointCommunicationType");

            migrationBuilder.DropTable(
                name: "PointContactEmail");

            migrationBuilder.DropTable(
                name: "PointContactPhone");

            migrationBuilder.DropTable(
                name: "PointContactPerson");

            migrationBuilder.DropTable(
                name: "PointContactPersonPositionType");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_PointCommunicationTypeId",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_PointContactPersonId",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "ParentTicketSubjectId",
                table: "TicketSubject");

            migrationBuilder.DropColumn(
                name: "PointCommunicationTypeId",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "PointContactPersonId",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Ticket");

            //migrationBuilder.AlterColumn<string>(
            //    name: "TicketSubjectName",
            //    table: "TicketSubject",
            //    maxLength: 100,
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldMaxLength: 255);
        }
    }
}
