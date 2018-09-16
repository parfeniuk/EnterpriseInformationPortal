using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Migrations
{
    public partial class Added_StoredProcedures_DeletePointChildren : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //// sp_InsertCliGroupName
            //StringBuilder sp_DeletePointChildren = new StringBuilder();
            //sp_DeletePointChildren.Append("Create Procedure sp_DeletePointChildren" + Environment.NewLine);
            //sp_DeletePointChildren.Append("@clientId int" + Environment.NewLine);
            //sp_DeletePointChildren.Append("as" + Environment.NewLine);
            //sp_DeletePointChildren.Append("Begin" + Environment.NewLine);
            //sp_DeletePointChildren.Append("Delete From PointChildren" + Environment.NewLine);
            //sp_DeletePointChildren.Append("Where PointNumber=@clientId" + Environment.NewLine);
            //sp_DeletePointChildren.Append("End" + Environment.NewLine);
            //sp_DeletePointChildren.Append("Go" + Environment.NewLine);

            //migrationBuilder.Sql(sp_DeletePointChildren.ToString());
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.Sql("Drop Procedure sp_DeletePointChildren");
        }
    }
}
