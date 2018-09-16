using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Migrations
{
    public partial class Added_StoredProcedures_InsertUserRights : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // sp_InsertPointChild
            StringBuilder sp_command = new StringBuilder();
            sp_command.Append("Create Procedure sp_Insert_UserRights_PointChild" + Environment.NewLine);
            sp_command.Append("@pointNumber int" + Environment.NewLine);
            sp_command.Append("as" + Environment.NewLine);
            sp_command.Append("Begin" + Environment.NewLine);
            sp_command.Append("Insert Into user_rights(user_number,point_number," + Environment.NewLine);
            sp_command.Append("\"00view\",\"00edit\",\"00approve\",\"00rollback\",\"00delete\"," + Environment.NewLine);
            sp_command.Append("\"01view\",\"01edit\",\"01approve\",\"01rollback\",\"01delete\"," + Environment.NewLine);
            sp_command.Append("\"02view\",\"02edit\",\"02approve\",\"02rollback\",\"02delete\"," + Environment.NewLine);
            sp_command.Append("\"04view\",\"04edit\",\"04approve\",\"04rollback\",\"04delete\"," + Environment.NewLine);
            sp_command.Append("\"05view\",\"05edit\",\"05approve\",\"05rollback\",\"05delete\"," + Environment.NewLine);
            sp_command.Append("\"07view\",\"07edit\",\"07approve\",\"07rollback\",\"07delete\"," + Environment.NewLine);
            sp_command.Append("\"08view\",\"08edit\",\"08approve\",\"08rollback\",\"08delete\"," + Environment.NewLine);
            sp_command.Append("\"09view\",\"09edit\",\"09approve\",\"09rollback\",\"09delete\"," + Environment.NewLine);
            sp_command.Append("\"14view\",\"14edit\",\"14approve\",\"14rollback\",\"14delete\"," + Environment.NewLine);
            sp_command.Append("\"17view\",\"17edit\",\"17approve\",\"17rollback\",\"17delete\"," + Environment.NewLine);
            sp_command.Append("\"18view\",\"18edit\",\"18approve\",\"18rollback\",\"18delete\"," + Environment.NewLine);
            sp_command.Append("\"19view\",\"19edit\",\"19approve\",\"19rollback\",\"19delete\"," + Environment.NewLine);
            sp_command.Append("\"03view\",\"03edit\",\"03approve\",\"03rollback\",\"03delete\"," + Environment.NewLine);
            sp_command.Append("\"15view\",\"15edit\",\"15approve\",\"15rollback\",\"15delete\"," + Environment.NewLine);
            sp_command.Append("\"20view\",\"20edit\",\"20approve\",\"20rollback\",\"20delete\"," + Environment.NewLine);
            sp_command.Append("\"21view\",\"21edit\",\"21approve\",\"21rollback\",\"21delete\"," + Environment.NewLine);
            sp_command.Append("\"22view\",\"22edit\",\"22approve\",\"22rollback\",\"22delete\")" + Environment.NewLine);
            sp_command.Append("Values(1,@pointNumber," + Environment.NewLine);
            sp_command.Append("1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1," + Environment.NewLine);
            sp_command.Append("1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1," + Environment.NewLine);
            sp_command.Append("1,1,1,1,1)" + Environment.NewLine);
            sp_command.Append("End" + Environment.NewLine);
            sp_command.Append("Go" + Environment.NewLine);
            migrationBuilder.Sql(sp_command.ToString());
            sp_command.Clear();
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            StringBuilder sp_command = new StringBuilder();
            sp_command.Append("IF (OBJECT_ID('sp_Insert_UserRights_PointChild', 'P') IS NOT NULL)" + Environment.NewLine);
            sp_command.Append("Drop Procedure sp_Insert_UserRights_PointChild" + Environment.NewLine);
            migrationBuilder.Sql(sp_command.ToString());
            sp_command.Clear();
        }
    }
}
