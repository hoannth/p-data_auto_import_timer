using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SqlServerImportTool
{
    class DataManager
    {
        // Connection string
        public static string CONNECTION_STRING = "";
        public static string INSERT_STRING = "";

        public DataManager()
        {

        }

        /// <summary>
        /// Excute query
        /// </summary>
        /// <param name="querrystring">Query string</param>
        /// <returns>True: Success, False: Fail</returns>
        private static bool ExecuteQuery(string querryString)
        {
            bool result = true;
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(CONNECTION_STRING))
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

        public static bool InsertData(Array data)
        {
            bool result = false;
            string querry = INSERT_STRING;

            for (int i = 0; i < data.Length; i++ )
            {
                if( i== 0)
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
