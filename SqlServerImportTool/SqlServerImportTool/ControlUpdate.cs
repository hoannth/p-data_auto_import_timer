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
using System.IO;

namespace SqlServerImportTool
{
    public partial class ControlUpdate : DevExpress.XtraEditors.XtraUserControl
    {
        private string tableName;
        private DataTable columnsDataLeft;
        private DataTable columnsDataRight;
        public bool isStarted;
        private string[] filesPath;
        private DataTable dataFilePathsSource;

        public ControlUpdate()
        {
            InitializeComponent();

            isStarted = false;

            dataFilePathsSource = new DataTable();
            dataFilePathsSource.Columns.Add("STT", typeof(string));
            dataFilePathsSource.Columns.Add("File Name", typeof(string));
            dataFilePathsSource.Columns.Add("Process", typeof(string));

            dataFilePaths.DataSource = dataFilePathsSource;

            gridView.OptionsView.ColumnAutoWidth = false;
            gridView.Columns[0].Width = 100;
            gridView.Columns[1].Width = 550;
            gridView.Columns[2].Width = 300;

            columnsDataRight = new DataTable();
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
        }

        private void tbFolderPath_TextChanged(object sender, EventArgs e)
        {
            LoadFolder();
        }

        public void StartUpdate()
        {
            isStarted = true;
            this.Enabled = false;
        }

        public void StopUpdate()
        {
            isStarted = false;
            this.Enabled = true;
        }

        public void UpdateInfo(string tableName, DataTable columnsData)
        {
            if (isStarted)
            {
                return;
            }

            this.tableName = tableName;
            this.columnsDataLeft = columnsData;
        }

        private void LoadFolder()
        {
            string folderPath = tbFolderPath.Text;
            dataFilePathsSource.Rows.Clear();

            try
            {
                filesPath = Directory.GetFiles(folderPath);
                for (int i = 0; i < filesPath.Length; i++)
                {
                    string filePathIndex = filesPath[i];
                    string[] arrType = filePathIndex.Split('.');
                    if (arrType.Length > 0)
                    {
                        if (arrType[1].Equals("xlsx")
                            || arrType[1].Equals("xls")
                            || arrType[1].Equals("csv"))
                        {
                            string[] path = filesPath[i].Split('\\');
                            string name = path[path.Length - 1];

                            string[] newRow = new string[] { (i + 1).ToString(), name, "0%" };
                            dataFilePathsSource.Rows.Add(newRow);
                        }
                    }
                }

                dataFilePaths.DataSource = dataFilePaths;
                dataFilePaths.RefreshDataSource();
                dataFilePaths.Refresh();
            }
            catch (Exception ex)
            {
            }
        }

        public void SelectFolder()
        {
            if (isStarted)
            {
                return;
            }

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbFolderPath.Text = dialog.SelectedPath;
                LoadFolder();
            }
        }

        public void SelectTable()
        {
            if (isStarted)
            {
                return;
            }

            FormTable frmTable = new FormTable("Update Table Setting", columnsDataLeft);
            DialogResult result = frmTable.ShowDialog();

            if (result == DialogResult.OK)
            {
                columnsDataRight = frmTable.dataRightSource;

                lbInfo.Text = tableName + "(";

                for (int i = 0; i < columnsDataRight.Rows.Count; i++)
                {
                    string column = columnsDataRight.Rows[i][1].ToString();
                    lbInfo.Text += column;
                    if (i < columnsDataRight.Rows.Count - 1)
                    {
                        lbInfo.Text += ", ";
                    }
                }

                lbInfo.Text += ")";
            }
        }
    }
}
