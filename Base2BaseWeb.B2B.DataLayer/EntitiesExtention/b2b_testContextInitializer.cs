using Base2BaseWeb.B2B.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public static class b2b_testContextInitializer
    {
        public static void Initialize(b2b_testContext context)
        {
            context.Database.Migrate();
        }

        // Bypass Initial Migration (Initial migration is DB snapshot resulting from Reverse Engineering)
        public static void BypassInitialMigration(b2b_testContext context)
        {
            /* Create __EFMigration Table IF NOT EXISTS*/
            StringBuilder createTable = new StringBuilder();
            createTable.Append("if not exists" + Environment.NewLine);
            createTable.Append("(select * from sysobjects where name='__EFMigrationsHistory' and xtype='U')" + Environment.NewLine);
            createTable.Append("CREATE TABLE [dbo].[__EFMigrationsHistory](" + Environment.NewLine);
            createTable.Append("[MigrationId] [nvarchar](150) NOT NULL," + Environment.NewLine);
            createTable.Append("[ProductVersion] [nvarchar](32) NOT NULL," + Environment.NewLine);
            createTable.Append("CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED" + Environment.NewLine);
            createTable.Append("([MigrationId] ASC)" + Environment.NewLine);
            createTable.Append("WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF," + Environment.NewLine);
            createTable.Append("IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON," + Environment.NewLine);
            createTable.Append("ALLOW_PAGE_LOCKS = ON) ON [PRIMARY])" + Environment.NewLine);
            createTable.Append("ON [PRIMARY]" + Environment.NewLine);
            string strCreate = createTable.ToString();
            context.Database.ExecuteSqlCommand(createTable.ToString());

            // Get 1st migration of All (Non-applied + applied)
            string initialMigration = context.Database.GetMigrations()?.First();

            if (!string.IsNullOrEmpty(initialMigration))
            {
                // Check if initial record exists in __EFMigrationsHistory Table
                int count;
                string query = $@"Set Nocount Off Select Count(MigrationId) From __EFMigrationsHistory Where MigrationId='{initialMigration}'";
                var conn = context.Database.GetDbConnection();
                try
                {
                    conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = query;
                        count = (int)cmd.ExecuteScalar();
                    }
                }
                finally
                {
                    conn.Close();
                }

                // Insert record to __EFMigrationsHistory Table to bypass Initial Migration be applied
                if (count!=1)
                {
                    string spInsert =
                            $@"Insert Into __EFMigrationsHistory (MigrationId,ProductVersion) 
                            Values('{initialMigration}','2.0.2-rtm-10011')";
                    context.Database.ExecuteSqlCommand(spInsert);
                }

                // Apply pending migration one-by-one except Initial Migration
                var pendingMigrations = context.Database.GetPendingMigrations();
                if (pendingMigrations.Any())
                {
                    var migrator = context.Database.GetService<IMigrator>();
                    foreach (var targetMigration in pendingMigrations)
                        migrator.Migrate(targetMigration);
                }
            }
        }
    }
}
