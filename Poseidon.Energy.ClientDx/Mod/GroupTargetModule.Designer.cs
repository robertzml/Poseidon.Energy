namespace Poseidon.Energy.ClientDx
{
    partial class GroupTargetModule
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
            this.components = new System.ComponentModel.Container();
            this.tabMain = new DevExpress.XtraTab.XtraTabControl();
            this.tabPageTarget = new DevExpress.XtraTab.XtraTabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lbTargets = new DevExpress.XtraEditors.ListBoxControl();
            this.bsTarget = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtTotalWaterAmount = new DevExpress.XtraEditors.TextEdit();
            this.txtTotalWaterQuantum = new DevExpress.XtraEditors.TextEdit();
            this.txtTotalElectricAmount = new DevExpress.XtraEditors.TextEdit();
            this.txtTotalElectricQuantum = new DevExpress.XtraEditors.TextEdit();
            this.txtDepartmentCount = new DevExpress.XtraEditors.TextEdit();
            this.txtGroupName = new DevExpress.XtraEditors.TextEdit();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.recordGrid = new Poseidon.Energy.ClientDx.TargetRecordGrid();
            this.tabPageTrend = new DevExpress.XtraTab.XtraTabPage();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tabPageTarget.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbTargets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalWaterAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalWaterQuantum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalElectricAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalElectricQuantum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartmentCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedTabPage = this.tabPageTarget;
            this.tabMain.Size = new System.Drawing.Size(820, 510);
            this.tabMain.TabIndex = 0;
            this.tabMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPageTarget,
            this.tabPageTrend});
            // 
            // tabPageTarget
            // 
            this.tabPageTarget.Controls.Add(this.tableLayoutPanel1);
            this.tabPageTarget.Name = "tabPageTarget";
            this.tabPageTarget.Size = new System.Drawing.Size(814, 481);
            this.tabPageTarget.Text = "指标计划";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(814, 481);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lbTargets);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.tableLayoutPanel1.SetRowSpan(this.groupControl1, 2);
            this.groupControl1.Size = new System.Drawing.Size(154, 475);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "指标计划列表";
            // 
            // lbTargets
            // 
            this.lbTargets.DataSource = this.bsTarget;
            this.lbTargets.DisplayMember = "Name";
            this.lbTargets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTargets.Location = new System.Drawing.Point(2, 21);
            this.lbTargets.Name = "lbTargets";
            this.lbTargets.Size = new System.Drawing.Size(150, 452);
            this.lbTargets.TabIndex = 0;
            this.lbTargets.ValueMember = "Id";
            this.lbTargets.SelectedIndexChanged += new System.EventHandler(this.lbTargets_SelectedIndexChanged);
            // 
            // bsTarget
            // 
            this.bsTarget.DataSource = typeof(Poseidon.Energy.Core.DL.Target);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.layoutControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(163, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(648, 154);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "概览";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtTotalWaterAmount);
            this.layoutControl1.Controls.Add(this.txtTotalWaterQuantum);
            this.layoutControl1.Controls.Add(this.txtTotalElectricAmount);
            this.layoutControl1.Controls.Add(this.txtTotalElectricQuantum);
            this.layoutControl1.Controls.Add(this.txtDepartmentCount);
            this.layoutControl1.Controls.Add(this.txtGroupName);
            this.layoutControl1.Controls.Add(this.btnPrint);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(644, 131);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtTotalWaterAmount
            // 
            this.txtTotalWaterAmount.Location = new System.Drawing.Point(445, 60);
            this.txtTotalWaterAmount.Name = "txtTotalWaterAmount";
            this.txtTotalWaterAmount.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtTotalWaterAmount.Properties.Appearance.Options.UseBackColor = true;
            this.txtTotalWaterAmount.Properties.ReadOnly = true;
            this.txtTotalWaterAmount.Size = new System.Drawing.Size(187, 20);
            this.txtTotalWaterAmount.StyleController = this.layoutControl1;
            this.txtTotalWaterAmount.TabIndex = 9;
            // 
            // txtTotalWaterQuantum
            // 
            this.txtTotalWaterQuantum.Location = new System.Drawing.Point(133, 60);
            this.txtTotalWaterQuantum.Name = "txtTotalWaterQuantum";
            this.txtTotalWaterQuantum.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtTotalWaterQuantum.Properties.Appearance.Options.UseBackColor = true;
            this.txtTotalWaterQuantum.Properties.ReadOnly = true;
            this.txtTotalWaterQuantum.Size = new System.Drawing.Size(187, 20);
            this.txtTotalWaterQuantum.StyleController = this.layoutControl1;
            this.txtTotalWaterQuantum.TabIndex = 8;
            // 
            // txtTotalElectricAmount
            // 
            this.txtTotalElectricAmount.Location = new System.Drawing.Point(445, 36);
            this.txtTotalElectricAmount.Name = "txtTotalElectricAmount";
            this.txtTotalElectricAmount.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtTotalElectricAmount.Properties.Appearance.Options.UseBackColor = true;
            this.txtTotalElectricAmount.Properties.ReadOnly = true;
            this.txtTotalElectricAmount.Size = new System.Drawing.Size(187, 20);
            this.txtTotalElectricAmount.StyleController = this.layoutControl1;
            this.txtTotalElectricAmount.TabIndex = 7;
            // 
            // txtTotalElectricQuantum
            // 
            this.txtTotalElectricQuantum.Location = new System.Drawing.Point(133, 36);
            this.txtTotalElectricQuantum.Name = "txtTotalElectricQuantum";
            this.txtTotalElectricQuantum.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtTotalElectricQuantum.Properties.Appearance.Options.UseBackColor = true;
            this.txtTotalElectricQuantum.Properties.ReadOnly = true;
            this.txtTotalElectricQuantum.Size = new System.Drawing.Size(187, 20);
            this.txtTotalElectricQuantum.StyleController = this.layoutControl1;
            this.txtTotalElectricQuantum.TabIndex = 6;
            // 
            // txtDepartmentCount
            // 
            this.txtDepartmentCount.Location = new System.Drawing.Point(445, 12);
            this.txtDepartmentCount.Name = "txtDepartmentCount";
            this.txtDepartmentCount.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtDepartmentCount.Properties.Appearance.Options.UseBackColor = true;
            this.txtDepartmentCount.Properties.ReadOnly = true;
            this.txtDepartmentCount.Size = new System.Drawing.Size(187, 20);
            this.txtDepartmentCount.StyleController = this.layoutControl1;
            this.txtDepartmentCount.TabIndex = 5;
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(133, 12);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtGroupName.Properties.Appearance.Options.UseBackColor = true;
            this.txtGroupName.Properties.ReadOnly = true;
            this.txtGroupName.Size = new System.Drawing.Size(187, 20);
            this.txtGroupName.StyleController = this.layoutControl1;
            this.txtGroupName.TabIndex = 4;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(12, 84);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(308, 22);
            this.btnPrint.StyleController = this.layoutControl1;
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "打印指标记录";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(644, 131);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnPrint;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(312, 39);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtGroupName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(312, 24);
            this.layoutControlItem2.Text = "分组名称";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(118, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtDepartmentCount;
            this.layoutControlItem3.Location = new System.Drawing.Point(312, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(312, 24);
            this.layoutControlItem3.Text = "部门数量";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(118, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtTotalElectricQuantum;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(312, 24);
            this.layoutControlItem4.Text = "电指标计划总量(度)";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(118, 14);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtTotalElectricAmount;
            this.layoutControlItem5.Location = new System.Drawing.Point(312, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(312, 24);
            this.layoutControlItem5.Text = "电指标计划总金额(元)";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(118, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtTotalWaterQuantum;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(312, 24);
            this.layoutControlItem6.Text = "水指标计划总量(吨)";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(118, 14);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtTotalWaterAmount;
            this.layoutControlItem7.Location = new System.Drawing.Point(312, 48);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(312, 24);
            this.layoutControlItem7.Text = "水指标计划总金额(元)";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(118, 14);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.recordGrid);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(163, 163);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(648, 315);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "指标记录";
            // 
            // recordGrid
            // 
            this.recordGrid.AllowFilter = true;
            this.recordGrid.AllowGroup = false;
            this.recordGrid.AllowSort = true;
            this.recordGrid.DataSource = null;
            this.recordGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recordGrid.Editable = false;
            this.recordGrid.EnableMasterView = false;
            this.recordGrid.Location = new System.Drawing.Point(2, 21);
            this.recordGrid.Name = "recordGrid";
            this.recordGrid.ShowAddMenu = false;
            this.recordGrid.ShowFooter = false;
            this.recordGrid.ShowLineNumber = true;
            this.recordGrid.ShowMenu = false;
            this.recordGrid.ShowNavigator = false;
            this.recordGrid.Size = new System.Drawing.Size(644, 292);
            this.recordGrid.TabIndex = 0;
            // 
            // tabPageTrend
            // 
            this.tabPageTrend.Name = "tabPageTrend";
            this.tabPageTrend.Size = new System.Drawing.Size(814, 481);
            this.tabPageTrend.Text = "指标趋势";
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(312, 72);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(312, 39);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // GroupTargetModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabMain);
            this.Name = "GroupTargetModule";
            this.Size = new System.Drawing.Size(820, 510);
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tabPageTarget.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbTargets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalWaterAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalWaterQuantum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalElectricAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalElectricQuantum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartmentCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabMain;
        private DevExpress.XtraTab.XtraTabPage tabPageTarget;
        private DevExpress.XtraTab.XtraTabPage tabPageTrend;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ListBoxControl lbTargets;
        private System.Windows.Forms.BindingSource bsTarget;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private TargetRecordGrid recordGrid;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtTotalWaterAmount;
        private DevExpress.XtraEditors.TextEdit txtTotalWaterQuantum;
        private DevExpress.XtraEditors.TextEdit txtTotalElectricAmount;
        private DevExpress.XtraEditors.TextEdit txtTotalElectricQuantum;
        private DevExpress.XtraEditors.TextEdit txtDepartmentCount;
        private DevExpress.XtraEditors.TextEdit txtGroupName;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}
