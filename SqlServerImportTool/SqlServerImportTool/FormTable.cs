using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SqlServerImportTool
{
    public partial class FormTable : DevExpress.XtraEditors.XtraForm
    {
        public DataTable dataLeftSource;
        public DataTable dataRightSource;

        public FormTable(string title, DataTable _dataLeftSource)
        {
            InitializeComponent();

            this.Text = title;

            if (_dataLeftSource == null)
            {
                dataLeftSource = new DataTable();
                dataLeftSource.Columns.Add("STT", typeof(string));
                dataLeftSource.Columns.Add("Column name", typeof(string));
            }
            else
            {
                dataLeftSource = _dataLeftSource.Copy();
            }

            dataLeft.DataSource = dataLeftSource;

            gridViewLeft.OptionsView.ColumnAutoWidth = false;
            gridViewLeft.Columns[0].Width = 70;
            gridViewLeft.Columns[1].Width = 300;

            dataRightSource = new DataTable();
            dataRightSource.Columns.Add("STT", typeof(string));
            dataRightSource.Columns.Add("Column name", typeof(string));

            dataRight.DataSource = dataRightSource;

            gridViewRight.OptionsView.ColumnAutoWidth = false;
            gridViewRight.Columns[0].Width = 70;
            gridViewRight.Columns[1].Width = 300;

            dataRight.DataSource = dataRightSource;
        }

        private void btChoose_Click(object sender, EventArgs e)
        {
            if (gridViewLeft.FocusedRowHandle >= 0)
            {
                string selectValue = gridViewLeft.GetRowCellValue(gridViewLeft.FocusedRowHandle, "Column name").ToString();

                DataRow[] rows = new DataRow[gridViewLeft.SelectedRowsCount];
                for (int i = 0; i < gridViewLeft.SelectedRowsCount; i++)
                {
                    rows[i] = gridViewLeft.GetDataRow(gridViewLeft.GetSelectedRows()[i]);
                }

                foreach (DataRow row in rows)
                {
                    row.Delete();
                }

                if (gridViewLeft.FocusedRowHandle >= 0 && gridViewLeft.FocusedRowHandle < gridViewLeft.DataRowCount)
                {

                    for (int i = gridViewLeft.FocusedRowHandle; i < gridViewLeft.DataRowCount; i++)
                    {
                        gridViewLeft.SetRowCellValue(i, "STT", i + 1);
                    }
                }

                string[] newRow = new string[] { (dataRightSource.Rows.Count + 1).ToString(), selectValue };
                dataRightSource.Rows.Add(newRow);

                dataRight.DataSource = dataRightSource;
                dataRight.Refresh();
                dataRight.RefreshDataSource();
            }
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            if (gridViewRight.FocusedRowHandle >= 0)
            {
                string selectValue = gridViewRight.GetRowCellValue(gridViewRight.FocusedRowHandle, "Column name").ToString();

                DataRow[] rows = new DataRow[gridViewRight.SelectedRowsCount];
                for (int i = 0; i < gridViewRight.SelectedRowsCount; i++)
                {
                    rows[i] = gridViewRight.GetDataRow(gridViewRight.GetSelectedRows()[i]);
                }

                foreach (DataRow row in rows)
                {
                    row.Delete();
                }

                if (gridViewRight.FocusedRowHandle >= 0 && gridViewRight.FocusedRowHandle < gridViewRight.DataRowCount)
                {

                    for (int i = gridViewRight.FocusedRowHandle; i < gridViewRight.DataRowCount; i++)
                    {
                        gridViewRight.SetRowCellValue(i, "STT", i + 1);
                    }
                }

                string[] newRow = new string[] { (dataLeftSource.Rows.Count + 1).ToString(), selectValue };
                dataLeftSource.Rows.Add(newRow);

                dataLeft.DataSource = dataLeftSource;
                dataLeft.Refresh();
                dataLeft.RefreshDataSource();
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void dataLeft_DoubleClick(object sender, EventArgs e)
        {
            btChoose.PerformClick();
        }

        private void dataRight_DoubleClick(object sender, EventArgs e)
        {
            btRemove.PerformClick();
        }
    }
}