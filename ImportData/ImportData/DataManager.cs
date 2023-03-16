using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ImportData
{
    class DataManager
    {
        // Connection string
        private string connectionstring;

        public string tableName;
        private string defautInsertString;

        /// <summary>
        /// Data manager construction
        /// </summary>
        /// <param name="serverName">Server name</param>
        public DataManager(string connetionstring, string insertString)
        {
            this.connectionstring = connetionstring;
            this.defautInsertString = insertString = "INSERT INTO " + insertString + " VALUES";
        }

        /// <summary>
        /// Excute query
        /// </summary>
        /// <param name="querrystring">Query string</param>
        /// <returns>True: Success, False: Fail</returns>
        private bool ExecuteQuery(string querryString)
        {
            bool result = true;
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionstring))
                {
                    if (sqlConnection.State != ConnectionState.Open)
                    {
                        sqlConnection.Open();
                    }

                    SqlCommand sqlCommand = new SqlCommand(querryString, sqlConnection);
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.ExecuteNonQuery();

                    sqlCommand.Dispose();
                    sqlCommand = null;

                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                result = false;
                Console.WriteLine("ExecuteQuery " + querryString + ". Error " + ex.ToString());
            }

            return result;
        }

        /// <summary>
        /// Excute query data
        /// </summary>
        /// <param name="querrystring">Query string</param>
        /// <returns>Data table, content select</returns>
        private DataTable ExecuteQueryData(string querryString)
        {
            DataTable data = new DataTable();

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionstring))
                {
                    if (sqlConnection.State != ConnectionState.Open)
                    {
                        sqlConnection.Open();
                    }

                    SqlCommand sqlCommand = new SqlCommand(querryString, sqlConnection);
                    sqlCommand.CommandType = CommandType.Text;

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(data);

                    sqlCommand.Dispose();
                    sqlCommand = null;

                    sqlDataAdapter.Dispose();
                    sqlDataAdapter = null;

                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ExecuteQueryData " + querryString + ". Error " + ex.ToString());
            }

            return data;
        }

        public bool InsertData(Array data)
        {
            bool result = false;
            string querry = defautInsertString;

            for (int i = 0; i < data.Length; i++ )
            {
                if( i == 0)
                {
                    querry += "('" + data.GetValue(i).ToString();
                }
                else if(i == data.Length - 1)
                {
                    querry += "','" + data.GetValue(i).ToString() + "')";
                }
                else
                {
                    querry += "','" + data.GetValue(i).ToString();
                }
            }

            result = ExecuteQuery(querry);

            return result;
        }
    }
}
