namespace Poseidon.Energy.ClientDx
{
    partial class FrmSettlementEdit
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.luTarget = new DevExpress.XtraEditors.LookUpEdit();
            this.txtRemark = new DevExpress.XtraEditors.MemoEdit();
            this.luPrevious = new DevExpress.XtraEditors.LookUpEdit();
            this.txtBelongTime = new DevExpress.XtraEditors.TextEdit();
            this.cmbType = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.spYear = new DevExpress.XtraEditors.SpinEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bsTarget = new System.Windows.Forms.BindingSource(this.components);
            this.bsSettlement = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.plFill)).BeginInit();
            this.plFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plBottom)).BeginInit();
            this.plBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luTarget.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luPrevious.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelongTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSettlement)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(290, 15);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(181, 15);
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // plFill
            // 
            this.plFill.Appearance.BackColor = System.Drawing.Color.White;
            this.plFill.Appearance.Options.UseBackColor = true;
            this.plFill.Controls.Add(this.groupControl1);
            this.plFill.Size = new System.Drawing.Size(384, 281);
            // 
            // plBottom
            // 
            this.plBottom.Appearance.BackColor = System.Drawing.Color.White;
            this.plBottom.Appearance.Options.UseBackColor = true;
            this.plBottom.Location = new System.Drawing.Point(0, 281);
            this.plBottom.Size = new System.Drawing.Size(384, 60);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(384, 281);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "能源结算信息";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.luTarget);
            this.layoutControl1.Controls.Add(this.txtRemark);
            this.layoutControl1.Controls.Add(this.luPrevious);
            this.layoutControl1.Controls.Add(this.txtBelongTime);
            this.layoutControl1.Controls.Add(this.cmbType);
            this.layoutControl1.Controls.Add(this.spYear);
            this.layoutControl1.Controls.Add(this.txtName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(380, 258);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // luTarget
            // 
            this.luTarget.Location = new System.Drawing.Point(87, 108);
            this.luTarget.Name = "luTarget";
            this.luTarget.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luTarget.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 21, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "名称", 54, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Year", "年度", 35, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.Descending)});
            this.luTarget.Properties.DataSource = this.bsTarget;
            this.luTarget.Properties.DisplayMember = "Name";
            this.luTarget.Properties.NullText = "请选择";
            this.luTarget.Properties.ShowFooter = false;
            this.luTarget.Properties.ValueMember = "Id";
            this.luTarget.Size = new System.Drawing.Size(281, 20);
            this.luTarget.StyleController = this.layoutControl1;
            this.luTarget.TabIndex = 4;
            this.luTarget.EditValueChanged += new System.EventHandler(this.luTarget_EditValueChanged);
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(87, 156);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(281, 90);
            this.txtRemark.StyleController = this.layoutControl1;
            this.txtRemark.TabIndex = 6;
            // 
            // luPrevious
            // 
            this.luPrevious.Location = new System.Drawing.Point(87, 132);
            this.luPrevious.Name = "luPrevious";
            this.luPrevious.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.luPrevious.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luPrevious.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 21, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "名称", 54, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Year", "年度", 25, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BelongTime", 30, "归属时间")});
            this.luPrevious.Properties.DataSource = this.bsSettlement;
            this.luPrevious.Properties.DisplayMember = "Name";
            this.luPrevious.Properties.NullText = "首次结算";
            this.luPrevious.Properties.ShowFooter = false;
            this.luPrevious.Properties.ValueMember = "Id";
            this.luPrevious.Size = new System.Drawing.Size(281, 20);
            this.luPrevious.StyleController = this.layoutControl1;
            this.luPrevious.TabIndex = 5;
            // 
            // txtBelongTime
            // 
            this.txtBelongTime.Location = new System.Drawing.Point(87, 84);
            this.txtBelongTime.Name = "txtBelongTime";
            this.txtBelongTime.Size = new System.Drawing.Size(281, 20);
            this.txtBelongTime.StyleController = this.layoutControl1;
            this.txtBelongTime.TabIndex = 3;
            // 
            // cmbType
            // 
            this.cmbType.Location = new System.Drawing.Point(87, 60);
            this.cmbType.Name = "cmbType";
            this.cmbType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbType.Size = new System.Drawing.Size(281, 20);
            this.cmbType.StyleController = this.layoutControl1;
            this.cmbType.TabIndex = 2;
            // 
            // spYear
            // 
            this.spYear.EditValue = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.spYear.Location = new System.Drawing.Point(87, 36);
            this.spYear.Name = "spYear";
            this.spYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spYear.Properties.Mask.EditMask = "d";
            this.spYear.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.spYear.Size = new System.Drawing.Size(281, 20);
            this.spYear.StyleController = this.layoutControl1;
            this.spYear.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(87, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(281, 20);
            this.txtName.StyleController = this.layoutControl1;
            this.txtName.TabIndex = 0;
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
            this.layoutControlItem7});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(380, 258);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(360, 24);
            this.layoutControlItem1.Text = "名称";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.spYear;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(360, 24);
            this.layoutControlItem2.Text = "年度";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cmbType;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(360, 24);
            this.layoutControlItem3.Text = "结算类型";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtBelongTime;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(360, 24);
            this.layoutControlItem4.Text = "归属时间";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.luPrevious;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(360, 24);
            this.layoutControlItem5.Text = "上期结算";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtRemark;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(360, 94);
            this.layoutControlItem6.Text = "备注";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.luTarget;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(360, 24);
            this.layoutControlItem7.Text = "关联指标计划";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(72, 14);
            // 
            // bsTarget
            // 
            this.bsTarget.DataSource = typeof(Poseidon.Energy.Core.DL.Target);
            // 
            // bsSettlement
            // 
            this.bsSettlement.DataSource = typeof(Poseidon.Energy.Core.DL.Settlement);
            // 
            // FrmSettlementEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 341);
            this.Name = "FrmSettlementEdit";
            this.Text = "编辑能源结算";
            ((System.ComponentModel.ISupportInitialize)(this.plFill)).EndInit();
            this.plFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plBottom)).EndInit();
            this.plBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.luTarget.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luPrevious.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelongTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSettlement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.LookUpEdit luTarget;
        private DevExpress.XtraEditors.MemoEdit txtRemark;
        private DevExpress.XtraEditors.LookUpEdit luPrevious;
        private DevExpress.XtraEditors.TextEdit txtBelongTime;
        private DevExpress.XtraEditors.ImageComboBoxEdit cmbType;
        private DevExpress.XtraEditors.SpinEdit spYear;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private System.Windows.Forms.BindingSource bsTarget;
        private System.Windows.Forms.BindingSource bsSettlement;
    }
}