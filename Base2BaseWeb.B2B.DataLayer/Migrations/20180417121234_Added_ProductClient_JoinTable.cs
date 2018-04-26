using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Migrations
{
    public partial class Added_ProductClient_JoinTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductClients",
                columns: table => new
                {
                    PointNumber = table.Column<int>(nullable: false),
                    TovarNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductClients", x => new { x.PointNumber, x.TovarNumber });
                    table.ForeignKey(
                        name: "FK_ProductClients_point_PointNumber",
                        column: x => x.PointNumber,
                        principalTable: "point",
                        principalColumn: "point_number",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductClients_tovar_TovarNumber",
                        column: x => x.TovarNumber,
                        principalTable: "tovar",
                        principalColumn: "tovar_number",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductClients_TovarNumber",
                table: "ProductClients",
                column: "TovarNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductClients");
        }
    }
}
