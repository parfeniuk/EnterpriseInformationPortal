using Microsoft.EntityFrameworkCore.Migrations;
using System.Text;
using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Migrations
{
    public partial class Added_StoredProcedures_InsertClientGroups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // sp_InsertCliGroupName
            StringBuilder sp_InsertCliGroupName = new StringBuilder();
            sp_InsertCliGroupName.Append("Create Procedure sp_InsertCliGroupName" + Environment.NewLine);
            sp_InsertCliGroupName.Append("@name nvarchar(256)" + Environment.NewLine);
            sp_InsertCliGroupName.Append("as" + Environment.NewLine);
            sp_InsertCliGroupName.Append("Begin" + Environment.NewLine);
            sp_InsertCliGroupName.Append("Insert Into cli_group(cli_group_name)" + Environment.NewLine);
            sp_InsertCliGroupName.Append("Values(@name)" + Environment.NewLine);
            sp_InsertCliGroupName.Append("Select SCOPE_IDENTITY()" + Environment.NewLine);
            sp_InsertCliGroupName.Append("End" + Environment.NewLine);
            sp_InsertCliGroupName.Append("Go" + Environment.NewLine);
            // sp_InsertCliGroupName
            StringBuilder sp_InsertGroupClients = new StringBuilder();
            sp_InsertGroupClients.Append("Create Procedure sp_InsertGroupClients" + Environment.NewLine);
            sp_InsertGroupClients.Append("@groupId int, @clientId int" + Environment.NewLine);
            sp_InsertGroupClients.Append("as" + Environment.NewLine);
            sp_InsertGroupClients.Append("Begin" + Environment.NewLine);
            sp_InsertGroupClients.Append("Insert Into GroupClients (CliGroupNumber,PointNumber)" + Environment.NewLine);
            sp_InsertGroupClients.Append("Values (@groupId,@clientId)" + Environment.NewLine);
            sp_InsertGroupClients.Append("End" + Environment.NewLine);
            sp_InsertGroupClients.Append("Go" + Environment.NewLine);
            // sp_InsertCliGroupName
            StringBuilder sp_InsertPointChildren = new StringBuilder();
            sp_InsertPointChildren.Append("Create Procedure sp_InsertPointChildren" + Environment.NewLine);
            sp_InsertPointChildren.Append("@clientId int,@childId int,@childName nvarchar(256)" + Environment.NewLine);
            sp_InsertPointChildren.Append("as" + Environment.NewLine);
            sp_InsertPointChildren.Append("Begin" + Environment.NewLine);
            sp_InsertPointChildren.Append("Insert Into PointChildren(PointNumber,ChildId,ChildName)" + Environment.NewLine);
            sp_InsertPointChildren.Append("Values(@clientId,@childId,@childName)" + Environment.NewLine);
            sp_InsertPointChildren.Append("End" + Environment.NewLine);
            sp_InsertPointChildren.Append("Go" + Environment.NewLine);

            migrationBuilder.Sql(sp_InsertCliGroupName.ToString());
            migrationBuilder.Sql(sp_InsertGroupClients.ToString());
            migrationBuilder.Sql(sp_InsertPointChildren.ToString());
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Drop Procedure sp_InsertCliGroupName");
            migrationBuilder.Sql("Drop Procedure sp_InsertGroupClients");
            migrationBuilder.Sql("Drop Procedure sp_InsertPointChildren");
        }
    }
}
