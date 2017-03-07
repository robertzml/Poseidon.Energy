namespace Poseidon.Energy.ClientDx
{
    partial class FrmExpenseOverview
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.accountTree = new Poseidon.Energy.ClientDx.ExpenseAccountTree();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.tabInfo = new DevExpress.XtraTab.XtraTabControl();
            this.tabPageAccount = new DevExpress.XtraTab.XtraTabPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtShortName = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabPageWaterMeter = new DevExpress.XtraTab.XtraTabPage();
            this.waterMeterGrid1 = new Poseidon.Energy.ClientDx.WaterMeterGrid();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnAddWater = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabInfo)).BeginInit();
            this.tabInfo.SuspendLayout();
            this.tabPageAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtShortName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.tabPageWaterMeter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(863, 510);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.accountTree);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.tableLayoutPanel1.SetRowSpan(this.groupControl1, 2);
            this.groupControl1.Size = new System.Drawing.Size(194, 504);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "支出账户";
            // 
            // accountTree
            // 
            this.accountTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountTree.Location = new System.Drawing.Point(2, 21);
            this.accountTree.Name = "accountTree";
            this.accountTree.Size = new System.Drawing.Size(190, 481);
            this.accountTree.TabIndex = 0;
            this.accountTree.AccountSelected += new System.EventHandler(this.accountTree_AccountSelected);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.tabInfo);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(203, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(657, 194);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "基本信息";
            // 
            // tabInfo
            // 
            this.tabInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabInfo.Location = new System.Drawing.Point(2, 21);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.SelectedTabPage = this.tabPageAccount;
            this.tabInfo.Size = new System.Drawing.Size(653, 171);
            this.tabInfo.TabIndex = 0;
            this.tabInfo.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPageAccount,
            this.tabPageWaterMeter});
            // 
            // tabPageAccount
            // 
            this.tabPageAccount.Controls.Add(this.layoutControl1);
            this.tabPageAccount.Name = "tabPageAccount";
            this.tabPageAccount.Size = new System.Drawing.Size(647, 142);
            this.tabPageAccount.Text = "账户信息";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnAddWater);
            this.layoutControl1.Controls.Add(this.txtShortName);
            this.layoutControl1.Controls.Add(this.txtName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(647, 142);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtShortName
            // 
            this.txtShortName.Location = new System.Drawing.Point(352, 12);
            this.txtShortName.Name = "txtShortName";
            this.txtShortName.Size = new System.Drawing.Size(283, 20);
            this.txtShortName.StyleController = this.layoutControl1;
            this.txtShortName.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(39, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(282, 20);
            this.txtName.StyleController = this.layoutControl1;
            this.txtName.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlGroup3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(647, 142);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(313, 24);
            this.layoutControlItem1.Text = "名称";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(24, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtShortName;
            this.layoutControlItem2.Location = new System.Drawing.Point(313, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(314, 24);
            this.layoutControlItem2.Text = "简称";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(24, 14);
            // 
            // tabPageWaterMeter
            // 
            this.tabPageWaterMeter.Controls.Add(this.layoutControl2);
            this.tabPageWaterMeter.Name = "tabPageWaterMeter";
            this.tabPageWaterMeter.Size = new System.Drawing.Size(647, 142);
            this.tabPageWaterMeter.Text = "水表表具";
            // 
            // waterMeterGrid1
            // 
            this.waterMeterGrid1.AllowFilter = false;
            this.waterMeterGrid1.AllowGroup = false;
            this.waterMeterGrid1.AllowSort = true;
            this.waterMeterGrid1.DataSource = null;
            this.waterMeterGrid1.Editable = false;
            this.waterMeterGrid1.Location = new System.Drawing.Point(12, 12);
            this.waterMeterGrid1.Name = "waterMeterGrid1";
            this.waterMeterGrid1.ShowAddMenu = false;
            this.waterMeterGrid1.ShowFooter = false;
            this.waterMeterGrid1.ShowLineNumber = true;
            this.waterMeterGrid1.ShowNavigator = false;
            this.waterMeterGrid1.Size = new System.Drawing.Size(623, 118);
            this.waterMeterGrid1.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(203, 203);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(657, 304);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "groupControl3";
            // 
            // btnAddWater
            // 
            this.btnAddWater.Location = new System.Drawing.Point(24, 69);
            this.btnAddWater.Name = "btnAddWater";
            this.btnAddWater.Size = new System.Drawing.Size(599, 22);
            this.btnAddWater.StyleController = this.layoutControl1;
            this.btnAddWater.TabIndex = 0;
            this.btnAddWater.Text = "登记水费支出";
            this.btnAddWater.Click += new System.EventHandler(this.btnAddWater_Click);
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.waterMeterGrid1);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(647, 142);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(647, 142);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.waterMeterGrid1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(627, 122);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnAddWater;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(603, 53);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(627, 98);
            this.layoutControlGroup3.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 2);
            this.layoutControlGroup3.Text = "操作";
            // 
            // FrmExpenseOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 510);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmExpenseOverview";
            this.Text = "支出总览";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabInfo)).EndInit();
            this.tabInfo.ResumeLayout(false);
            this.tabPageAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtShortName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.tabPageWaterMeter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private ExpenseAccountTree accountTree;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnAddWater;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraTab.XtraTabControl tabInfo;
        private DevExpress.XtraTab.XtraTabPage tabPageAccount;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraTab.XtraTabPage tabPageWaterMeter;
        private DevExpress.XtraEditors.TextEdit txtShortName;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private WaterMeterGrid waterMeterGrid1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}