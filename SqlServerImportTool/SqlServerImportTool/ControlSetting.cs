using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace SqlServerImportTool
{
    public partial class ControlSetting : DevExpress.XtraEditors.XtraUserControl
    {
        public string connectionString;
        public string serverName;
        public string databaseName;
        public string tableName;
        public bool isChanged;
        public bool isSaved;
        public DataTable columnsData;

        public ControlSetting()
        {
            InitializeComponent();

            columnsData = new DataTable();
            columnsData.Columns.Add("STT", typeof(string));
            columnsData.Columns.Add("Column name", typeof(string));

            dataColumns.DataSource = columnsData;

            gridView.OptionsView.ColumnAutoWidth = false;
            gridView.Columns[0].Width = 70;
            gridView.Columns[1].Width = 300;

            isChanged = false;
            isSaved = false;
        }

        public void LoadSettings(string _serverName, string _databaseName, string _tableName, DataTable _columnsData)
        {
            this.serverName = _serverName;
            tbServerName.Text = serverName;

            this.databaseName = _databaseName;
            tbDatabaseName.Text = databaseName;

            this.tableName = _tableName;
            tbTableName.Text = tableName;

            dataColumns.DataSource = _columnsData;
            this.columnsData = _columnsData;

            gridView.OptionsView.ColumnAutoWidth = false;
            gridView.Columns[0].Width = 70;
            gridView.Columns[1].Width = 300;

            isChanged = false;
        }

        public void ShowControl()
        {
            this.Visible = true;
            this.Enabled = true;
        }

        public void HideControl()
        {
            this.Visible = false;
            this.Enabled = false;

            connectionString = tbConnectionString.Text;
            serverName = tbServerName.Text;
            tableName = tbTableName.Text;

            columnsData = (DataTable)dataColumns.DataSource;
        }

        public void UpdateConnectionString()
        {
            connectionString = @"Data Source=" + serverName + ";Initial Catalog=" + databaseName + ";Integrated Security=True";
            tbConnectionString.Text = connectionString;
        }

        private void btTestConnection_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    if (connection.State == ConnectionState.Open)
                    {
                        XtraMessageBox.Show("Test connection succeeded", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        XtraMessageBox.Show("Test connection failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    connection.Close();
                }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("Test connection failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbServerName_TextChanged(object sender, EventArgs e)
        {
            serverName = tbServerName.Text;
            UpdateConnectionString();
            isChanged = true;
        }

        private void tbDatabaseName_TextChanged(object sender, EventArgs e)
        {
            databaseName = tbDatabaseName.Text;
            UpdateConnectionString();
            isChanged = true;
        }

        private void tbTableName_TextChanged(object sender, EventArgs e)
        {
            tableName = tbTableName.Text;
            isChanged = true;
        }

        private void tbConnectionString_TextChanged(object sender, EventArgs e)
        {
            connectionString = tbConnectionString.Text;
            isChanged = true;
        }

        private void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            isChanged = true;
        }

        private void tbColumnName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btAddColumn.PerformClick();
            }
        }

        private void btAddColumn_Click(object sender, EventArgs e)
        {
            if (!tbColumnName.Text.Equals(""))
            {
                string[] newRow = new string[] { (columnsData.Rows.Count + 1).ToString(), tbColumnName.Text};
                columnsData.Rows.Add(newRow);
                dataColumns.DataSource = columnsData;
                dataColumns.RefreshDataSource();
                dataColumns.Refresh();

                tbColumnName.Text = "";

                isChanged = true;
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (gridView.FocusedRowHandle >= 0)
            {
                DataRow[] rows = new DataRow[gridView.SelectedRowsCount];
                for (int i = 0; i < gridView.SelectedRowsCount; i++)
                {
                    rows[i] = gridView.GetDataRow(gridView.GetSelectedRows()[i]);
                }

                foreach (DataRow row in rows)
                {
                    row.Delete();
                }

                if (gridView.FocusedRowHandle >= 0 && gridView.FocusedRowHandle < gridView.DataRowCount)
                {

                    for (int i = gridView.FocusedRowHandle; i < gridView.DataRowCount; i++)
                    {
                        gridView.SetRowCellValue(i, "STT", i + 1);
                    }
                }

                isChanged = true;
            }
        }

        public void SaveSetting()
        {
            bool result = UtilsLib.SaveSettings(serverName, databaseName, tableName, columnsData);
            if(result)
            {
                XtraMessageBox.Show("Save settings succeeded", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isSaved = true;
            }
            else
            {
                XtraMessageBox.Show("Save settings failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ResetSetting()
        {
            connectionString = "";
            serverName = "";
            databaseName = "";
            tableName = "";

            tbConnectionString.Text = "";
            tbServerName.Text = "";
            tbDatabaseName.Text = "";
            tbTableName.Text = "";
            tbColumnName.Text = "";

            columnsData.Rows.Clear();
            dataColumns.DataSource = columnsData;
            dataColumns.RefreshDataSource();
            dataColumns.Refresh();

            isChanged = true;
        }
    }
}
