using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DbSyncService
{
    public class DbSyncWorker : IDbSyncWorker
    {
        private string _connectionStringTarget;
        private SqlConnectionStringBuilder builderSource;

        public DbSyncWorker(string connectionStringTarget)
        {
            _connectionStringTarget = connectionStringTarget;
            builderSource = new SqlConnectionStringBuilder();
            SourceCredentialsList = new List<Credentials>();
            Children = new List<Child>();
        }
        public List<Credentials> SourceCredentialsList { get; set; }
        public List<Child> Children { get; set; }

        public void SynchronizeTables()
        {
            using (SqlConnection connectionTarget = new SqlConnection(_connectionStringTarget))
            {
                connectionTarget.Open();
                SqlTransaction transaction = connectionTarget.BeginTransaction();
                try
                {
                    foreach (var sourceCredential in SourceCredentialsList)
                    {
                        builderSource["Server"] = sourceCredential.Server;
                        builderSource["Database"] = sourceCredential.Database;
                        builderSource["User Id"] = sourceCredential.User;
                        builderSource["Password"] = sourceCredential.Password;

                        //1. Check if GroupId exists in Target DB
                        SqlParameter paramClientId = new SqlParameter
                        {
                            ParameterName = "@clientId",
                            Value = sourceCredential.PointNumber,
                            SqlDbType = System.Data.SqlDbType.Int,
                            Direction = System.Data.ParameterDirection.Input
                        };
                        using (SqlCommand command = connectionTarget.CreateCommand())
                        {
                            command.Transaction = transaction;

                            command.CommandText = "sp_SelectGroupClientsCount";
                            command.CommandType = System.Data.CommandType.StoredProcedure;
                            command.Parameters.Add(paramClientId);
                            int count = (int)command.ExecuteScalar();
                            command.Parameters.Clear();

                            //1.1 ADD NEW GROUP
                            if (count == 0)
                            {
                                //1.1.1 Add new GroupName into CliGroup Table
                                SqlParameter paramGroupName = new SqlParameter
                                {
                                    ParameterName = "@name",
                                    Value = sourceCredential.GroupName,
                                    SqlDbType = System.Data.SqlDbType.NVarChar,
                                    Size = 256,
                                    Direction = System.Data.ParameterDirection.Input
                                };
                                command.CommandText = "sp_InsertCliGroupName";
                                command.CommandType = System.Data.CommandType.StoredProcedure;
                                command.Parameters.Add(paramGroupName);
                                decimal groupId = (decimal)command.ExecuteScalar();
                                command.Parameters.Clear();

                                //1.1.2 Add GroupClient (GroupID + ClientID) row into GroupClients
                                SqlParameter paramGroupId = new SqlParameter
                                {
                                    ParameterName = "@groupId",
                                    Value = groupId,
                                    SqlDbType = System.Data.SqlDbType.Int,
                                    Direction = System.Data.ParameterDirection.Input
                                };
                                //SqlCommand cmdInsertGroupClients = new SqlCommand("sp_InsertGroupClients", connectionTarget);
                                command.CommandText = "sp_InsertGroupClients";
                                command.CommandType = System.Data.CommandType.StoredProcedure;
                                command.Parameters.Add(paramClientId);
                                command.Parameters.Add(paramGroupId);
                                command.ExecuteNonQuery();
                                command.Parameters.Clear();
                            }

                            //2. Delete PointChildren
                            command.CommandText = "sp_DeletePointChildren";
                            command.CommandType = System.Data.CommandType.StoredProcedure;
                            command.Parameters.Add(paramClientId);
                            command.ExecuteNonQuery();
                            command.Parameters.Clear();

                            //3. Select Points from Source Connection
                            using (SqlConnection connectionSource = new SqlConnection(builderSource.ConnectionString))
                            {
                                connectionSource.Open();
                                string query = "select point_number,name_point from point where post=0";
                                using (SqlCommand commandSource = new SqlCommand(query, connectionSource))
                                {
                                    //string query = "select point_number,name_point from point where post=0";
                                    commandSource.CommandText = query;
                                    commandSource.CommandType = System.Data.CommandType.Text;
                                    //commandSource.ExecuteNonQuery();
                                    using (SqlDataReader reader = commandSource.ExecuteReader())
                                    {
                                        if (reader.HasRows)
                                        {
                                            var dataTable = new DataTable();
                                            dataTable.Load(reader);
                                            foreach (DataRow row in dataTable.Rows)
                                            {
                                                Children.Add(new Child
                                                {
                                                    ChildId = Convert.ToInt32(row.ItemArray[0]),
                                                    ChildName = row.ItemArray[1].ToString()
                                                });
                                            }
                                        }
                                    }
                                }
                            }
                            //4. Insert Into PointChildren
                            command.CommandText = "sp_InsertPointChildren";
                            command.CommandType = System.Data.CommandType.StoredProcedure;
                            SqlParameter paramChildId = new SqlParameter
                            {
                                ParameterName = "@childId",
                                SqlDbType = System.Data.SqlDbType.Int,
                                Direction = System.Data.ParameterDirection.Input
                            };
                            SqlParameter paramChildName = new SqlParameter
                            {
                                ParameterName = "@childName",
                                SqlDbType = System.Data.SqlDbType.NVarChar,
                                Size = 256,
                                Direction = System.Data.ParameterDirection.Input
                            };
                            command.Parameters.Add(paramClientId);
                            command.Parameters.Add(paramChildId);
                            command.Parameters.Add(paramChildName);
                            foreach (var child in Children)
                            {
                                paramChildId.Value = child.ChildId;
                                paramChildName.Value = child.ChildName;
                                command.ExecuteNonQuery();
                            }
                            command.Parameters.Clear();
                            // Commit Transaction
                            //transaction.Commit();
                            Children.Clear();
                        }
                    }
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    // Log and handle exceptions here
                    transaction.Rollback();
                }
            }
        }
    }
}
