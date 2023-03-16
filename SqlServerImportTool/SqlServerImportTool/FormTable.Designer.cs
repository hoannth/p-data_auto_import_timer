namespace SqlServerImportTool
{
    partial class FormTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTable));
            this.btChoose = new DevExpress.XtraEditors.SimpleButton();
            this.btRemove = new DevExpress.XtraEditors.SimpleButton();
            this.btSave = new DevExpress.XtraEditors.SimpleButton();
            this.btReset = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dataLeft = new DevExpress.XtraGrid.GridControl();
            this.gridViewLeft = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dataRight = new DevExpress.XtraGrid.GridControl();
            this.gridViewRight = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRight)).BeginInit();
            this.SuspendLayout();
            // 
            // btChoose
            // 
            this.btChoose.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChoose.Appearance.Options.UseFont = true;
            this.btChoose.Image = ((System.Drawing.Image)(resources.GetObject("btChoose.Image")));
            this.btChoose.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btChoose.Location = new System.Drawing.Point(393, 50);
            this.btChoose.Name = "btChoose";
            this.btChoose.Size = new System.Drawing.Size(125, 39);
            this.btChoose.TabIndex = 13;
            this.btChoose.Text = "Choose";
            this.btChoose.Click += new System.EventHandler(this.btChoose_Click);
            // 
            // btRemove
            // 
            this.btRemove.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemove.Appearance.Options.UseFont = true;
            this.btRemove.Image = ((System.Drawing.Image)(resources.GetObject("btRemove.Image")));
            this.btRemove.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btRemove.Location = new System.Drawing.Point(393, 95);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(125, 39);
            this.btRemove.TabIndex = 14;
            this.btRemove.Text = "Remove";
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btSave
            // 
            this.btSave.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Appearance.Options.UseFont = true;
            this.btSave.Image = ((System.Drawing.Image)(resources.GetObject("btSave.Image")));
            this.btSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btSave.Location = new System.Drawing.Point(393, 326);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(125, 39);
            this.btSave.TabIndex = 15;
            this.btSave.Text = "Save";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btReset
            // 
            this.btReset.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.Appearance.Options.UseFont = true;
            this.btReset.Image = ((System.Drawing.Image)(resources.GetObject("btReset.Image")));
            this.btReset.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btReset.Location = new System.Drawing.Point(393, 371);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(125, 39);
            this.btReset.TabIndex = 16;
            this.btReset.Text = "Cancle";
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dataLeft);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(375, 398);
            this.panelControl1.TabIndex = 17;
            // 
            // dataLeft
            // 
            this.dataLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLeft.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.dataLeft.Location = new System.Drawing.Point(0, 0);
            this.dataLeft.LookAndFeel.SkinName = "Office 2010 Blue";
            this.dataLeft.MainView = this.gridViewLeft;
            this.dataLeft.Name = "dataLeft";
            this.dataLeft.Size = new System.Drawing.Size(375, 398);
            this.dataLeft.TabIndex = 12;
            this.dataLeft.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLeft});
            this.dataLeft.DoubleClick += new System.EventHandler(this.dataLeft_DoubleClick);
            // 
            // gridViewLeft
            // 
            this.gridViewLeft.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewLeft.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewLeft.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewLeft.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewLeft.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewLeft.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewLeft.Appearance.Row.Options.UseFont = true;
            this.gridViewLeft.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewLeft.Appearance.SelectedRow.Options.UseFont = true;
            this.gridViewLeft.GridControl = this.dataLeft;
            this.gridViewLeft.Name = "gridViewLeft";
            this.gridViewLeft.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewLeft.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewLeft.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.gridViewLeft.OptionsBehavior.Editable = false;
            this.gridViewLeft.OptionsBehavior.ReadOnly = true;
            this.gridViewLeft.OptionsCustomization.AllowFilter = false;
            this.gridViewLeft.OptionsCustomization.AllowSort = false;
            this.gridViewLeft.OptionsView.ShowGroupPanel = false;
            this.gridViewLeft.OptionsView.ShowIndicator = false;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dataRight);
            this.panelControl2.Location = new System.Drawing.Point(524, 12);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(375, 398);
            this.panelControl2.TabIndex = 18;
            // 
            // dataRight
            // 
            this.dataRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataRight.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.dataRight.Location = new System.Drawing.Point(0, 0);
            this.dataRight.LookAndFeel.SkinName = "Office 2010 Blue";
            this.dataRight.MainView = this.gridViewRight;
            this.dataRight.Name = "dataRight";
            this.dataRight.Size = new System.Drawing.Size(375, 398);
            this.dataRight.TabIndex = 13;
            this.dataRight.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRight});
            this.dataRight.DoubleClick += new System.EventHandler(this.dataRight_DoubleClick);
            // 
            // gridViewRight
            // 
            this.gridViewRight.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewRight.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewRight.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewRight.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewRight.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewRight.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewRight.Appearance.Row.Options.UseFont = true;
            this.gridViewRight.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewRight.Appearance.SelectedRow.Options.UseFont = true;
            this.gridViewRight.GridControl = this.dataRight;
            this.gridViewRight.Name = "gridViewRight";
            this.gridViewRight.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewRight.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewRight.OptionsBehavior.Editable = false;
            this.gridViewRight.OptionsBehavior.ReadOnly = true;
            this.gridViewRight.OptionsCustomization.AllowFilter = false;
            this.gridViewRight.OptionsCustomization.AllowSort = false;
            this.gridViewRight.OptionsView.ShowGroupPanel = false;
            this.gridViewRight.OptionsView.ShowIndicator = false;
            // 
            // FormTable
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(913, 422);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btChoose);
            this.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormTable";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormTable";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btChoose;
        private DevExpress.XtraEditors.SimpleButton btRemove;
        private DevExpress.XtraEditors.SimpleButton btSave;
        private DevExpress.XtraEditors.SimpleButton btReset;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl dataLeft;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLeft;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl dataRight;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRight;

    }
}