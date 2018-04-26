using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Migrations
{
    public partial class Added_StoredProcedures_SelectGroupClientsCount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // sp_InsertCliGroupName
            StringBuilder sp_SelectGroupClientsCount = new StringBuilder();
            sp_SelectGroupClientsCount.Append("Create Procedure sp_SelectGroupClientsCount" + Environment.NewLine);
            sp_SelectGroupClientsCount.Append("@clientId int" + Environment.NewLine);
            sp_SelectGroupClientsCount.Append("as" + Environment.NewLine);
            sp_SelectGroupClientsCount.Append("Begin" + Environment.NewLine);
            sp_SelectGroupClientsCount.Append("Select Count(*) From GroupClients" + Environment.NewLine);
            sp_SelectGroupClientsCount.Append("Where PointNumber=@clientId" + Environment.NewLine);
            sp_SelectGroupClientsCount.Append("End" + Environment.NewLine);
            sp_SelectGroupClientsCount.Append("Go" + Environment.NewLine);

            migrationBuilder.Sql(sp_SelectGroupClientsCount.ToString());
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Drop Procedure sp_SelectGroupClientsCount");
        }
    }
}
