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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupTree = new Poseidon.Winform.Core.GroupChildrenTree();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.tabInfo = new DevExpress.XtraTab.XtraTabControl();
            this.tabPageAccount = new DevExpress.XtraTab.XtraTabPage();
            this.ctrAccountInfo = new Poseidon.Energy.ClientDx.ExpenseAccountInfo();
            this.tabPageElectricMeter = new DevExpress.XtraTab.XtraTabPage();
            this.electricMeterGrid = new Poseidon.Energy.ClientDx.ElectricMeterGrid();
            this.tabPageWaterMeter = new DevExpress.XtraTab.XtraTabPage();
            this.waterMeterGrid = new Poseidon.Energy.ClientDx.WaterMeterGrid();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.tabFee = new DevExpress.XtraTab.XtraTabControl();
            this.tabPageSummary = new DevExpress.XtraTab.XtraTabPage();
            this.tabPageElectricCompareGrid = new DevExpress.XtraTab.XtraTabPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.modElecCompGrid = new Poseidon.Energy.ClientDx.ElectricCompareGridModule();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabPageElectricCompareChart = new DevExpress.XtraTab.XtraTabPage();
            this.modElectricCompare = new Poseidon.Energy.ClientDx.ElectricCompareModule();
            this.tabPageElectricReceipt = new DevExpress.XtraTab.XtraTabPage();
            this.electricExpenseReceipt = new Poseidon.Energy.ClientDx.ElectricExpenseReceipt();
            this.tabPageWaterCompareGrid = new DevExpress.XtraTab.XtraTabPage();
            this.layoutControl5 = new DevExpress.XtraLayout.LayoutControl();
            this.modWaterCompareGrid = new Poseidon.Energy.ClientDx.WaterCompareGridModule();
            this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabPageWaterCompareChart = new DevExpress.XtraTab.XtraTabPage();
            this.modWaterCompare = new Poseidon.Energy.ClientDx.WaterCompareModule();
            this.tabPageWaterReceipt = new DevExpress.XtraTab.XtraTabPage();
            this.waterExpenseReceipt = new Poseidon.Energy.ClientDx.WaterExpenseReceipt();
            this.bsWaterExpense = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabInfo)).BeginInit();
            this.tabInfo.SuspendLayout();
            this.tabPageAccount.SuspendLayout();
            this.tabPageElectricMeter.SuspendLayout();
            this.tabPageWaterMeter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabFee)).BeginInit();
            this.tabFee.SuspendLayout();
            this.tabPageElectricCompareGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.tabPageElectricCompareChart.SuspendLayout();
            this.tabPageElectricReceipt.SuspendLayout();
            this.tabPageWaterCompareGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl5)).BeginInit();
            this.layoutControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.tabPageWaterCompareChart.SuspendLayout();
            this.tabPageWaterReceipt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsWaterExpense)).BeginInit();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(905, 587);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupTree);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.tableLayoutPanel1.SetRowSpan(this.groupControl1, 2);
            this.groupControl1.Size = new System.Drawing.Size(194, 581);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "支出账户";
            // 
            // groupTree
            // 
            this.groupTree.CascadeOrganization = false;
            this.groupTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupTree.Location = new System.Drawing.Point(2, 21);
            this.groupTree.Name = "groupTree";
            this.groupTree.ShowFindPanel = false;
            this.groupTree.Size = new System.Drawing.Size(190, 558);
            this.groupTree.TabIndex = 1;
            this.groupTree.OrganizationSelected += new System.EventHandler(this.groupTree_OrganizationSelected);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.tabInfo);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(203, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(699, 194);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "基本信息";
            // 
            // tabInfo
            // 
            this.tabInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabInfo.Location = new System.Drawing.Point(2, 21);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.SelectedTabPage = this.tabPageAccount;
            this.tabInfo.Size = new System.Drawing.Size(695, 171);
            this.tabInfo.TabIndex = 0;
            this.tabInfo.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPageAccount,
            this.tabPageElectricMeter,
            this.tabPageWaterMeter});
            // 
            // tabPageAccount
            // 
            this.tabPageAccount.Controls.Add(this.ctrAccountInfo);
            this.tabPageAccount.Name = "tabPageAccount";
            this.tabPageAccount.Size = new System.Drawing.Size(689, 142);
            this.tabPageAccount.Text = "账户信息";
            // 
            // ctrAccountInfo
            // 
            this.ctrAccountInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrAccountInfo.Location = new System.Drawing.Point(0, 0);
            this.ctrAccountInfo.Name = "ctrAccountInfo";
            this.ctrAccountInfo.Size = new System.Drawing.Size(689, 142);
            this.ctrAccountInfo.TabIndex = 0;
            // 
            // tabPageElectricMeter
            // 
            this.tabPageElectricMeter.Controls.Add(this.electricMeterGrid);
            this.tabPageElectricMeter.Name = "tabPageElectricMeter";
            this.tabPageElectricMeter.PageVisible = false;
            this.tabPageElectricMeter.Size = new System.Drawing.Size(689, 142);
            this.tabPageElectricMeter.Text = "电表表具";
            // 
            // electricMeterGrid
            // 
            this.electricMeterGrid.AllowFilter = true;
            this.electricMeterGrid.AllowGroup = true;
            this.electricMeterGrid.AllowSort = true;
            this.electricMeterGrid.DataSource = null;
            this.electricMeterGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.electricMeterGrid.Editable = false;
            this.electricMeterGrid.EnableMasterView = false;
            this.electricMeterGrid.Location = new System.Drawing.Point(0, 0);
            this.electricMeterGrid.Name = "electricMeterGrid";
            this.electricMeterGrid.ShowAddMenu = false;
            this.electricMeterGrid.ShowFooter = false;
            this.electricMeterGrid.ShowLineNumber = true;
            this.electricMeterGrid.ShowMenu = false;
            this.electricMeterGrid.ShowNavigator = false;
            this.electricMeterGrid.Size = new System.Drawing.Size(689, 142);
            this.electricMeterGrid.TabIndex = 0;
            // 
            // tabPageWaterMeter
            // 
            this.tabPageWaterMeter.Controls.Add(this.waterMeterGrid);
            this.tabPageWaterMeter.Name = "tabPageWaterMeter";
            this.tabPageWaterMeter.PageVisible = false;
            this.tabPageWaterMeter.Size = new System.Drawing.Size(689, 142);
            this.tabPageWaterMeter.Text = "水表表具";
            // 
            // waterMeterGrid
            // 
            this.waterMeterGrid.AllowFilter = false;
            this.waterMeterGrid.AllowGroup = false;
            this.waterMeterGrid.AllowSort = true;
            this.waterMeterGrid.DataSource = null;
            this.waterMeterGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waterMeterGrid.Editable = false;
            this.waterMeterGrid.EnableMasterView = false;
            this.waterMeterGrid.Location = new System.Drawing.Point(0, 0);
            this.waterMeterGrid.Name = "waterMeterGrid";
            this.waterMeterGrid.ShowAddMenu = false;
            this.waterMeterGrid.ShowFooter = false;
            this.waterMeterGrid.ShowLineNumber = true;
            this.waterMeterGrid.ShowMenu = false;
            this.waterMeterGrid.ShowNavigator = false;
            this.waterMeterGrid.Size = new System.Drawing.Size(689, 142);
            this.waterMeterGrid.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.tabFee);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(203, 203);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(699, 381);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "费用信息";
            // 
            // tabFee
            // 
            this.tabFee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFee.Location = new System.Drawing.Point(2, 21);
            this.tabFee.Name = "tabFee";
            this.tabFee.SelectedTabPage = this.tabPageSummary;
            this.tabFee.Size = new System.Drawing.Size(695, 358);
            this.tabFee.TabIndex = 0;
            this.tabFee.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPageSummary,
            this.tabPageElectricCompareGrid,
            this.tabPageElectricCompareChart,
            this.tabPageElectricReceipt,
            this.tabPageWaterCompareGrid,
            this.tabPageWaterCompareChart,
            this.tabPageWaterReceipt});
            // 
            // tabPageSummary
            // 
            this.tabPageSummary.Name = "tabPageSummary";
            this.tabPageSummary.Size = new System.Drawing.Size(689, 329);
            this.tabPageSummary.Text = "摘要";
            // 
            // tabPageElectricCompareGrid
            // 
            this.tabPageElectricCompareGrid.Controls.Add(this.layoutControl1);
            this.tabPageElectricCompareGrid.Name = "tabPageElectricCompareGrid";
            this.tabPageElectricCompareGrid.PageVisible = false;
            this.tabPageElectricCompareGrid.Size = new System.Drawing.Size(689, 329);
            this.tabPageElectricCompareGrid.Text = "用电对比表";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.modElecCompGrid);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(689, 329);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // modElecCompGrid
            // 
            this.modElecCompGrid.Location = new System.Drawing.Point(12, 12);
            this.modElecCompGrid.Name = "modElecCompGrid";
            this.modElecCompGrid.Size = new System.Drawing.Size(665, 305);
            this.modElecCompGrid.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(689, 329);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.modElecCompGrid;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(669, 309);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // tabPageElectricCompareChart
            // 
            this.tabPageElectricCompareChart.Controls.Add(this.modElectricCompare);
            this.tabPageElectricCompareChart.Name = "tabPageElectricCompareChart";
            this.tabPageElectricCompareChart.PageVisible = false;
            this.tabPageElectricCompareChart.Size = new System.Drawing.Size(689, 329);
            this.tabPageElectricCompareChart.Text = "用电对比图";
            // 
            // modElectricCompare
            // 
            this.modElectricCompare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modElectricCompare.Location = new System.Drawing.Point(0, 0);
            this.modElectricCompare.Name = "modElectricCompare";
            this.modElectricCompare.Size = new System.Drawing.Size(689, 329);
            this.modElectricCompare.TabIndex = 0;
            // 
            // tabPageElectricReceipt
            // 
            this.tabPageElectricReceipt.Controls.Add(this.electricExpenseReceipt);
            this.tabPageElectricReceipt.Name = "tabPageElectricReceipt";
            this.tabPageElectricReceipt.PageVisible = false;
            this.tabPageElectricReceipt.Size = new System.Drawing.Size(689, 329);
            this.tabPageElectricReceipt.Text = "电费单据";
            // 
            // electricExpenseReceipt
            // 
            this.electricExpenseReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.electricExpenseReceipt.Editable = false;
            this.electricExpenseReceipt.Location = new System.Drawing.Point(0, 0);
            this.electricExpenseReceipt.Name = "electricExpenseReceipt";
            this.electricExpenseReceipt.Size = new System.Drawing.Size(689, 329);
            this.electricExpenseReceipt.TabIndex = 0;
            // 
            // tabPageWaterCompareGrid
            // 
            this.tabPageWaterCompareGrid.Controls.Add(this.layoutControl5);
            this.tabPageWaterCompareGrid.Name = "tabPageWaterCompareGrid";
            this.tabPageWaterCompareGrid.PageVisible = false;
            this.tabPageWaterCompareGrid.Size = new System.Drawing.Size(689, 329);
            this.tabPageWaterCompareGrid.Text = "用水对比表";
            // 
            // layoutControl5
            // 
            this.layoutControl5.Controls.Add(this.modWaterCompareGrid);
            this.layoutControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl5.Location = new System.Drawing.Point(0, 0);
            this.layoutControl5.Name = "layoutControl5";
            this.layoutControl5.Root = this.layoutControlGroup6;
            this.layoutControl5.Size = new System.Drawing.Size(689, 329);
            this.layoutControl5.TabIndex = 0;
            this.layoutControl5.Text = "layoutControl5";
            // 
            // modWaterCompareGrid
            // 
            this.modWaterCompareGrid.Location = new System.Drawing.Point(12, 12);
            this.modWaterCompareGrid.Name = "modWaterCompareGrid";
            this.modWaterCompareGrid.Size = new System.Drawing.Size(665, 305);
            this.modWaterCompareGrid.TabIndex = 10;
            // 
            // layoutControlGroup6
            // 
            this.layoutControlGroup6.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup6.GroupBordersVisible = false;
            this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup6.Name = "layoutControlGroup6";
            this.layoutControlGroup6.Size = new System.Drawing.Size(689, 329);
            this.layoutControlGroup6.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.modWaterCompareGrid;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(669, 309);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // tabPageWaterCompareChart
            // 
            this.tabPageWaterCompareChart.Controls.Add(this.modWaterCompare);
            this.tabPageWaterCompareChart.Name = "tabPageWaterCompareChart";
            this.tabPageWaterCompareChart.PageVisible = false;
            this.tabPageWaterCompareChart.Size = new System.Drawing.Size(689, 329);
            this.tabPageWaterCompareChart.Text = "用水对比图";
            // 
            // modWaterCompare
            // 
            this.modWaterCompare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modWaterCompare.Location = new System.Drawing.Point(0, 0);
            this.modWaterCompare.Name = "modWaterCompare";
            this.modWaterCompare.Size = new System.Drawing.Size(689, 329);
            this.modWaterCompare.TabIndex = 0;
            // 
            // tabPageWaterReceipt
            // 
            this.tabPageWaterReceipt.Controls.Add(this.waterExpenseReceipt);
            this.tabPageWaterReceipt.Name = "tabPageWaterReceipt";
            this.tabPageWaterReceipt.Size = new System.Drawing.Size(689, 329);
            this.tabPageWaterReceipt.Text = "水费单据";
            // 
            // waterExpenseReceipt
            // 
            this.waterExpenseReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waterExpenseReceipt.Editable = false;
            this.waterExpenseReceipt.Location = new System.Drawing.Point(0, 0);
            this.waterExpenseReceipt.Name = "waterExpenseReceipt";
            this.waterExpenseReceipt.Size = new System.Drawing.Size(689, 329);
            this.waterExpenseReceipt.TabIndex = 0;
            // 
            // bsWaterExpense
            // 
            this.bsWaterExpense.DataSource = typeof(Poseidon.Energy.Core.DL.WaterExpense);
            // 
            // FrmExpenseOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 587);
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
            this.tabPageElectricMeter.ResumeLayout(false);
            this.tabPageWaterMeter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabFee)).EndInit();
            this.tabFee.ResumeLayout(false);
            this.tabPageElectricCompareGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.tabPageElectricCompareChart.ResumeLayout(false);
            this.tabPageElectricReceipt.ResumeLayout(false);
            this.tabPageWaterCompareGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl5)).EndInit();
            this.layoutControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.tabPageWaterCompareChart.ResumeLayout(false);
            this.tabPageWaterReceipt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsWaterExpense)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraTab.XtraTabControl tabInfo;
        private DevExpress.XtraTab.XtraTabPage tabPageAccount;
        private DevExpress.XtraTab.XtraTabPage tabPageWaterMeter;
        private WaterMeterGrid waterMeterGrid;
        private DevExpress.XtraTab.XtraTabControl tabFee;
        private DevExpress.XtraTab.XtraTabPage tabPageSummary;
        private System.Windows.Forms.BindingSource bsWaterExpense;
        private DevExpress.XtraTab.XtraTabPage tabPageWaterCompareGrid;
        private DevExpress.XtraLayout.LayoutControl layoutControl5;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup6;
        private DevExpress.XtraTab.XtraTabPage tabPageWaterReceipt;
        private WaterExpenseReceipt waterExpenseReceipt;
        private ExpenseAccountInfo ctrAccountInfo;
        private DevExpress.XtraTab.XtraTabPage tabPageElectricMeter;
        private ElectricMeterGrid electricMeterGrid;
        private DevExpress.XtraTab.XtraTabPage tabPageElectricReceipt;
        private ElectricExpenseReceipt electricExpenseReceipt;
        private Winform.Core.GroupChildrenTree groupTree;
        private DevExpress.XtraTab.XtraTabPage tabPageWaterCompareChart;
        private WaterCompareModule modWaterCompare;
        private DevExpress.XtraTab.XtraTabPage tabPageElectricCompareChart;
        private ElectricCompareModule modElectricCompare;
        private WaterCompareGridModule modWaterCompareGrid;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraTab.XtraTabPage tabPageElectricCompareGrid;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private ElectricCompareGridModule modElecCompGrid;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}