using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Migrations
{
    public partial class Changed_StoredProcedures_InsertPointChild : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // sp_InsertPointChild
            StringBuilder sp_command = new StringBuilder();
            sp_command.Append("Alter Procedure sp_InsertPointChild" + Environment.NewLine);
            sp_command.Append("@cliGroupNumber int, @childId int, @childName nvarchar(255)" + Environment.NewLine);
            sp_command.Append("as" + Environment.NewLine);
            sp_command.Append("Begin" + Environment.NewLine);
            sp_command.Append("Insert Into point(cli_group_number,ChildId,name_point,post)" + Environment.NewLine);
            sp_command.Append("Values(@cliGroupNumber,@childId,@childName,0)" + Environment.NewLine);
            sp_command.Append("Select CAST(SCOPE_IDENTITY() as int)"+Environment.NewLine);
            sp_command.Append("End" + Environment.NewLine);
            sp_command.Append("Go" + Environment.NewLine);
            migrationBuilder.Sql(sp_command.ToString());
            sp_command.Clear();

            // sp_InsertPointChildStore
            sp_command.Append("Alter Procedure sp_InsertPointChildStore" + Environment.NewLine);
            sp_command.Append("@cliGroupNumber int, @pointName nvarchar(255)" + Environment.NewLine);
            sp_command.Append("as" + Environment.NewLine);
            sp_command.Append("Begin" + Environment.NewLine);
            sp_command.Append("Insert Into point(cli_group_number,ChildId,name_point,post)" + Environment.NewLine);
            sp_command.Append("Values(@cliGroupNumber,0,'Склад - '+@pointName,0)" + Environment.NewLine);
            sp_command.Append("Select CAST(SCOPE_IDENTITY() as int)" + Environment.NewLine);
            sp_command.Append("End" + Environment.NewLine);
            sp_command.Append("Go" + Environment.NewLine);
            migrationBuilder.Sql(sp_command.ToString());
            sp_command.Clear();
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            StringBuilder sp_command = new StringBuilder();
            sp_command.Append("IF (OBJECT_ID('sp_InsertPointChildStore', 'P') IS NOT NULL)" + Environment.NewLine);
            sp_command.Append("Drop Procedure sp_InsertPointChildStore" + Environment.NewLine);
            migrationBuilder.Sql(sp_command.ToString());
            sp_command.Clear();

            sp_command.Append("IF (OBJECT_ID('sp_UpdatePointChild', 'P') IS NOT NULL)" + Environment.NewLine);
            sp_command.Append("Drop Procedure sp_UpdatePointChild" + Environment.NewLine);
            migrationBuilder.Sql(sp_command.ToString());
            sp_command.Clear();
        }
    }
}
