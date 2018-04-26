using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Migrations
{
    public partial class Added_PointChildren_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GroupClient_cli_group_CliGroupNumber",
                table: "GroupClient");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupClient_point_PointNumber",
                table: "GroupClient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GroupClient",
                table: "GroupClient");

            migrationBuilder.RenameTable(
                name: "GroupClient",
                newName: "GroupClients");

            migrationBuilder.RenameIndex(
                name: "IX_GroupClient_CliGroupNumber",
                table: "GroupClients",
                newName: "IX_GroupClients_CliGroupNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GroupClients",
                table: "GroupClients",
                columns: new[] { "PointNumber", "CliGroupNumber" });

            migrationBuilder.CreateTable(
                name: "PointChildren",
                columns: table => new
                {
                    PointChildrenId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Child = table.Column<int>(nullable: false),
                    PointNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PointChildren", x => x.PointChildrenId);
                    table.ForeignKey(
                        name: "FK_PointChildren_point_PointNumber",
                        column: x => x.PointNumber,
                        principalTable: "point",
                        principalColumn: "point_number",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PointChildren_PointNumber_PointChildrenId",
                table: "PointChildren",
                columns: new[] { "PointNumber", "PointChildrenId" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupClients_cli_group_CliGroupNumber",
                table: "GroupClients",
                column: "CliGroupNumber",
                principalTable: "cli_group",
                principalColumn: "cli_group_number",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupClients_point_PointNumber",
                table: "GroupClients",
                column: "PointNumber",
                principalTable: "point",
                principalColumn: "point_number",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GroupClients_cli_group_CliGroupNumber",
                table: "GroupClients");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupClients_point_PointNumber",
                table: "GroupClients");

            migrationBuilder.DropTable(
                name: "PointChildren");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GroupClients",
                table: "GroupClients");

            migrationBuilder.RenameTable(
                name: "GroupClients",
                newName: "GroupClient");

            migrationBuilder.RenameIndex(
                name: "IX_GroupClients_CliGroupNumber",
                table: "GroupClient",
                newName: "IX_GroupClient_CliGroupNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GroupClient",
                table: "GroupClient",
                columns: new[] { "PointNumber", "CliGroupNumber" });

            migrationBuilder.AddForeignKey(
                name: "FK_GroupClient_cli_group_CliGroupNumber",
                table: "GroupClient",
                column: "CliGroupNumber",
                principalTable: "cli_group",
                principalColumn: "cli_group_number",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupClient_point_PointNumber",
                table: "GroupClient",
                column: "PointNumber",
                principalTable: "point",
                principalColumn: "point_number",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
