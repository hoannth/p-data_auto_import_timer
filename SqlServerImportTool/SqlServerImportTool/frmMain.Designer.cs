namespace SqlServerImportTool
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btImportStart = new DevExpress.XtraBars.BarButtonItem();
            this.btImportStop = new DevExpress.XtraBars.BarButtonItem();
            this.btSettingSave = new DevExpress.XtraBars.BarButtonItem();
            this.tbSettingReset = new DevExpress.XtraBars.BarButtonItem();
            this.btUpdateStart = new DevExpress.XtraBars.BarButtonItem();
            this.btUpdateStop = new DevExpress.XtraBars.BarButtonItem();
            this.lbImportStatus = new DevExpress.XtraBars.BarStaticItem();
            this.lbUpdateStatus = new DevExpress.XtraBars.BarStaticItem();
            this.btImportFolder = new DevExpress.XtraBars.BarButtonItem();
            this.btImportTable = new DevExpress.XtraBars.BarButtonItem();
            this.btUpdateFolder = new DevExpress.XtraBars.BarButtonItem();
            this.btUpdateTable = new DevExpress.XtraBars.BarButtonItem();
            this.pageImport = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupImport = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageUpdate = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageSetting = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.mainControl = new DevExpress.XtraEditors.PanelControl();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationIcon = ((System.Drawing.Bitmap)(resources.GetObject("ribbon.ApplicationIcon")));
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btImportStart,
            this.btImportStop,
            this.btSettingSave,
            this.tbSettingReset,
            this.btUpdateStart,
            this.btUpdateStop,
            this.lbImportStatus,
            this.lbUpdateStatus,
            this.btImportFolder,
            this.btImportTable,
            this.btUpdateFolder,
            this.btUpdateTable});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 15;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.pageImport,
            this.pageUpdate,
            this.pageSetting});
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(990, 163);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            this.ribbon.SelectedPageChanged += new System.EventHandler(this.ribbon_SelectedPageChanged);
            // 
            // btImportStart
            // 
            this.btImportStart.Caption = "Start";
            this.btImportStart.Glyph = ((System.Drawing.Image)(resources.GetObject("btImportStart.Glyph")));
            this.btImportStart.Id = 2;
            this.btImportStart.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btImportStart.LargeGlyph")));
            this.btImportStart.LargeWidth = 70;
            this.btImportStart.Name = "btImportStart";
            this.btImportStart.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btImportStart.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btImportStart_ItemClick);
            // 
            // btImportStop
            // 
            this.btImportStop.Caption = "Stop";
            this.btImportStop.Glyph = ((System.Drawing.Image)(resources.GetObject("btImportStop.Glyph")));
            this.btImportStop.Id = 3;
            this.btImportStop.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btImportStop.LargeGlyph")));
            this.btImportStop.LargeWidth = 70;
            this.btImportStop.Name = "btImportStop";
            this.btImportStop.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btImportStop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btImportStop_ItemClick);
            // 
            // btSettingSave
            // 
            this.btSettingSave.Caption = "Save";
            this.btSettingSave.Glyph = ((System.Drawing.Image)(resources.GetObject("btSettingSave.Glyph")));
            this.btSettingSave.Id = 4;
            this.btSettingSave.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btSettingSave.LargeGlyph")));
            this.btSettingSave.LargeWidth = 70;
            this.btSettingSave.Name = "btSettingSave";
            this.btSettingSave.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btSettingSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btSettingSave_ItemClick);
            // 
            // tbSettingReset
            // 
            this.tbSettingReset.Caption = "Reset";
            this.tbSettingReset.Glyph = ((System.Drawing.Image)(resources.GetObject("tbSettingReset.Glyph")));
            this.tbSettingReset.Id = 5;
            this.tbSettingReset.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tbSettingReset.LargeGlyph")));
            this.tbSettingReset.LargeWidth = 70;
            this.tbSettingReset.Name = "tbSettingReset";
            this.tbSettingReset.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.tbSettingReset.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbSettingReset_ItemClick);
            // 
            // btUpdateStart
            // 
            this.btUpdateStart.Caption = "Start";
            this.btUpdateStart.Glyph = ((System.Drawing.Image)(resources.GetObject("btUpdateStart.Glyph")));
            this.btUpdateStart.Id = 6;
            this.btUpdateStart.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btUpdateStart.LargeGlyph")));
            this.btUpdateStart.LargeWidth = 70;
            this.btUpdateStart.Name = "btUpdateStart";
            this.btUpdateStart.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btUpdateStart.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btUpdateStart_ItemClick);
            // 
            // btUpdateStop
            // 
            this.btUpdateStop.Caption = "Stop";
            this.btUpdateStop.Glyph = ((System.Drawing.Image)(resources.GetObject("btUpdateStop.Glyph")));
            this.btUpdateStop.Id = 7;
            this.btUpdateStop.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btUpdateStop.LargeGlyph")));
            this.btUpdateStop.LargeWidth = 70;
            this.btUpdateStop.Name = "btUpdateStop";
            this.btUpdateStop.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btUpdateStop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btUpdateStop_ItemClick);
            // 
            // lbImportStatus
            // 
            this.lbImportStatus.Caption = "Status:";
            this.lbImportStatus.Id = 8;
            this.lbImportStatus.Name = "lbImportStatus";
            this.lbImportStatus.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.lbImportStatus.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // lbUpdateStatus
            // 
            this.lbUpdateStatus.Caption = "Status:";
            this.lbUpdateStatus.Id = 10;
            this.lbUpdateStatus.Name = "lbUpdateStatus";
            this.lbUpdateStatus.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // btImportFolder
            // 
            this.btImportFolder.Caption = "Folder";
            this.btImportFolder.Glyph = ((System.Drawing.Image)(resources.GetObject("btImportFolder.Glyph")));
            this.btImportFolder.Id = 11;
            this.btImportFolder.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btImportFolder.LargeGlyph")));
            this.btImportFolder.LargeWidth = 70;
            this.btImportFolder.Name = "btImportFolder";
            this.btImportFolder.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btImportFolder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btImportFolder_ItemClick);
            // 
            // btImportTable
            // 
            this.btImportTable.Caption = "Table";
            this.btImportTable.Glyph = ((System.Drawing.Image)(resources.GetObject("btImportTable.Glyph")));
            this.btImportTable.Id = 12;
            this.btImportTable.LargeWidth = 70;
            this.btImportTable.Name = "btImportTable";
            this.btImportTable.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btImportTable.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btImportTable_ItemClick);
            // 
            // btUpdateFolder
            // 
            this.btUpdateFolder.Caption = "Folder";
            this.btUpdateFolder.Glyph = ((System.Drawing.Image)(resources.GetObject("btUpdateFolder.Glyph")));
            this.btUpdateFolder.Id = 13;
            this.btUpdateFolder.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btUpdateFolder.LargeGlyph")));
            this.btUpdateFolder.LargeWidth = 70;
            this.btUpdateFolder.Name = "btUpdateFolder";
            this.btUpdateFolder.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btUpdateFolder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btUpdateFolder_ItemClick);
            // 
            // btUpdateTable
            // 
            this.btUpdateTable.Caption = "Table";
            this.btUpdateTable.Glyph = ((System.Drawing.Image)(resources.GetObject("btUpdateTable.Glyph")));
            this.btUpdateTable.Id = 14;
            this.btUpdateTable.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btUpdateTable.LargeGlyph")));
            this.btUpdateTable.LargeWidth = 70;
            this.btUpdateTable.Name = "btUpdateTable";
            this.btUpdateTable.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btUpdateTable.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btUpdateTable_ItemClick);
            // 
            // pageImport
            // 
            this.pageImport.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageImport.Appearance.Options.UseFont = true;
            this.pageImport.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroupImport,
            this.ribbonPageGroup5});
            this.pageImport.Image = ((System.Drawing.Image)(resources.GetObject("pageImport.Image")));
            this.pageImport.Name = "pageImport";
            this.pageImport.Text = "Import";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.lbImportStatus);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Import Status";
            // 
            // ribbonPageGroupImport
            // 
            this.ribbonPageGroupImport.AllowTextClipping = false;
            this.ribbonPageGroupImport.ItemLinks.Add(this.btImportStart);
            this.ribbonPageGroupImport.ItemLinks.Add(this.btImportStop);
            this.ribbonPageGroupImport.Name = "ribbonPageGroupImport";
            this.ribbonPageGroupImport.ShowCaptionButton = false;
            this.ribbonPageGroupImport.Text = "Import Action";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.AllowTextClipping = false;
            this.ribbonPageGroup5.ItemLinks.Add(this.btImportFolder);
            this.ribbonPageGroup5.ItemLinks.Add(this.btImportTable);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.ShowCaptionButton = false;
            this.ribbonPageGroup5.Text = "Import Setting";
            // 
            // pageUpdate
            // 
            this.pageUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageUpdate.Appearance.Options.UseFont = true;
            this.pageUpdate.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup2,
            this.ribbonPageGroup6});
            this.pageUpdate.Image = ((System.Drawing.Image)(resources.GetObject("pageUpdate.Image")));
            this.pageUpdate.Name = "pageUpdate";
            this.pageUpdate.Text = "Update";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.AllowTextClipping = false;
            this.ribbonPageGroup4.ItemLinks.Add(this.lbUpdateStatus);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            this.ribbonPageGroup4.Text = "Update Status";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.btUpdateStart);
            this.ribbonPageGroup2.ItemLinks.Add(this.btUpdateStop);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Update Action";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.AllowTextClipping = false;
            this.ribbonPageGroup6.ItemLinks.Add(this.btUpdateFolder);
            this.ribbonPageGroup6.ItemLinks.Add(this.btUpdateTable);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.ShowCaptionButton = false;
            this.ribbonPageGroup6.Text = "Update Setting";
            // 
            // pageSetting
            // 
            this.pageSetting.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageSetting.Appearance.Options.UseFont = true;
            this.pageSetting.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.pageSetting.Image = ((System.Drawing.Image)(resources.GetObject("pageSetting.Image")));
            this.pageSetting.Name = "pageSetting";
            this.pageSetting.Text = "Setting";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btSettingSave);
            this.ribbonPageGroup1.ItemLinks.Add(this.tbSettingReset);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Data";
            // 
            // mainControl
            // 
            this.mainControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainControl.Location = new System.Drawing.Point(0, 163);
            this.mainControl.LookAndFeel.SkinName = "Office 2010 Blue";
            this.mainControl.Margin = new System.Windows.Forms.Padding(0);
            this.mainControl.Name = "mainControl";
            this.mainControl.Size = new System.Drawing.Size(990, 567);
            this.mainControl.TabIndex = 6;
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(107, 48);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(990, 730);
            this.Controls.Add(this.mainControl);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL Server Import Tool";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageImport;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageUpdate;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageSetting;
        private DevExpress.XtraEditors.PanelControl mainControl;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupImport;
        private DevExpress.XtraBars.BarButtonItem btImportStart;
        private DevExpress.XtraBars.BarButtonItem btImportStop;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btSettingSave;
        private DevExpress.XtraBars.BarButtonItem tbSettingReset;
        private DevExpress.XtraBars.BarButtonItem btUpdateStart;
        private DevExpress.XtraBars.BarButtonItem btUpdateStop;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarStaticItem lbImportStatus;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarStaticItem lbUpdateStatus;
        private DevExpress.XtraBars.BarButtonItem btImportFolder;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btImportTable;
        private DevExpress.XtraBars.BarButtonItem btUpdateFolder;
        private DevExpress.XtraBars.BarButtonItem btUpdateTable;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    }
}