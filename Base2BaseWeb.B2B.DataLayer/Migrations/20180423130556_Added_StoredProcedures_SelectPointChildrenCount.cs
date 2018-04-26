using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Migrations
{
    public partial class Added_StoredProcedures_SelectPointChildrenCount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // sp_InsertCliGroupName
            StringBuilder sp_SelectPointChildrenCount = new StringBuilder();
            sp_SelectPointChildrenCount.Append("Create Procedure sp_SelectPointChildrenCount" + Environment.NewLine);
            sp_SelectPointChildrenCount.Append("@clientId int" + Environment.NewLine);
            sp_SelectPointChildrenCount.Append("as" + Environment.NewLine);
            sp_SelectPointChildrenCount.Append("Begin" + Environment.NewLine);
            sp_SelectPointChildrenCount.Append("Select Count(*) From PointChildren" + Environment.NewLine);
            sp_SelectPointChildrenCount.Append("Where PointNumber=@clientId" + Environment.NewLine);
            sp_SelectPointChildrenCount.Append("End" + Environment.NewLine);
            sp_SelectPointChildrenCount.Append("Go" + Environment.NewLine);

            migrationBuilder.Sql(sp_SelectPointChildrenCount.ToString());
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Drop Procedure sp_SelectPointChildrenCount");
        }
    }
}
