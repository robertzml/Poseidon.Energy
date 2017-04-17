namespace Poseidon.Energy.ClientDx
{
    partial class SettlementCompareGridModule
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.chkAmount = new DevExpress.XtraEditors.CheckEdit();
            this.chkQuantum = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.luFirst = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bsSettlement = new System.Windows.Forms.BindingSource(this.components);
            this.luSecond = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.compareGrid = new Poseidon.Energy.ClientDx.EnergyCompareGrid();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkQuantum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luFirst.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSettlement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luSecond.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.layoutControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(758, 458);
            this.panelControl1.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.luSecond);
            this.layoutControl1.Controls.Add(this.luFirst);
            this.layoutControl1.Controls.Add(this.compareGrid);
            this.layoutControl1.Controls.Add(this.chkAmount);
            this.layoutControl1.Controls.Add(this.chkQuantum);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(754, 454);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // chkAmount
            // 
            this.chkAmount.EditValue = true;
            this.chkAmount.Location = new System.Drawing.Point(672, 12);
            this.chkAmount.Name = "chkAmount";
            this.chkAmount.Properties.Caption = "比较金额";
            this.chkAmount.Size = new System.Drawing.Size(70, 19);
            this.chkAmount.StyleController = this.layoutControl1;
            this.chkAmount.TabIndex = 7;
            this.chkAmount.CheckedChanged += new System.EventHandler(this.chkAmount_CheckedChanged);
            // 
            // chkQuantum
            // 
            this.chkQuantum.EditValue = true;
            this.chkQuantum.Location = new System.Drawing.Point(586, 12);
            this.chkQuantum.Name = "chkQuantum";
            this.chkQuantum.Properties.Caption = "比较用量";
            this.chkQuantum.Size = new System.Drawing.Size(82, 19);
            this.chkQuantum.StyleController = this.layoutControl1;
            this.chkQuantum.TabIndex = 6;
            this.chkQuantum.CheckedChanged += new System.EventHandler(this.chkQuantum_CheckedChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(754, 454);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.chkQuantum;
            this.layoutControlItem3.Location = new System.Drawing.Point(574, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(86, 24);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.chkAmount;
            this.layoutControlItem4.Location = new System.Drawing.Point(660, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(74, 24);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // luFirst
            // 
            this.luFirst.Location = new System.Drawing.Point(46, 12);
            this.luFirst.Name = "luFirst";
            this.luFirst.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luFirst.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 21, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "名称", 54, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.luFirst.Properties.DataSource = this.bsSettlement;
            this.luFirst.Properties.DisplayMember = "Name";
            this.luFirst.Properties.NullText = "请选择";
            this.luFirst.Properties.ShowFooter = false;
            this.luFirst.Properties.ShowHeader = false;
            this.luFirst.Properties.ValueMember = "Id";
            this.luFirst.Size = new System.Drawing.Size(258, 20);
            this.luFirst.StyleController = this.layoutControl1;
            this.luFirst.TabIndex = 9;
            this.luFirst.EditValueChanged += new System.EventHandler(this.luFirst_EditValueChanged);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.luFirst;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(296, 24);
            this.layoutControlItem6.Text = "选择1";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(31, 14);
            // 
            // bsSettlement
            // 
            this.bsSettlement.DataSource = typeof(Poseidon.Energy.Core.DL.Settlement);
            // 
            // luSecond
            // 
            this.luSecond.Location = new System.Drawing.Point(342, 12);
            this.luSecond.Name = "luSecond";
            this.luSecond.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luSecond.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 21, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "名称", 54, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.luSecond.Properties.DataSource = this.bsSettlement;
            this.luSecond.Properties.DisplayMember = "Name";
            this.luSecond.Properties.NullText = "请选择";
            this.luSecond.Properties.ShowFooter = false;
            this.luSecond.Properties.ShowHeader = false;
            this.luSecond.Properties.ValueMember = "Id";
            this.luSecond.Size = new System.Drawing.Size(240, 20);
            this.luSecond.StyleController = this.layoutControl1;
            this.luSecond.TabIndex = 10;
            this.luSecond.EditValueChanged += new System.EventHandler(this.luSecond_EditValueChanged);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.luSecond;
            this.layoutControlItem1.Location = new System.Drawing.Point(296, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(278, 24);
            this.layoutControlItem1.Text = "选择2";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(31, 14);
            // 
            // compareGrid
            // 
            this.compareGrid.AllowFilter = false;
            this.compareGrid.AllowGroup = false;
            this.compareGrid.AllowSort = false;
            this.compareGrid.DataSource = null;
            this.compareGrid.Editable = true;
            this.compareGrid.EnableMasterView = false;
            this.compareGrid.Location = new System.Drawing.Point(12, 36);
            this.compareGrid.Name = "compareGrid";
            this.compareGrid.ShowAddMenu = false;
            this.compareGrid.ShowFooter = true;
            this.compareGrid.ShowLineNumber = true;
            this.compareGrid.ShowMenu = false;
            this.compareGrid.ShowNavigator = false;
            this.compareGrid.Size = new System.Drawing.Size(730, 406);
            this.compareGrid.TabIndex = 8;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.compareGrid;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(734, 410);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // SettlementCompareGridModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "SettlementCompareGridModule";
            this.Size = new System.Drawing.Size(758, 458);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkQuantum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luFirst.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSettlement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luSecond.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.CheckEdit chkAmount;
        private DevExpress.XtraEditors.CheckEdit chkQuantum;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private EnergyCompareGrid compareGrid;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.LookUpEdit luFirst;
        private System.Windows.Forms.BindingSource bsSettlement;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.LookUpEdit luSecond;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}
