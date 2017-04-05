namespace Poseidon.Energy.ClientDx
{
    partial class GroupSettlementModule
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabSettlement = new DevExpress.XtraTab.XtraTabControl();
            this.tabPageSummary = new DevExpress.XtraTab.XtraTabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtYear = new DevExpress.XtraEditors.TextEdit();
            this.txtGroupName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabSummary = new DevExpress.XtraTab.XtraTabControl();
            this.tabPageElecQuantum = new DevExpress.XtraTab.XtraTabPage();
            this.electricQSGrid = new Poseidon.Energy.ClientDx.SettlementQuantumSummaryGrid();
            this.tabPageElecAmount = new DevExpress.XtraTab.XtraTabPage();
            this.tabPageWatQuantum = new DevExpress.XtraTab.XtraTabPage();
            this.waterQSGrid = new Poseidon.Energy.ClientDx.SettlementQuantumSummaryGrid();
            this.tabPageWatAmount = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lbYears = new DevExpress.XtraEditors.ListBoxControl();
            this.tabPageRecord = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.tabSettlement)).BeginInit();
            this.tabSettlement.SuspendLayout();
            this.tabPageSummary.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabSummary)).BeginInit();
            this.tabSummary.SuspendLayout();
            this.tabPageElecQuantum.SuspendLayout();
            this.tabPageWatQuantum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbYears)).BeginInit();
            this.SuspendLayout();
            // 
            // tabSettlement
            // 
            this.tabSettlement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSettlement.Location = new System.Drawing.Point(0, 0);
            this.tabSettlement.Name = "tabSettlement";
            this.tabSettlement.SelectedTabPage = this.tabPageSummary;
            this.tabSettlement.Size = new System.Drawing.Size(823, 545);
            this.tabSettlement.TabIndex = 0;
            this.tabSettlement.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPageSummary,
            this.tabPageRecord});
            // 
            // tabPageSummary
            // 
            this.tabPageSummary.Controls.Add(this.tableLayoutPanel1);
            this.tabPageSummary.Name = "tabPageSummary";
            this.tabPageSummary.Size = new System.Drawing.Size(817, 516);
            this.tabPageSummary.Text = "能源结算汇总";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabSummary, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(817, 516);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(143, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(671, 114);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "概览";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtYear);
            this.layoutControl1.Controls.Add(this.txtGroupName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(667, 91);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(386, 12);
            this.txtYear.Name = "txtYear";
            this.txtYear.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtYear.Properties.Appearance.Options.UseBackColor = true;
            this.txtYear.Properties.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(269, 20);
            this.txtYear.StyleController = this.layoutControl1;
            this.txtYear.TabIndex = 5;
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(63, 12);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtGroupName.Properties.Appearance.Options.UseBackColor = true;
            this.txtGroupName.Properties.ReadOnly = true;
            this.txtGroupName.Size = new System.Drawing.Size(268, 20);
            this.txtGroupName.StyleController = this.layoutControl1;
            this.txtGroupName.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(667, 91);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtGroupName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(323, 71);
            this.layoutControlItem1.Text = "分组名称";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtYear;
            this.layoutControlItem2.Location = new System.Drawing.Point(323, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(324, 71);
            this.layoutControlItem2.Text = "年度";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(48, 14);
            // 
            // tabSummary
            // 
            this.tabSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSummary.Location = new System.Drawing.Point(143, 123);
            this.tabSummary.Name = "tabSummary";
            this.tabSummary.SelectedTabPage = this.tabPageElecQuantum;
            this.tabSummary.Size = new System.Drawing.Size(671, 390);
            this.tabSummary.TabIndex = 2;
            this.tabSummary.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPageElecQuantum,
            this.tabPageElecAmount,
            this.tabPageWatQuantum,
            this.tabPageWatAmount});
            // 
            // tabPageElecQuantum
            // 
            this.tabPageElecQuantum.Controls.Add(this.electricQSGrid);
            this.tabPageElecQuantum.Name = "tabPageElecQuantum";
            this.tabPageElecQuantum.Size = new System.Drawing.Size(665, 361);
            this.tabPageElecQuantum.Text = "年度用电汇总";
            // 
            // electricQSGrid
            // 
            this.electricQSGrid.AllowFilter = false;
            this.electricQSGrid.AllowGroup = false;
            this.electricQSGrid.AllowSort = true;
            this.electricQSGrid.DataSource = null;
            this.electricQSGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.electricQSGrid.Editable = false;
            this.electricQSGrid.EnableMasterView = false;
            this.electricQSGrid.Location = new System.Drawing.Point(0, 0);
            this.electricQSGrid.Name = "electricQSGrid";
            this.electricQSGrid.ShowAddMenu = false;
            this.electricQSGrid.ShowFooter = true;
            this.electricQSGrid.ShowLineNumber = true;
            this.electricQSGrid.ShowMenu = false;
            this.electricQSGrid.ShowNavigator = false;
            this.electricQSGrid.Size = new System.Drawing.Size(665, 361);
            this.electricQSGrid.TabIndex = 0;
            // 
            // tabPageElecAmount
            // 
            this.tabPageElecAmount.Name = "tabPageElecAmount";
            this.tabPageElecAmount.Size = new System.Drawing.Size(665, 361);
            this.tabPageElecAmount.Text = "用电金额汇总";
            // 
            // tabPageWatQuantum
            // 
            this.tabPageWatQuantum.Controls.Add(this.waterQSGrid);
            this.tabPageWatQuantum.Name = "tabPageWatQuantum";
            this.tabPageWatQuantum.Size = new System.Drawing.Size(665, 361);
            this.tabPageWatQuantum.Text = "年度用水汇总";
            // 
            // waterQSGrid
            // 
            this.waterQSGrid.AllowFilter = false;
            this.waterQSGrid.AllowGroup = false;
            this.waterQSGrid.AllowSort = true;
            this.waterQSGrid.DataSource = null;
            this.waterQSGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waterQSGrid.Editable = false;
            this.waterQSGrid.EnableMasterView = false;
            this.waterQSGrid.Location = new System.Drawing.Point(0, 0);
            this.waterQSGrid.Name = "waterQSGrid";
            this.waterQSGrid.ShowAddMenu = false;
            this.waterQSGrid.ShowFooter = true;
            this.waterQSGrid.ShowLineNumber = true;
            this.waterQSGrid.ShowMenu = false;
            this.waterQSGrid.ShowNavigator = false;
            this.waterQSGrid.Size = new System.Drawing.Size(665, 361);
            this.waterQSGrid.TabIndex = 0;
            // 
            // tabPageWatAmount
            // 
            this.tabPageWatAmount.Name = "tabPageWatAmount";
            this.tabPageWatAmount.Size = new System.Drawing.Size(665, 361);
            this.tabPageWatAmount.Text = "用水金额汇总";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lbYears);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 3);
            this.groupControl2.Name = "groupControl2";
            this.tableLayoutPanel1.SetRowSpan(this.groupControl2, 2);
            this.groupControl2.Size = new System.Drawing.Size(134, 510);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "年度";
            // 
            // lbYears
            // 
            this.lbYears.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbYears.Location = new System.Drawing.Point(2, 21);
            this.lbYears.Name = "lbYears";
            this.lbYears.Size = new System.Drawing.Size(130, 487);
            this.lbYears.TabIndex = 0;
            this.lbYears.SelectedIndexChanged += new System.EventHandler(this.lbYears_SelectedIndexChanged);
            // 
            // tabPageRecord
            // 
            this.tabPageRecord.Name = "tabPageRecord";
            this.tabPageRecord.Size = new System.Drawing.Size(817, 516);
            this.tabPageRecord.Text = "能源结算记录";
            // 
            // GroupSettlementModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabSettlement);
            this.Name = "GroupSettlementModule";
            this.Size = new System.Drawing.Size(823, 545);
            ((System.ComponentModel.ISupportInitialize)(this.tabSettlement)).EndInit();
            this.tabSettlement.ResumeLayout(false);
            this.tabPageSummary.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabSummary)).EndInit();
            this.tabSummary.ResumeLayout(false);
            this.tabPageElecQuantum.ResumeLayout(false);
            this.tabPageWatQuantum.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbYears)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabSettlement;
        private DevExpress.XtraTab.XtraTabPage tabPageSummary;
        private DevExpress.XtraTab.XtraTabPage tabPageRecord;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtYear;
        private DevExpress.XtraEditors.TextEdit txtGroupName;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraTab.XtraTabControl tabSummary;
        private DevExpress.XtraTab.XtraTabPage tabPageElecQuantum;
        private DevExpress.XtraTab.XtraTabPage tabPageElecAmount;
        private SettlementQuantumSummaryGrid electricQSGrid;
        private DevExpress.XtraTab.XtraTabPage tabPageWatQuantum;
        private DevExpress.XtraTab.XtraTabPage tabPageWatAmount;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.ListBoxControl lbYears;
        private SettlementQuantumSummaryGrid waterQSGrid;
    }
}
