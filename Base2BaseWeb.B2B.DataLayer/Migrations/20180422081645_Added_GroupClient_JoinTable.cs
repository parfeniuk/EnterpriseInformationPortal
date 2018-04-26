using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Migrations
{
    public partial class Added_GroupClient_JoinTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GroupClient",
                columns: table => new
                {
                    PointNumber = table.Column<int>(nullable: false),
                    CliGroupNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupClient", x => new { x.PointNumber, x.CliGroupNumber });
                    table.ForeignKey(
                        name: "FK_GroupClient_cli_group_CliGroupNumber",
                        column: x => x.CliGroupNumber,
                        principalTable: "cli_group",
                        principalColumn: "cli_group_number",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupClient_point_PointNumber",
                        column: x => x.PointNumber,
                        principalTable: "point",
                        principalColumn: "point_number",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GroupClient_CliGroupNumber",
                table: "GroupClient",
                column: "CliGroupNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupClient");
        }
    }
}
