namespace SqlServerImportTool
{
    partial class ControlSetting
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlSetting));
            this.groupControlSettingDataSource = new DevExpress.XtraEditors.GroupControl();
            this.tbDatabaseName = new DevExpress.XtraEditors.TextEdit();
            this.btTestConnection = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.tbTableName = new DevExpress.XtraEditors.TextEdit();
            this.tbServerName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tbConnectionString = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControlSettingTable = new DevExpress.XtraEditors.GroupControl();
            this.dataColumns = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btAddColumn = new DevExpress.XtraEditors.SimpleButton();
            this.tbColumnName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlSettingDataSource)).BeginInit();
            this.groupControlSettingDataSource.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDatabaseName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTableName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbServerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbConnectionString.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlSettingTable)).BeginInit();
            this.groupControlSettingTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbColumnName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControlSettingDataSource
            // 
            this.groupControlSettingDataSource.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControlSettingDataSource.Appearance.Options.UseFont = true;
            this.groupControlSettingDataSource.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControlSettingDataSource.AppearanceCaption.Options.UseFont = true;
            this.groupControlSettingDataSource.Controls.Add(this.tbDatabaseName);
            this.groupControlSettingDataSource.Controls.Add(this.btTestConnection);
            this.groupControlSettingDataSource.Controls.Add(this.labelControl4);
            this.groupControlSettingDataSource.Controls.Add(this.tbTableName);
            this.groupControlSettingDataSource.Controls.Add(this.tbServerName);
            this.groupControlSettingDataSource.Controls.Add(this.labelControl3);
            this.groupControlSettingDataSource.Controls.Add(this.labelControl2);
            this.groupControlSettingDataSource.Controls.Add(this.tbConnectionString);
            this.groupControlSettingDataSource.Controls.Add(this.labelControl1);
            this.groupControlSettingDataSource.Location = new System.Drawing.Point(7, 13);
            this.groupControlSettingDataSource.LookAndFeel.SkinName = "Office 2010 Blue";
            this.groupControlSettingDataSource.Name = "groupControlSettingDataSource";
            this.groupControlSettingDataSource.Size = new System.Drawing.Size(963, 155);
            this.groupControlSettingDataSource.TabIndex = 0;
            this.groupControlSettingDataSource.Text = "Datasource";
            // 
            // tbDatabaseName
            // 
            this.tbDatabaseName.Location = new System.Drawing.Point(172, 115);
            this.tbDatabaseName.Name = "tbDatabaseName";
            this.tbDatabaseName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDatabaseName.Properties.Appearance.Options.UseFont = true;
            this.tbDatabaseName.Size = new System.Drawing.Size(290, 28);
            this.tbDatabaseName.TabIndex = 5;
            this.tbDatabaseName.TextChanged += new System.EventHandler(this.tbDatabaseName_TextChanged);
            // 
            // btTestConnection
            // 
            this.btTestConnection.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTestConnection.Appearance.Options.UseFont = true;
            this.btTestConnection.Image = ((System.Drawing.Image)(resources.GetObject("btTestConnection.Image")));
            this.btTestConnection.Location = new System.Drawing.Point(765, 73);
            this.btTestConnection.LookAndFeel.SkinName = "Office 2010 Blue";
            this.btTestConnection.Name = "btTestConnection";
            this.btTestConnection.Size = new System.Drawing.Size(170, 38);
            this.btTestConnection.TabIndex = 7;
            this.btTestConnection.Text = "Test Connection";
            this.btTestConnection.Click += new System.EventHandler(this.btTestConnection_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(16, 118);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(77, 21);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Database:";
            // 
            // tbTableName
            // 
            this.tbTableName.Location = new System.Drawing.Point(645, 115);
            this.tbTableName.Name = "tbTableName";
            this.tbTableName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTableName.Properties.Appearance.Options.UseFont = true;
            this.tbTableName.Size = new System.Drawing.Size(290, 28);
            this.tbTableName.TabIndex = 6;
            this.tbTableName.TextChanged += new System.EventHandler(this.tbTableName_TextChanged);
            // 
            // tbServerName
            // 
            this.tbServerName.Location = new System.Drawing.Point(172, 77);
            this.tbServerName.Name = "tbServerName";
            this.tbServerName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbServerName.Properties.Appearance.Options.UseFont = true;
            this.tbServerName.Size = new System.Drawing.Size(290, 28);
            this.tbServerName.TabIndex = 4;
            this.tbServerName.TextChanged += new System.EventHandler(this.tbServerName_TextChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(534, 118);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(95, 21);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Table Name:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(16, 80);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(101, 21);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Server Name:";
            // 
            // tbConnectionString
            // 
            this.tbConnectionString.Location = new System.Drawing.Point(172, 43);
            this.tbConnectionString.Name = "tbConnectionString";
            this.tbConnectionString.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConnectionString.Properties.Appearance.Options.UseFont = true;
            this.tbConnectionString.Properties.ReadOnly = true;
            this.tbConnectionString.Size = new System.Drawing.Size(763, 28);
            this.tbConnectionString.TabIndex = 3;
            this.tbConnectionString.TextChanged += new System.EventHandler(this.tbConnectionString_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(16, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(136, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Connection String:";
            // 
            // groupControlSettingTable
            // 
            this.groupControlSettingTable.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControlSettingTable.Appearance.Options.UseFont = true;
            this.groupControlSettingTable.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControlSettingTable.AppearanceCaption.Options.UseFont = true;
            this.groupControlSettingTable.Controls.Add(this.dataColumns);
            this.groupControlSettingTable.Controls.Add(this.btAddColumn);
            this.groupControlSettingTable.Controls.Add(this.tbColumnName);
            this.groupControlSettingTable.Controls.Add(this.labelControl5);
            this.groupControlSettingTable.Location = new System.Drawing.Point(7, 174);
            this.groupControlSettingTable.LookAndFeel.SkinName = "Office 2010 Blue";
            this.groupControlSettingTable.Name = "groupControlSettingTable";
            this.groupControlSettingTable.Size = new System.Drawing.Size(963, 380);
            this.groupControlSettingTable.TabIndex = 1;
            this.groupControlSettingTable.Text = "Table";
            // 
            // dataColumns
            // 
            this.dataColumns.Location = new System.Drawing.Point(560, 31);
            this.dataColumns.LookAndFeel.SkinName = "Office 2010 Blue";
            this.dataColumns.MainView = this.gridView;
            this.dataColumns.Name = "dataColumns";
            this.dataColumns.Size = new System.Drawing.Size(375, 344);
            this.dataColumns.TabIndex = 10;
            this.dataColumns.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView.Appearance.Row.Options.UseFont = true;
            this.gridView.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView.GridControl = this.dataColumns;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsCustomization.AllowFilter = false;
            this.gridView.OptionsCustomization.AllowSort = false;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.OptionsView.ShowIndicator = false;
            this.gridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_CellValueChanged);
            // 
            // btAddColumn
            // 
            this.btAddColumn.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddColumn.Appearance.Options.UseFont = true;
            this.btAddColumn.Image = ((System.Drawing.Image)(resources.GetObject("btAddColumn.Image")));
            this.btAddColumn.Location = new System.Drawing.Point(435, 43);
            this.btAddColumn.LookAndFeel.SkinName = "Office 2010 Blue";
            this.btAddColumn.Name = "btAddColumn";
            this.btAddColumn.Size = new System.Drawing.Size(101, 38);
            this.btAddColumn.TabIndex = 8;
            this.btAddColumn.Text = "Add";
            this.btAddColumn.Click += new System.EventHandler(this.btAddColumn_Click);
            // 
            // tbColumnName
            // 
            this.tbColumnName.Location = new System.Drawing.Point(139, 48);
            this.tbColumnName.Name = "tbColumnName";
            this.tbColumnName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbColumnName.Properties.Appearance.Options.UseFont = true;
            this.tbColumnName.Size = new System.Drawing.Size(290, 28);
            this.tbColumnName.TabIndex = 6;
            this.tbColumnName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbColumnName_KeyUp);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(24, 51);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(109, 21);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Column Name:";
            // 
            // ControlSetting
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControlSettingTable);
            this.Controls.Add(this.groupControlSettingDataSource);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.Name = "ControlSetting";
            this.Size = new System.Drawing.Size(990, 568);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlSettingDataSource)).EndInit();
            this.groupControlSettingDataSource.ResumeLayout(false);
            this.groupControlSettingDataSource.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDatabaseName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTableName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbServerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbConnectionString.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlSettingTable)).EndInit();
            this.groupControlSettingTable.ResumeLayout(false);
            this.groupControlSettingTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbColumnName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlSettingDataSource;
        private DevExpress.XtraEditors.GroupControl groupControlSettingTable;
        private DevExpress.XtraEditors.TextEdit tbConnectionString;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tbTableName;
        private DevExpress.XtraEditors.TextEdit tbServerName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btTestConnection;
        private DevExpress.XtraEditors.TextEdit tbDatabaseName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit tbColumnName;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btAddColumn;
        private DevExpress.XtraGrid.GridControl dataColumns;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
    }
}
