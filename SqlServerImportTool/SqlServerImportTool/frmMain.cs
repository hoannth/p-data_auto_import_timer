using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Collections;
using DevExpress.XtraEditors;

namespace SqlServerImportTool
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private enum EnumControl
        {
            CONTROL_IMPORT,
            CONTROL_UPDATE,
            CONTROL_SETTING
        }

        private ControlImport controlImport;
        private ControlUpdate controlUpdate;
        private ControlSetting controlSetting;

        public frmMain()
        {
            InitializeComponent();

            lbImportStatus.Caption = "Status: Stopped";
            lbUpdateStatus.Caption = "Status: Stopped";

            controlImport = new ControlImport();
            mainControl.Controls.Add(controlImport);
            controlImport.Dock = DockStyle.Fill;

            controlUpdate = new ControlUpdate();
            mainControl.Controls.Add(controlUpdate);
            controlUpdate.Dock = DockStyle.Fill;

            controlSetting = new ControlSetting();
            mainControl.Controls.Add(controlSetting);
            controlSetting.Dock = DockStyle.Fill;

            try
            {
                ArrayList settings = UtilsLib.ReadFile(Define.SETTING_FILE_NAME);
                string serverName = settings[0].ToString();
                string databaseName = settings[1].ToString();
                string tableName = settings[2].ToString();

                string connectString = "Data Source=" + serverName + ";Initial Catalog=" + databaseName + ";Integrated Security=True";

                DataManager.CONNECTION_STRING = connectString;

                DataTable columnsData = new DataTable();
                columnsData.Columns.Add("STT", typeof(string));
                columnsData.Columns.Add("Column name", typeof(string));

                for (int i = 3; i < settings.Count; i++)
                {
                    string column = settings[i].ToString();

                    string[] newRow = new string[] { (i - 2).ToString(), column };
                    columnsData.Rows.Add(newRow);
                }

                controlSetting.LoadSettings(serverName, databaseName, tableName, columnsData);
                controlImport.UpdateInfo(controlSetting.tableName, controlSetting.columnsData);
                controlUpdate.UpdateInfo(controlSetting.tableName, controlSetting.columnsData);
            }
            catch (Exception ex)
            {
            }

            SetVisibleControl(EnumControl.CONTROL_IMPORT);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (controlSetting.isChanged && !controlSetting.isSaved)
            {
                DialogResult result = XtraMessageBox.Show("Do you want to save your settings?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    controlSetting.SaveSetting();
                }
            }
        }

        private void ShowApp()
        {
            this.Show();
            this.ShowIcon = true;
            this.ShowInTaskbar = true;
            this.Size = new Size(1000, 735);
            this.WindowState = FormWindowState.Normal;
        }

        private void UnShowApp()
        {
            this.Hide();
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
        }

        private void ribbon_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                UnShowApp();
            }
        }

        private void ribbon_SelectedPageChanged(object sender, EventArgs e)
        {
            if(ribbon.SelectedPage.PageIndex == 0)
            {
                SetVisibleControl(EnumControl.CONTROL_IMPORT);
            }
            else if (ribbon.SelectedPage.PageIndex == 1)
            {
                SetVisibleControl(EnumControl.CONTROL_UPDATE);
            }
            else if (ribbon.SelectedPage.PageIndex == 2)
            {
                SetVisibleControl(EnumControl.CONTROL_SETTING);
            }
        }

        #region Visible control

        private void SetVisibleControl(EnumControl index)
        {
            try
            {
                if (index == EnumControl.CONTROL_IMPORT)
                {
                    controlImport.ShowControl();
                    controlUpdate.HideControl();
                    controlSetting.HideControl();

                    if(controlSetting.isChanged)
                    {
                        controlImport.UpdateInfo(controlSetting.tableName, controlSetting.columnsData.Copy());
                    }
                }
                else if (index == EnumControl.CONTROL_UPDATE)
                {
                    controlImport.HideControl();
                    controlUpdate.ShowControl();
                    controlSetting.HideControl();

                    if (controlSetting.isChanged)
                    {
                        controlUpdate.UpdateInfo(controlSetting.tableName, controlSetting.columnsData.Copy());
                    }
                }
                else if (index == EnumControl.CONTROL_SETTING)
                {
                    controlImport.HideControl();
                    controlUpdate.HideControl();
                    controlSetting.ShowControl();
                }
            }
            catch (Exception ex)
            {

            }
        }

        #endregion

        #region Import

        private void btImportStart_ItemClick(object sender, ItemClickEventArgs e)
        {
            controlImport.StartImport();
        }

        private void btImportStop_ItemClick(object sender, ItemClickEventArgs e)
        {
            controlImport.StopImport();
        }

        private void btImportFolder_ItemClick(object sender, ItemClickEventArgs e)
        {
            controlImport.SelectFolder();
        }

        private void btImportTable_ItemClick(object sender, ItemClickEventArgs e)
        {
            controlImport.SelectTable();
        }

        #endregion

        #region Update

        private void btUpdateStart_ItemClick(object sender, ItemClickEventArgs e)
        {
            controlUpdate.StartUpdate();
        }

        private void btUpdateStop_ItemClick(object sender, ItemClickEventArgs e)
        {
            controlUpdate.StopUpdate();
        }

        private void btUpdateFolder_ItemClick(object sender, ItemClickEventArgs e)
        {
            controlUpdate.SelectFolder();
        }

        private void btUpdateTable_ItemClick(object sender, ItemClickEventArgs e)
        {
            controlUpdate.SelectTable();
        }

        #endregion

        #region Control Setting

        private void btSettingSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            controlSetting.SaveSetting();
        }

        private void tbSettingReset_ItemClick(object sender, ItemClickEventArgs e)
        {
            controlSetting.ResetSetting();
        }

        #endregion

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowApp();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            ShowApp();
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                UnShowApp();
            }
        }
    }
}