namespace Poseidon.Energy.ClientDx
{
    partial class FrmFundOverview
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
            this.lbFund = new DevExpress.XtraEditors.ListBoxControl();
            this.bsFund = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtRemark = new DevExpress.XtraEditors.MemoEdit();
            this.txtEditTime = new DevExpress.XtraEditors.TextEdit();
            this.txtEditUser = new DevExpress.XtraEditors.TextEdit();
            this.txtCreateTime = new DevExpress.XtraEditors.TextEdit();
            this.txtCreateUser = new DevExpress.XtraEditors.TextEdit();
            this.txtBelongTime = new DevExpress.XtraEditors.TextEdit();
            this.txtYear = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.frGrid = new Poseidon.Energy.ClientDx.FundRecordGrid();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbFund)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFund)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelongTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(823, 511);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lbFund);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.tableLayoutPanel1.SetRowSpan(this.groupControl1, 2);
            this.groupControl1.Size = new System.Drawing.Size(194, 505);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "统计列表";
            // 
            // lbFund
            // 
            this.lbFund.DataSource = this.bsFund;
            this.lbFund.DisplayMember = "Name";
            this.lbFund.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbFund.Location = new System.Drawing.Point(2, 21);
            this.lbFund.Name = "lbFund";
            this.lbFund.Size = new System.Drawing.Size(190, 482);
            this.lbFund.TabIndex = 0;
            this.lbFund.ValueMember = "Id";
            this.lbFund.SelectedIndexChanged += new System.EventHandler(this.lbFund_SelectedIndexChanged);
            // 
            // bsFund
            // 
            this.bsFund.DataSource = typeof(Poseidon.Energy.Core.DL.Fund);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.layoutControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(203, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(617, 194);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "选中统计";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtRemark);
            this.layoutControl1.Controls.Add(this.txtEditTime);
            this.layoutControl1.Controls.Add(this.txtEditUser);
            this.layoutControl1.Controls.Add(this.txtCreateTime);
            this.layoutControl1.Controls.Add(this.txtCreateUser);
            this.layoutControl1.Controls.Add(this.txtBelongTime);
            this.layoutControl1.Controls.Add(this.txtYear);
            this.layoutControl1.Controls.Add(this.txtName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(613, 171);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(63, 108);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtRemark.Properties.Appearance.Options.UseBackColor = true;
            this.txtRemark.Properties.ReadOnly = true;
            this.txtRemark.Size = new System.Drawing.Size(538, 51);
            this.txtRemark.StyleController = this.layoutControl1;
            this.txtRemark.TabIndex = 11;
            // 
            // txtEditTime
            // 
            this.txtEditTime.Location = new System.Drawing.Point(359, 84);
            this.txtEditTime.Name = "txtEditTime";
            this.txtEditTime.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtEditTime.Properties.Appearance.Options.UseBackColor = true;
            this.txtEditTime.Properties.ReadOnly = true;
            this.txtEditTime.Size = new System.Drawing.Size(242, 20);
            this.txtEditTime.StyleController = this.layoutControl1;
            this.txtEditTime.TabIndex = 10;
            // 
            // txtEditUser
            // 
            this.txtEditUser.Location = new System.Drawing.Point(63, 84);
            this.txtEditUser.Name = "txtEditUser";
            this.txtEditUser.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtEditUser.Properties.Appearance.Options.UseBackColor = true;
            this.txtEditUser.Properties.ReadOnly = true;
            this.txtEditUser.Size = new System.Drawing.Size(241, 20);
            this.txtEditUser.StyleController = this.layoutControl1;
            this.txtEditUser.TabIndex = 9;
            // 
            // txtCreateTime
            // 
            this.txtCreateTime.Location = new System.Drawing.Point(359, 60);
            this.txtCreateTime.Name = "txtCreateTime";
            this.txtCreateTime.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtCreateTime.Properties.Appearance.Options.UseBackColor = true;
            this.txtCreateTime.Properties.ReadOnly = true;
            this.txtCreateTime.Size = new System.Drawing.Size(242, 20);
            this.txtCreateTime.StyleController = this.layoutControl1;
            this.txtCreateTime.TabIndex = 8;
            // 
            // txtCreateUser
            // 
            this.txtCreateUser.Location = new System.Drawing.Point(63, 60);
            this.txtCreateUser.Name = "txtCreateUser";
            this.txtCreateUser.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtCreateUser.Properties.Appearance.Options.UseBackColor = true;
            this.txtCreateUser.Properties.ReadOnly = true;
            this.txtCreateUser.Size = new System.Drawing.Size(241, 20);
            this.txtCreateUser.StyleController = this.layoutControl1;
            this.txtCreateUser.TabIndex = 7;
            // 
            // txtBelongTime
            // 
            this.txtBelongTime.Location = new System.Drawing.Point(359, 36);
            this.txtBelongTime.Name = "txtBelongTime";
            this.txtBelongTime.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtBelongTime.Properties.Appearance.Options.UseBackColor = true;
            this.txtBelongTime.Properties.ReadOnly = true;
            this.txtBelongTime.Size = new System.Drawing.Size(242, 20);
            this.txtBelongTime.StyleController = this.layoutControl1;
            this.txtBelongTime.TabIndex = 6;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(63, 36);
            this.txtYear.Name = "txtYear";
            this.txtYear.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtYear.Properties.Appearance.Options.UseBackColor = true;
            this.txtYear.Properties.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(241, 20);
            this.txtYear.StyleController = this.layoutControl1;
            this.txtYear.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(63, 12);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtName.Properties.Appearance.Options.UseBackColor = true;
            this.txtName.Properties.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(538, 20);
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
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(613, 171);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(593, 24);
            this.layoutControlItem1.Text = "名称";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtYear;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(296, 24);
            this.layoutControlItem2.Text = "年度";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtBelongTime;
            this.layoutControlItem3.Location = new System.Drawing.Point(296, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(297, 24);
            this.layoutControlItem3.Text = "归属时间";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtCreateUser;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(296, 24);
            this.layoutControlItem4.Text = "创建人";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtCreateTime;
            this.layoutControlItem5.Location = new System.Drawing.Point(296, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(297, 24);
            this.layoutControlItem5.Text = "创建时间";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtEditUser;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(296, 24);
            this.layoutControlItem6.Text = "编辑人";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtEditTime;
            this.layoutControlItem7.Location = new System.Drawing.Point(296, 72);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(297, 24);
            this.layoutControlItem7.Text = "编辑时间";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtRemark;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(593, 55);
            this.layoutControlItem8.Text = "备注";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(48, 14);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.frGrid);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(203, 203);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(617, 305);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "经费记录";
            // 
            // frGrid
            // 
            this.frGrid.AllowFilter = true;
            this.frGrid.AllowGroup = true;
            this.frGrid.AllowSort = true;
            this.frGrid.DataSource = null;
            this.frGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frGrid.Editable = false;
            this.frGrid.EnableMasterView = false;
            this.frGrid.EnableMultiSelect = true;
            this.frGrid.Location = new System.Drawing.Point(2, 21);
            this.frGrid.Name = "frGrid";
            this.frGrid.ShowAddMenu = false;
            this.frGrid.ShowDeleteMenu = false;
            this.frGrid.ShowEditMenu = false;
            this.frGrid.ShowFindPanel = false;
            this.frGrid.ShowFooter = true;
            this.frGrid.ShowLineNumber = true;
            this.frGrid.ShowMenu = false;
            this.frGrid.ShowNavigator = false;
            this.frGrid.Size = new System.Drawing.Size(613, 282);
            this.frGrid.TabIndex = 0;
            // 
            // FrmFundOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 511);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmFundOverview";
            this.Text = "经费统计总览";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbFund)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFund)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelongTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ListBoxControl lbFund;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.BindingSource bsFund;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.MemoEdit txtRemark;
        private DevExpress.XtraEditors.TextEdit txtEditTime;
        private DevExpress.XtraEditors.TextEdit txtEditUser;
        private DevExpress.XtraEditors.TextEdit txtCreateTime;
        private DevExpress.XtraEditors.TextEdit txtCreateUser;
        private DevExpress.XtraEditors.TextEdit txtBelongTime;
        private DevExpress.XtraEditors.TextEdit txtYear;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private FundRecordGrid frGrid;
    }
}