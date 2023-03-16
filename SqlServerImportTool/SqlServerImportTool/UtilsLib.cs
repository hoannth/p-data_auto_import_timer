using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlServerImportTool
{
    class UtilsLib
    {
        public static ArrayList ReadFile(string fileName)
        {
            ArrayList arrConfig = new ArrayList();

            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        arrConfig.Add(line);
                    }

                    sr.Close();
                    sr.Dispose();
                }
            }
            catch (Exception e)
            {
            }

            return arrConfig;
        }

        public static bool SaveSettings(string serverName, string databaseName, string tableName, DataTable columnsData)
        {
            StreamWriter objWriter = null;

            try
            {
                objWriter = new StreamWriter(Define.SETTING_FILE_NAME, false);
                objWriter.AutoFlush = true;

                objWriter.WriteLine(serverName);
                objWriter.WriteLine(databaseName);
                objWriter.WriteLine(tableName);
                for (int i = 0; i < columnsData.Rows.Count; i++)
                {
                    objWriter.WriteLine(columnsData.Rows[i][1].ToString());
                }

                objWriter.Close();
                objWriter.Dispose();

                return true;
            }
            catch(Exception ex)
            {
                if (objWriter != null)
                {
                    objWriter.Close();
                    objWriter.Dispose();
                }
                return false;
            }
        }
    }
}
