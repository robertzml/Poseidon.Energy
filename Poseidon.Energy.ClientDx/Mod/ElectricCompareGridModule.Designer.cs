namespace Poseidon.Energy.ClientDx
{
    partial class ElectricCompareGridModule
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.chkAmount = new DevExpress.XtraEditors.CheckEdit();
            this.chkQuantum = new DevExpress.XtraEditors.CheckEdit();
            this.energyGrid = new Poseidon.Energy.ClientDx.EnergyCompareGrid();
            this.cmbSecond = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbFirst = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkQuantum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSecond.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFirst.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.layoutControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(679, 471);
            this.panelControl1.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.chkAmount);
            this.layoutControl1.Controls.Add(this.chkQuantum);
            this.layoutControl1.Controls.Add(this.energyGrid);
            this.layoutControl1.Controls.Add(this.cmbSecond);
            this.layoutControl1.Controls.Add(this.cmbFirst);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(675, 467);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // chkAmount
            // 
            this.chkAmount.EditValue = true;
            this.chkAmount.Location = new System.Drawing.Point(581, 12);
            this.chkAmount.Name = "chkAmount";
            this.chkAmount.Properties.Caption = "比较金额";
            this.chkAmount.Size = new System.Drawing.Size(82, 19);
            this.chkAmount.StyleController = this.layoutControl1;
            this.chkAmount.TabIndex = 8;
            this.chkAmount.CheckedChanged += new System.EventHandler(this.chkAmount_CheckedChanged);
            // 
            // chkQuantum
            // 
            this.chkQuantum.EditValue = true;
            this.chkQuantum.Location = new System.Drawing.Point(495, 12);
            this.chkQuantum.Name = "chkQuantum";
            this.chkQuantum.Properties.Caption = "比较用量";
            this.chkQuantum.Size = new System.Drawing.Size(82, 19);
            this.chkQuantum.StyleController = this.layoutControl1;
            this.chkQuantum.TabIndex = 7;
            this.chkQuantum.CheckedChanged += new System.EventHandler(this.chkQuantum_CheckedChanged);
            // 
            // energyGrid
            // 
            this.energyGrid.AllowFilter = false;
            this.energyGrid.AllowGroup = false;
            this.energyGrid.AllowSort = false;
            this.energyGrid.DataSource = null;
            this.energyGrid.Editable = true;
            this.energyGrid.EnableMasterView = false;
            this.energyGrid.Location = new System.Drawing.Point(12, 36);
            this.energyGrid.Name = "energyGrid";
            this.energyGrid.ShowAddMenu = false;
            this.energyGrid.ShowFooter = true;
            this.energyGrid.ShowLineNumber = true;
            this.energyGrid.ShowMenu = false;
            this.energyGrid.ShowNavigator = false;
            this.energyGrid.Size = new System.Drawing.Size(651, 419);
            this.energyGrid.TabIndex = 6;
            // 
            // cmbSecond
            // 
            this.cmbSecond.Location = new System.Drawing.Point(297, 12);
            this.cmbSecond.Name = "cmbSecond";
            this.cmbSecond.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSecond.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbSecond.Size = new System.Drawing.Size(194, 20);
            this.cmbSecond.StyleController = this.layoutControl1;
            this.cmbSecond.TabIndex = 5;
            this.cmbSecond.SelectedIndexChanged += new System.EventHandler(this.cmbSecond_SelectedIndexChanged);
            // 
            // cmbFirst
            // 
            this.cmbFirst.Location = new System.Drawing.Point(46, 12);
            this.cmbFirst.Name = "cmbFirst";
            this.cmbFirst.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFirst.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbFirst.Size = new System.Drawing.Size(213, 20);
            this.cmbFirst.StyleController = this.layoutControl1;
            this.cmbFirst.TabIndex = 4;
            this.cmbFirst.SelectedIndexChanged += new System.EventHandler(this.cmbFirst_SelectedIndexChanged);
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
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(675, 467);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cmbFirst;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(251, 24);
            this.layoutControlItem1.Text = "选择1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(31, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cmbSecond;
            this.layoutControlItem2.Location = new System.Drawing.Point(251, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(232, 24);
            this.layoutControlItem2.Text = "选择2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(31, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.energyGrid;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(655, 423);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.chkQuantum;
            this.layoutControlItem4.Location = new System.Drawing.Point(483, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(86, 24);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.chkAmount;
            this.layoutControlItem5.Location = new System.Drawing.Point(569, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(86, 24);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // ElectricCompareGridModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "ElectricCompareGridModule";
            this.Size = new System.Drawing.Size(679, 471);
            this.Load += new System.EventHandler(this.ElectricCompareGridModule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkQuantum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSecond.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFirst.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.CheckEdit chkAmount;
        private DevExpress.XtraEditors.CheckEdit chkQuantum;
        private EnergyCompareGrid energyGrid;
        private DevExpress.XtraEditors.ComboBoxEdit cmbFirst;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.ComboBoxEdit cmbSecond;
    }
}
