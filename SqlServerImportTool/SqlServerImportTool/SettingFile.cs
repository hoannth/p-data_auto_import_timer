using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServerImportTool
{
    class SettingFile
    {
        public string connectionString;
        public string serverName;
        public string databaseName;
        public string tableName;
        private DataTable columnDatas;

        public SettingFile()
        {
            connectionString = "";
            serverName = "";
            databaseName = "";
            tableName = "";
            columnDatas = new DataTable();
        }

        public void LoadSettings()
        {
            ArrayList settings = UtilsLib.ReadFile(Define.SETTING_FILE_NAME);
        }
    }
}
