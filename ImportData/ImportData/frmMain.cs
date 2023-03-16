using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;

namespace ImportData
{
    public partial class frmMain : Form
    {
        // Config file name
        private static string FILE_CONFIG_NAME = "config.cf";

        private string folderPath;
        private string[] filesPath;

        private DataManager dataManager;

        private Thread insertThread;

        public frmMain()
        {
            InitializeComponent();

            folderPath = "";
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string serverName;
            string dataName;
            string insertString;
            string connectionString;

            // Load config file server
            try
            {
                ArrayList config = UtilsLib.ReadFile(FILE_CONFIG_NAME);

                serverName = config[0].ToString();
                dataName = config[1].ToString();
                insertString = config[2].ToString();

                connectionString = @"Data Source=" + serverName + ";Initial Catalog=" + dataName + ";Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    connection.Open();

                    if (connection.State != ConnectionState.Open)
                    {

                        MessageBox.Show("Can not connect to the Server.\nCheck again please!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                        return;
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not read file config.\bCheck again please", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
                return;
            }

            dataManager = new DataManager(connectionString, insertString);

            ShowApp();

            LoadFolder(tbFilePath.Text);
        }

        private void ShowApp()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowIcon = true;
            this.ShowInTaskbar = true;
            this.notifyIcon.Visible = false;
            this.btnStart.Enabled = true;
            this.tbFilePath.Enabled = true;
            this.btnBrowse.Enabled = true;
            this.btnStop.Enabled = false;
        }

        private void UnShowApp()
        {
            this.Hide();
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.notifyIcon.Visible = true;
            this.btnStart.Enabled = false;
            this.tbFilePath.Enabled = false;
            this.btnBrowse.Enabled = false;
            this.btnStop.Enabled = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(insertThread.IsAlive)
            {
                insertThread.Abort();
            }
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowApp();
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                UnShowApp();
            }
        }

        private void LoadFolder(string folderPath)
        {
            dataFiles.Rows.Clear();

            try
            {
                filesPath = Directory.GetFiles(folderPath);
                for (int i = 0; i < filesPath.Length; i++)
                {
                    if (filesPath[i].Contains(".xlsx") || 
                        filesPath[i].Contains(".xls") ||
                        filesPath[i].Contains(".csv"))
                    {
                        string[] path = filesPath[i].Split('\\');
                        string name = path[path.Length - 1];

                        string[] newRow = new string[] { (i + 1).ToString(), filesPath[i], name, "0%" };
                        dataFiles.Rows.Add(newRow);
                    }
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void tbFilePath_TextChanged(object sender, EventArgs e)
        {
            folderPath = tbFilePath.Text;
            LoadFolder(tbFilePath.Text);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                folderPath = dialog.SelectedPath;
                tbFilePath.Text = folderPath;
                LoadFolder(folderPath);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.btnStart.Enabled = false;
            this.tbFilePath.Enabled = false;
            this.btnBrowse.Enabled = false;
            this.btnStop.Enabled = true;

            insertThread = new Thread(new ThreadStart(Start));
            insertThread.Start();
        }

        private void Start()
        {
            for (int i = 0; i < filesPath.Length; i++)
            {
                SetFocusDataFiles(i, 0);

                DataSet dataSet = new DataSet();

                if (Path.GetExtension(filesPath[i]).Equals(".csv"))
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.AddRange(new DataColumn[5] { 
                        new DataColumn("", typeof(string)),
                        new DataColumn("", typeof(string)),
                        new DataColumn("",typeof(string)),
                        new DataColumn("",typeof(string)),
                        new DataColumn("",typeof(string)) });

                    string csvData = File.ReadAllText(filesPath[i]);
                    foreach (string row in csvData.Split('\n', '\r'))
                    {
                        if (!string.IsNullOrEmpty(row))
                        {
                            dataTable.Rows.Add();
                            int index = 0;
                            string[] cells = row.Split(',');
                            foreach (string cell in cells)
                            {
                                dataTable.Rows[dataTable.Rows.Count - 1][index] = cell;
                                index++;
                            }
                        }
                    }

                    dataSet.Tables.Add(dataTable);
                }
                else
                {
                    dataSet = GetDataExcel(filesPath[i], "Sheet1");
                }

                for (int i1 = 0; i1 < dataSet.Tables.Count; i1++)
                {
                    DataTable table = dataSet.Tables[i1];
                    for (int i2 = 0; i2 < table.Rows.Count; i2++)
                    {
                        Array arr = table.Rows[i2].ItemArray.ToArray();
                        bool result = dataManager.InsertData(arr);

                        dataFiles.Rows[i].Cells[3].Value = (int)(((i2 * 100) / table.Rows.Count) + 1) + "%";
                    }
                }
            }
        }

        delegate void SetFocusDataFilesCallBack(int row, int cell);
        private void SetFocusDataFiles(int row, int cell)
        {
            if(dataFiles.InvokeRequired)
            {
                SetFocusDataFilesCallBack d = new SetFocusDataFilesCallBack(SetFocusDataFiles);
                this.Invoke(d, new object[] { row, cell });
            }
            else
            {
                dataFiles.CurrentCell = dataFiles.Rows[row].Cells[cell];
            }
        }

        private string OpenExcelFile(string fPath)
        {
            string type = Path.GetExtension(fPath);
            string connectionstring = String.Empty;

            if (type == ".xls")
            {
                connectionstring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fPath + ";Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=1\"";
            }
            else if (type == ".xlsx")
            {
                connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fPath + ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"";
            }

            return connectionstring;
        }

        private DataSet GetDataExcel(string filePath, string sheetName)
        {
            DataSet dataSet = new DataSet();

            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            return dataSet;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if(insertThread.IsAlive)
            {
                this.btnStart.Enabled = true;
                this.tbFilePath.Enabled = true;
                this.btnBrowse.Enabled = true;
                this.btnStop.Enabled = false;
                insertThread.Abort();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {

        }
    }
}
