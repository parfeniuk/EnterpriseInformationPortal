using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Logging;

namespace DbSyncService
{
    public class DbSyncWorker : IDbSyncWorker
    {
        private string _connectionStringTarget;
        private SqlConnectionStringBuilder builderSource;
        private readonly ILogger<DbSyncWorker> _logger;

        public DbSyncWorker(string connectionStringTarget, ILogger<DbSyncWorker> logger)
        {
            _connectionStringTarget = connectionStringTarget;
            builderSource = new SqlConnectionStringBuilder();
            _logger = logger;
            SourceCredentialsList = new List<Credentials>();
            Children = new List<Child>();
        }
        public List<Credentials> SourceCredentialsList { get; set; }
        public List<Child> Children { get; set; }

        public void SynchronizeTables()
        {
            using (SqlConnection connectionTarget = new SqlConnection(_connectionStringTarget))
            {
                try
                {
                    connectionTarget.Open();
                    foreach (var sourceCredential in SourceCredentialsList)
                    {
                        builderSource["Server"] = sourceCredential.Server;
                        builderSource["Database"] = sourceCredential.Database;
                        builderSource["User Id"] = sourceCredential.User;
                        builderSource["Password"] = sourceCredential.Password;

                        if (!string.IsNullOrEmpty(builderSource.ConnectionString))
                        {
                            SqlTransaction transaction = connectionTarget.BeginTransaction();
                            try
                            {
                                //1. Check if GroupId exists in Target DB
                                SqlParameter paramPointNumber = new SqlParameter
                                {
                                    ParameterName = "@pointNumber",
                                    Value = sourceCredential.PointNumber,
                                    SqlDbType = System.Data.SqlDbType.Int,
                                    Direction = System.Data.ParameterDirection.Input
                                };
                                SqlParameter paramPointName = new SqlParameter
                                {
                                    ParameterName = "@pointName",
                                    Value = sourceCredential.PointName,
                                    SqlDbType = System.Data.SqlDbType.NVarChar,
                                    Size = 256,
                                    Direction = System.Data.ParameterDirection.Input
                                };
                                SqlParameter paramCliGroupNumber = new SqlParameter
                                {
                                    ParameterName = "@cliGroupNumber",
                                    SqlDbType = System.Data.SqlDbType.Int,
                                    Direction = System.Data.ParameterDirection.Input
                                };

                                using (SqlCommand command = connectionTarget.CreateCommand())
                                {
                                    command.Transaction = transaction;
                                    command.CommandText = "sp_IsCliGroupExists";
                                    command.CommandType = System.Data.CommandType.StoredProcedure;
                                    command.Parameters.Add(paramPointNumber);
                                    bool groupExists = (bool)command.ExecuteScalar();
                                    command.Parameters.Clear();
                                    
                                    // ID TO INSERT
                                    int groupId;
                                    int pointId;

                                    //2 ADD NEW GROUP and NEW STORAGE POINT only on our side
                                    if (!groupExists)
                                    {
                                        //2.1 Add new GroupName into CliGroup Table
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
                                        command.Parameters.Add(paramPointNumber);
                                        groupId = (int)command.ExecuteScalar();
                                        command.Parameters.Clear();

                                        //3. Add new Point (Storage Point) only on OUR side
                                        command.CommandText = "sp_InsertPointChildStore";
                                        command.CommandType = System.Data.CommandType.StoredProcedure;
                                        command.Parameters.Add(paramCliGroupNumber);
                                        command.Parameters.Add(paramPointName);
                                        paramCliGroupNumber.Value = groupId;
                                        //command.ExecuteNonQuery();
                                        pointId = (int)command.ExecuteScalar();
                                        command.Parameters.Clear();

                                        //4. Add USER RIGHTS on new Point (Storage Point)
                                        command.CommandText = "sp_Insert_UserRights_PointChild";
                                        command.CommandType = System.Data.CommandType.StoredProcedure;
                                        command.Parameters.Add(paramPointNumber);
                                        paramPointNumber.Value = pointId;
                                        command.ExecuteNonQuery();
                                        command.Parameters.Clear();
                                    }
                                    // Get GroupId
                                    else
                                    {
                                        command.CommandText = "sp_GetCliPointChildGroupId";
                                        command.CommandType = System.Data.CommandType.StoredProcedure;
                                        command.Parameters.Add(paramPointNumber);
                                        groupId = (int)command.ExecuteScalar();
                                        command.Parameters.Clear();
                                    }

                                    //4. Select Points from Source Connection
                                    using (SqlConnection connectionSource = new SqlConnection(builderSource.ConnectionString))
                                    {
                                        try
                                        {
                                            connectionSource.Open();
                                            string query = "select point_number,name_point from point where post=0";
                                            using (SqlCommand commandSource = new SqlCommand(query, connectionSource))
                                            {
                                                commandSource.CommandText = query;
                                                commandSource.CommandType = System.Data.CommandType.Text;
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
                                        catch (Exception ex)
                                        {
                                            _logger.LogError($"Synchronization failed for " +
                                                $"{sourceCredential.PointName}, point_number: {sourceCredential.PointNumber}, " +
                                                $"error: {ex.Message}");
                                        }
                                        finally
                                        {
                                            connectionSource?.Dispose();
                                        }
                                    }
                                    // Update or Insert Children into Point Table
                                    if (Children.Count > 0)
                                    {
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

                                        //4. Insert Into PointChildren
                                        foreach (var child in Children)
                                        {
                                            // Check if Child exists
                                            command.CommandText = "sp_PointHasChild";
                                            command.CommandType = CommandType.StoredProcedure;
                                            command.Parameters.Add(paramCliGroupNumber);
                                            command.Parameters.Add(paramChildId);
                                            paramCliGroupNumber.Value = groupId;
                                            paramChildId.Value = child.ChildId;
                                            //paramChildName.Value = child.ChildName;
                                            bool hasChild = (bool)command.ExecuteScalar();
                                            command.Parameters.Clear();

                                            // If Child exists - Update the Child
                                            if (hasChild)
                                            {
                                                command.CommandText = "sp_UpdatePointChild";
                                                command.CommandType = System.Data.CommandType.StoredProcedure;
                                                command.Parameters.Add(paramCliGroupNumber);
                                                command.Parameters.Add(paramChildId);
                                                command.Parameters.Add(paramChildName);
                                                paramCliGroupNumber.Value = groupId;
                                                paramChildId.Value = child.ChildId;
                                                paramChildName.Value = child.ChildName+ " - " + sourceCredential.PointName;
                                                command.ExecuteNonQuery();
                                                command.Parameters.Clear();
                                            }
                                            // If Child doesn't exist - Insert new Child
                                            else
                                            {
                                                command.CommandText = "sp_InsertPointChild";
                                                command.CommandType = System.Data.CommandType.StoredProcedure;
                                                command.Parameters.Add(paramCliGroupNumber);
                                                command.Parameters.Add(paramChildId);
                                                command.Parameters.Add(paramChildName);
                                                paramCliGroupNumber.Value = groupId;
                                                paramChildId.Value = child.ChildId;
                                                paramChildName.Value = child.ChildName + " - " + sourceCredential.PointName;
                                                //command.ExecuteNonQuery();
                                                pointId = (int)command.ExecuteScalar();
                                                command.Parameters.Clear();

                                                //INSERT NEW USER RIGHT PERMISSION
                                                command.CommandText = "sp_Insert_UserRights_PointChild";
                                                command.CommandType = System.Data.CommandType.StoredProcedure;
                                                command.Parameters.Add(paramPointNumber);
                                                paramPointNumber.Value = pointId;
                                                command.ExecuteNonQuery();
                                                command.Parameters.Clear();
                                            }
                                        }
                                        Children.Clear();
                                    }
                                }
                                transaction.Commit();
                                _logger.LogInformation($"Synchronization succeeded for " +
                                    $"{sourceCredential.PointName}, point_number: {sourceCredential.PointNumber}");
                            }
                            catch (Exception ex)
                            {
                                // Log and handle exceptions
                                _logger.LogError($"Synchronization failed for " +
                                    $"{sourceCredential.PointName}, point_number: {sourceCredential.PointNumber}, error: {ex.Message}");
                                transaction.Rollback();
                            }
                        }
                        // Connection string to Client's DB is null or empty
                        else
                        {
                            _logger.LogError($"Synchronization failed for " +
                                $"{sourceCredential.PointName}, point_number: {sourceCredential.PointNumber}, " +
                                $"error: Connection string is empty");
                        }
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError($"Synchronization failed, error: {ex.Message}");
                }
                finally
                {
                   connectionTarget?.Dispose();
                }
            }
        }
    }
}
