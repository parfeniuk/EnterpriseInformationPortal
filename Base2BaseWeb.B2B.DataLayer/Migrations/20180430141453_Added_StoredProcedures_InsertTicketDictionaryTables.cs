using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Migrations
{
    public partial class Added_StoredProcedures_InsertTicketDictionaryTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            StringBuilder insertCommand = new StringBuilder();
            // Initialize TicketStatus values
            insertCommand.Append("if not exists(select 1 from TicketStatus)" + Environment.NewLine);
            insertCommand.Append("SET IDENTITY_INSERT TicketStatus ON" + Environment.NewLine);
            insertCommand.Append("Insert Into TicketStatus(TicketStatusId,TicketStatusName)" + Environment.NewLine);
            insertCommand.Append("Values(1,'Открыто')" + Environment.NewLine);
            insertCommand.Append("Insert Into TicketStatus(TicketStatusId,TicketStatusName)" + Environment.NewLine);
            insertCommand.Append("Values(2,'Выполнено')" + Environment.NewLine);
            insertCommand.Append("SET IDENTITY_INSERT TicketStatus OFF" + Environment.NewLine);
            insertCommand.Append("Go" + Environment.NewLine);
            migrationBuilder.Sql(insertCommand.ToString());
            insertCommand.Clear();
            // Initialize TicketSubject values
            insertCommand.Append("if not exists(select 1 from TicketSubject)" + Environment.NewLine);
            insertCommand.Append("SET IDENTITY_INSERT TicketSubject ON" + Environment.NewLine);
            insertCommand.Append("Insert Into TicketSubject(TicketSubjectId,TicketSubjectName)" + Environment.NewLine);
            insertCommand.Append("Values(1,'Настройки')" + Environment.NewLine);
            insertCommand.Append("Insert Into TicketSubject(TicketSubjectId,TicketSubjectName)" + Environment.NewLine);
            insertCommand.Append("Values(2,'Проблема ПО')" + Environment.NewLine);
            insertCommand.Append("Insert Into TicketSubject(TicketSubjectId,TicketSubjectName)" + Environment.NewLine);
            insertCommand.Append("Values(3,'Проблема оборудования')" + Environment.NewLine);
            insertCommand.Append("SET IDENTITY_INSERT TicketStatus OFF" + Environment.NewLine);
            insertCommand.Append("Go" + Environment.NewLine);
            migrationBuilder.Sql(insertCommand.ToString());
            insertCommand.Clear();
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
