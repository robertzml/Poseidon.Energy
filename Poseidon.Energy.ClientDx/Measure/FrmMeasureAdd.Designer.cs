namespace Poseidon.Energy.ClientDx
{
    partial class FrmMeasureAdd
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtRemark = new DevExpress.XtraEditors.MemoEdit();
            this.dpEndTime = new DevExpress.XtraEditors.DateEdit();
            this.dpStartTime = new DevExpress.XtraEditors.DateEdit();
            this.txtBelongTime = new DevExpress.XtraEditors.TextEdit();
            this.spYear = new DevExpress.XtraEditors.SpinEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.chkIncluded = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.cmbEnergyType = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.plFill)).BeginInit();
            this.plFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plBottom)).BeginInit();
            this.plBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpEndTime.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpEndTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpStartTime.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpStartTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelongTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIncluded.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEnergyType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(270, 15);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(161, 15);
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // plFill
            // 
            this.plFill.Appearance.BackColor = System.Drawing.Color.White;
            this.plFill.Appearance.Options.UseBackColor = true;
            this.plFill.Controls.Add(this.groupControl1);
            this.plFill.Size = new System.Drawing.Size(364, 261);
            // 
            // plBottom
            // 
            this.plBottom.Appearance.BackColor = System.Drawing.Color.White;
            this.plBottom.Appearance.Options.UseBackColor = true;
            this.plBottom.Location = new System.Drawing.Point(0, 261);
            this.plBottom.Size = new System.Drawing.Size(364, 60);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(364, 261);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "能源计量信息";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cmbEnergyType);
            this.layoutControl1.Controls.Add(this.chkIncluded);
            this.layoutControl1.Controls.Add(this.txtRemark);
            this.layoutControl1.Controls.Add(this.dpEndTime);
            this.layoutControl1.Controls.Add(this.dpStartTime);
            this.layoutControl1.Controls.Add(this.txtBelongTime);
            this.layoutControl1.Controls.Add(this.spYear);
            this.layoutControl1.Controls.Add(this.txtName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(360, 238);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(63, 179);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(285, 47);
            this.txtRemark.StyleController = this.layoutControl1;
            this.txtRemark.TabIndex = 7;
            // 
            // dpEndTime
            // 
            this.dpEndTime.EditValue = null;
            this.dpEndTime.Location = new System.Drawing.Point(63, 132);
            this.dpEndTime.Name = "dpEndTime";
            this.dpEndTime.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dpEndTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpEndTime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpEndTime.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dpEndTime.Size = new System.Drawing.Size(285, 20);
            this.dpEndTime.StyleController = this.layoutControl1;
            this.dpEndTime.TabIndex = 5;
            // 
            // dpStartTime
            // 
            this.dpStartTime.EditValue = null;
            this.dpStartTime.Location = new System.Drawing.Point(63, 108);
            this.dpStartTime.Name = "dpStartTime";
            this.dpStartTime.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dpStartTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpStartTime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpStartTime.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dpStartTime.Size = new System.Drawing.Size(285, 20);
            this.dpStartTime.StyleController = this.layoutControl1;
            this.dpStartTime.TabIndex = 4;
            // 
            // txtBelongTime
            // 
            this.txtBelongTime.Location = new System.Drawing.Point(63, 60);
            this.txtBelongTime.Name = "txtBelongTime";
            this.txtBelongTime.Size = new System.Drawing.Size(285, 20);
            this.txtBelongTime.StyleController = this.layoutControl1;
            this.txtBelongTime.TabIndex = 2;
            // 
            // spYear
            // 
            this.spYear.EditValue = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.spYear.Location = new System.Drawing.Point(63, 36);
            this.spYear.Name = "spYear";
            this.spYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spYear.Properties.Mask.EditMask = "d";
            this.spYear.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.spYear.Properties.MaxValue = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.spYear.Properties.MinValue = new decimal(new int[] {
            2001,
            0,
            0,
            0});
            this.spYear.Size = new System.Drawing.Size(285, 20);
            this.spYear.StyleController = this.layoutControl1;
            this.spYear.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(63, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(285, 20);
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
            this.layoutControlItem7,
            this.layoutControlItem8});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(360, 238);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(340, 24);
            this.layoutControlItem1.Text = "名称";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.spYear;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(340, 24);
            this.layoutControlItem2.Text = "年度";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtBelongTime;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(340, 24);
            this.layoutControlItem3.Text = "归属时间";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.dpStartTime;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(340, 24);
            this.layoutControlItem4.Text = "起始时间";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.dpEndTime;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(340, 24);
            this.layoutControlItem5.Text = "结束时间";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtRemark;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 167);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(340, 51);
            this.layoutControlItem6.Text = "备注";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(48, 14);
            // 
            // chkIncluded
            // 
            this.chkIncluded.Location = new System.Drawing.Point(12, 156);
            this.chkIncluded.Name = "chkIncluded";
            this.chkIncluded.Properties.Caption = "是否计入合计";
            this.chkIncluded.Size = new System.Drawing.Size(336, 19);
            this.chkIncluded.StyleController = this.layoutControl1;
            this.chkIncluded.TabIndex = 6;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.chkIncluded;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(340, 23);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // cmbEnergyType
            // 
            this.cmbEnergyType.Location = new System.Drawing.Point(63, 84);
            this.cmbEnergyType.Name = "cmbEnergyType";
            this.cmbEnergyType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEnergyType.Size = new System.Drawing.Size(285, 20);
            this.cmbEnergyType.StyleController = this.layoutControl1;
            this.cmbEnergyType.TabIndex = 3;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.cmbEnergyType;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(340, 24);
            this.layoutControlItem8.Text = "能源类型";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(48, 14);
            // 
            // FrmMeasureAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 321);
            this.Name = "FrmMeasureAdd";
            this.Text = "添加能源计量";
            ((System.ComponentModel.ISupportInitialize)(this.plFill)).EndInit();
            this.plFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plBottom)).EndInit();
            this.plBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpEndTime.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpEndTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpStartTime.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpStartTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelongTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIncluded.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEnergyType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit txtBelongTime;
        private DevExpress.XtraEditors.SpinEdit spYear;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.MemoEdit txtRemark;
        private DevExpress.XtraEditors.DateEdit dpEndTime;
        private DevExpress.XtraEditors.DateEdit dpStartTime;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.CheckEdit chkIncluded;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.ImageComboBoxEdit cmbEnergyType;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    }
}