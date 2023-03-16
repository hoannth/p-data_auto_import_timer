using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServerImportTool
{
    class DataLib
    {
        private static string OpenExcelFile(string fPath)
        {
            string connectionstring = "";

            if (Path.GetExtension(fPath) == "xls")
            {
                connectionstring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fPath + ";Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=1\"";
            }
            else if (Path.GetExtension(fPath) == "xlsx")
            {
                connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fPath + ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"";
            }

            return connectionstring;
        }

        public static DataSet GetDataExcel(string filePath, string sheetName)
        {
            DataSet dataSet = new DataSet();

            try
            {
                if (Path.GetExtension(filePath).Equals(".csv"))
                {
                    string _connectionstring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={" + Path.GetDirectoryName(filePath) + "};Extended Properties='text;HDR=Yes;FMT=TabDelimited'";
                    string _query;
                    OdbcConnection _connection;
                    _connection = new OdbcConnection(_connectionstring.Trim());
                    _connection.Open();

                    _query = "SELECT * FROM [" + Path.GetFileName(filePath) + "]";
                    OdbcDataAdapter obj_oledb_da = new OdbcDataAdapter(_query, _connection);
                    obj_oledb_da.Fill(dataSet, "csv");

                    _connection.Close();
                }
                else if (Path.GetExtension(filePath).Equals(".xlsx") ||
                    Path.GetExtension(filePath).Equals(".xls"))
                {
                    string connectionstring = OpenExcelFile(filePath);
                    string query = "SELECT * FROM [" + sheetName + "$]";

                    using (OleDbConnection connection = new OleDbConnection(connectionstring))
                    {
                        connection.Open();
                        OleDbDataAdapter oleAdapter = new OleDbDataAdapter(query, connection);
                        oleAdapter.Fill(dataSet, sheetName);

                        oleAdapter.Dispose();
                        connection.Close();
                        connection.Dispose();
                    }
                }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message.ToString());
            }
            return dataSet;
        }
    }
}
