using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Migrations
{
    public partial class Added_StoredProcedures_UpsertPointChild : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // sp_InsertCliGroupName
            StringBuilder sp_InsertCliGroupName = new StringBuilder();
            sp_InsertCliGroupName.Append("Create Procedure sp_InsertCliGroupName" + Environment.NewLine);
            sp_InsertCliGroupName.Append("@name nvarchar(256),@pointNumber int" + Environment.NewLine);
            sp_InsertCliGroupName.Append("as" + Environment.NewLine);
            sp_InsertCliGroupName.Append("Begin" + Environment.NewLine);
            sp_InsertCliGroupName.Append("Insert Into cli_group(cli_group_name,post,PointNumber)" + Environment.NewLine);
            sp_InsertCliGroupName.Append("Values(@name,0,@pointNumber)" + Environment.NewLine);
            sp_InsertCliGroupName.Append("Select CAST(SCOPE_IDENTITY() as int)" + Environment.NewLine);
            sp_InsertCliGroupName.Append("End" + Environment.NewLine);
            sp_InsertCliGroupName.Append("Go" + Environment.NewLine);

            // sp_IsCliGroupExists
            StringBuilder sp_IsCliGroupExists = new StringBuilder();
            sp_IsCliGroupExists.Append("Create Procedure sp_IsCliGroupExists" + Environment.NewLine);
            sp_IsCliGroupExists.Append("@pointNumber int" + Environment.NewLine);
            sp_IsCliGroupExists.Append("as" + Environment.NewLine);
            sp_IsCliGroupExists.Append("Begin" + Environment.NewLine);
            sp_IsCliGroupExists.Append("select case when exists(select 1" + Environment.NewLine);
            sp_IsCliGroupExists.Append("from cli_group where PointNumber=@pointNumber and post=0)" + Environment.NewLine);
            sp_IsCliGroupExists.Append("then cast(1 as bit)" + Environment.NewLine);
            sp_IsCliGroupExists.Append("else cast(0 as bit)" + Environment.NewLine);
            sp_IsCliGroupExists.Append("End" + Environment.NewLine);
            sp_IsCliGroupExists.Append("End" + Environment.NewLine);
            sp_IsCliGroupExists.Append("Go" + Environment.NewLine);

            // sp_GetCliPointChildGroupId
            StringBuilder sp_GetCliPointChildGroupId = new StringBuilder();
            sp_GetCliPointChildGroupId.Append("Create Procedure sp_GetCliPointChildGroupId" + Environment.NewLine);
            sp_GetCliPointChildGroupId.Append("@pointNumber int" + Environment.NewLine);
            sp_GetCliPointChildGroupId.Append("as" + Environment.NewLine);
            sp_GetCliPointChildGroupId.Append("Begin" + Environment.NewLine);
            sp_GetCliPointChildGroupId.Append("select top 1 cli_group_number" + Environment.NewLine);
            sp_GetCliPointChildGroupId.Append("from cli_group" + Environment.NewLine);
            sp_GetCliPointChildGroupId.Append("where PointNumber=@pointNumber and post=0" + Environment.NewLine);
            sp_GetCliPointChildGroupId.Append("End" + Environment.NewLine);
            sp_GetCliPointChildGroupId.Append("Go" + Environment.NewLine);

            // sp_PointHasChild
            StringBuilder sp_PointHasChild = new StringBuilder();
            sp_PointHasChild.Append("Create Procedure sp_PointHasChild" + Environment.NewLine);
            sp_PointHasChild.Append("@cliGroupNumber int, @childId int" + Environment.NewLine);
            sp_PointHasChild.Append("as" + Environment.NewLine);
            sp_PointHasChild.Append("Begin" + Environment.NewLine);
            sp_PointHasChild.Append("select case when exists(select 1" + Environment.NewLine);
            sp_PointHasChild.Append("from point where cli_group_number=@cliGroupNumber" + Environment.NewLine);
            sp_PointHasChild.Append("and ChildId=@childId and post=0)" + Environment.NewLine);
            sp_PointHasChild.Append("then cast(1 as bit)" + Environment.NewLine);
            sp_PointHasChild.Append("else cast(0 as bit)" + Environment.NewLine);
            sp_PointHasChild.Append("End" + Environment.NewLine);
            sp_PointHasChild.Append("End" + Environment.NewLine);
            sp_PointHasChild.Append("Go" + Environment.NewLine);

            // sp_InsertPointChild
            StringBuilder sp_InsertPointChild = new StringBuilder();
            sp_InsertPointChild.Append("Create Procedure sp_InsertPointChild" + Environment.NewLine);
            sp_InsertPointChild.Append("@cliGroupNumber int, @childId int, @childName nvarchar(255)" + Environment.NewLine);
            sp_InsertPointChild.Append("as" + Environment.NewLine);
            sp_InsertPointChild.Append("Begin" + Environment.NewLine);
            sp_InsertPointChild.Append("Insert Into point(cli_group_number,ChildId,name_point,post)" + Environment.NewLine);
            sp_InsertPointChild.Append("Values(@cliGroupNumber,@childId,@childName,0)" + Environment.NewLine);
            sp_InsertPointChild.Append("End" + Environment.NewLine);
            sp_InsertPointChild.Append("Go" + Environment.NewLine);

            // sp_InsertPointChild
            StringBuilder sp_UpdatePointChild = new StringBuilder();
            sp_UpdatePointChild.Append("Create Procedure sp_UpdatePointChild" + Environment.NewLine);
            sp_UpdatePointChild.Append("@cliGroupNumber int, @childId int, @childName nvarchar(255)" + Environment.NewLine);
            sp_UpdatePointChild.Append("as" + Environment.NewLine);
            sp_UpdatePointChild.Append("Begin" + Environment.NewLine);
            sp_UpdatePointChild.Append("Update point Set name_point=@childName" + Environment.NewLine);
            sp_UpdatePointChild.Append("Where cli_group_number=@cliGroupNumber and ChildId=@childId" + Environment.NewLine);
            sp_UpdatePointChild.Append("End" + Environment.NewLine);
            sp_UpdatePointChild.Append("Go" + Environment.NewLine);

            // sp_InsertPointChild
            StringBuilder sp_InsertPointChildStore = new StringBuilder();
            sp_InsertPointChildStore.Append("Create Procedure sp_InsertPointChildStore" + Environment.NewLine);
            sp_InsertPointChildStore.Append("@cliGroupNumber int, @pointName nvarchar(255)" + Environment.NewLine);
            sp_InsertPointChildStore.Append("as" + Environment.NewLine);
            sp_InsertPointChildStore.Append("Begin" + Environment.NewLine);
            sp_InsertPointChildStore.Append("Insert Into point(cli_group_number,ChildId,name_point,post)" + Environment.NewLine);
            sp_InsertPointChildStore.Append("Values(@cliGroupNumber,0,'Склад - '+@pointName,0)" + Environment.NewLine);
            sp_InsertPointChildStore.Append("End" + Environment.NewLine);
            sp_InsertPointChildStore.Append("Go" + Environment.NewLine);

            migrationBuilder.Sql(sp_InsertCliGroupName.ToString());
            migrationBuilder.Sql(sp_IsCliGroupExists.ToString());
            migrationBuilder.Sql(sp_GetCliPointChildGroupId.ToString());
            migrationBuilder.Sql(sp_PointHasChild.ToString());
            migrationBuilder.Sql(sp_InsertPointChild.ToString());
            migrationBuilder.Sql(sp_UpdatePointChild.ToString());
            migrationBuilder.Sql(sp_InsertPointChildStore.ToString());
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            StringBuilder sp_InsertCliGroupName = new StringBuilder();
            sp_InsertCliGroupName.Append("IF (OBJECT_ID('sp_InsertCliGroupName', 'P') IS NOT NULL)" + Environment.NewLine);
            sp_InsertCliGroupName.Append("Drop Procedure sp_InsertCliGroupName" + Environment.NewLine);

            StringBuilder sp_IsCliGroupExists = new StringBuilder();
            sp_IsCliGroupExists.Append("IF (OBJECT_ID('sp_IsCliGroupExists', 'P') IS NOT NULL)" + Environment.NewLine);
            sp_IsCliGroupExists.Append("Drop Procedure sp_IsCliGroupExists" + Environment.NewLine);

            StringBuilder sp_GetCliPointChildGroupId = new StringBuilder();
            sp_GetCliPointChildGroupId.Append("IF (OBJECT_ID('sp_GetCliPointChildGroupId', 'P') IS NOT NULL)" + Environment.NewLine);
            sp_GetCliPointChildGroupId.Append("Drop Procedure sp_GetCliPointChildGroupId" + Environment.NewLine);

            StringBuilder sp_PointHasChild = new StringBuilder();
            sp_PointHasChild.Append("IF (OBJECT_ID('sp_PointHasChild', 'P') IS NOT NULL)" + Environment.NewLine);
            sp_PointHasChild.Append("Drop Procedure sp_PointHasChild" + Environment.NewLine);

            StringBuilder sp_InsertPointChild = new StringBuilder();
            sp_InsertPointChild.Append("IF (OBJECT_ID('sp_InsertPointChild', 'P') IS NOT NULL)" + Environment.NewLine);
            sp_InsertPointChild.Append("Drop Procedure sp_InsertPointChild" + Environment.NewLine);

            StringBuilder sp_UpdatePointChild = new StringBuilder();
            sp_UpdatePointChild.Append("IF (OBJECT_ID('sp_UpdatePointChild', 'P') IS NOT NULL)" + Environment.NewLine);
            sp_UpdatePointChild.Append("Drop Procedure sp_UpdatePointChild" + Environment.NewLine);

            StringBuilder sp_InsertPointChildStore = new StringBuilder();
            sp_InsertPointChildStore.Append("IF (OBJECT_ID('sp_InsertPointChildStore', 'P') IS NOT NULL)" + Environment.NewLine);
            sp_InsertPointChildStore.Append("Drop Procedure sp_InsertPointChildStore" + Environment.NewLine);

            migrationBuilder.Sql(sp_InsertCliGroupName.ToString());
            migrationBuilder.Sql(sp_IsCliGroupExists.ToString());
            migrationBuilder.Sql(sp_GetCliPointChildGroupId.ToString());
            migrationBuilder.Sql(sp_PointHasChild.ToString());
            migrationBuilder.Sql(sp_InsertPointChild.ToString());
            migrationBuilder.Sql(sp_UpdatePointChild.ToString());
            migrationBuilder.Sql(sp_InsertPointChildStore.ToString());
        }
    }
}
