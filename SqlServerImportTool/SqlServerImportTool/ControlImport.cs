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
using System.Threading;

namespace SqlServerImportTool
{
    public partial class ControlImport : DevExpress.XtraEditors.XtraUserControl
    {
        private string tableName;
        private DataTable columnsDataLeft;
        private DataTable columnsDataRight;
        public bool isStarted;
        private List<string> filesPath;
        private DataTable dataFilePathsSource;
        private Thread importThead;

        public ControlImport()
        {
            InitializeComponent();

            isStarted = false;

            filesPath = new List<string>();

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

            importThead = new Thread(new ThreadStart(Import));
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

        private void Import()
        {
            for (int i = 0; i < filesPath.Count; i++)
            {
                gridView.FocusedRowHandle = i;

                DataSet dataSet = new DataSet();

                if (Path.GetExtension(filesPath[i]).Equals(".csv"))
                {
                    DataTable dataTable = new DataTable();
                    for (int j = 0; j < columnsDataRight.Rows.Count; j++)
                    {
                        dataTable.Columns.Add(new DataColumn("", typeof(string)));
                    }

                    string[] rows = File.ReadAllLines(filesPath[i]);
                    foreach (string row in rows)
                    {
                        if (!string.IsNullOrEmpty(row))
                        {
                            dataTable.Rows.Add();
                            int index = 0;
                            int indexCell = 0;
                            string[] cells = new string[columnsDataRight.Rows.Count];
                            string[] cells_1 = row.Split('\"');
                            for (int j2 = 0; j2 < cells_1.Length; j2++ )
                            {
                                string[] cells_2 = cells_1[j2].Split(',');
                                for (int j3 = 0; j3 < cells_2.Length; j3++)
                                {
                                    if(!cells_2[j3].Equals(""))
                                    {
                                        cells[index] = cells_2[j3];
                                        index++;
                                    }
                                }
                            }

                            foreach (string cell in cells)
                            {
                                dataTable.Rows[dataTable.Rows.Count - 1][indexCell] = cell;
                                indexCell++;
                            }
                        }
                    }

                    dataSet.Tables.Add(dataTable);
                }
                else
                {
                    dataSet = DataLib.GetDataExcel(filesPath[i], "Sheet1");
                }

                //dataSet = DataLib.GetDataExcel(filesPath[i], "Sheet1");

                for (int i1 = 0; i1 < dataSet.Tables.Count; i1++)
                {
                    DataTable table = dataSet.Tables[i1];
                    for (int i2 = 0; i2 < table.Rows.Count; i2++)
                    {
                        Array arr = table.Rows[i2].ItemArray.ToArray();
                        DataManager.InsertData(arr);

                        gridView.SetRowCellValue(i, "Process", (int)(((i2 * 100) / table.Rows.Count) + 1) + "%");
                    }
                }
            }
        }

        public void StartImport()
        {
            if (!importThead.IsAlive)
            {
                isStarted = true;
                this.Enabled = false;
                importThead.Start();
                XtraMessageBox.Show("Started Import", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void StopImport()
        {
            if(importThead.IsAlive)
            {
                isStarted = false;
                this.Enabled = true;
                importThead.Abort();
                XtraMessageBox.Show("Stopped Import", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                string[] _filesPath = Directory.GetFiles(folderPath);
                for (int i = 0; i < _filesPath.Length; i++)
                {
                    string filePathIndex = _filesPath[i];
                    string fileType = Path.GetExtension(filePathIndex);

                    if (fileType.Equals(".xlsx") || 
                        fileType.Equals(".xls") || 
                        fileType.Equals(".csv"))
                    {
                        filesPath.Add(filePathIndex);
                        string fileName = Path.GetFileName(filePathIndex);
                        string[] newRow = new string[] { (i + 1).ToString(), fileName, "0%" };
                        dataFilePathsSource.Rows.Add(newRow);
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

            FormTable frmTable = new FormTable("Import Table Setting", columnsDataLeft);
            DialogResult result = frmTable.ShowDialog();

            if(result == DialogResult.OK)
            {
                columnsDataRight = frmTable.dataRightSource.Copy();

                DataManager.INSERT_STRING = "INSERT INTO " + tableName + " (";
                lbInfo.Text = tableName + "(";

                for (int i = 0; i < columnsDataRight.Rows.Count; i++)
                {
                    string column = columnsDataRight.Rows[i][1].ToString();
                    
                    lbInfo.Text += column;
                    DataManager.INSERT_STRING += column;

                    if (i < columnsDataRight.Rows.Count - 1)
                    {
                        lbInfo.Text += ", ";
                        DataManager.INSERT_STRING += ", ";
                    }
                }

                lbInfo.Text += ")";
                DataManager.INSERT_STRING += ") VALUES (";

                lbInfo.ToolTip = lbInfo.Text;
            }
        }

        private void tbFolderPath_TextChanged(object sender, EventArgs e)
        {
            LoadFolder();
        }
    }
}
