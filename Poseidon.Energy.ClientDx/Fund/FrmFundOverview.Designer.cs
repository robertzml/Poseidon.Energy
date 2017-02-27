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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.btnEditRecord = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtUpdateTime = new DevExpress.XtraEditors.TextEdit();
            this.txtCreateTime = new DevExpress.XtraEditors.TextEdit();
            this.txtRemark = new DevExpress.XtraEditors.TextEdit();
            this.txtYear = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.frGrid = new Poseidon.Energy.ClientDx.FundRecordGrid();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.lbFund = new DevExpress.XtraEditors.ListBoxControl();
            this.bsFund = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdateTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbFund)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFund)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupControl3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(882, 519);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(203, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(676, 174);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "选中统计";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtName);
            this.layoutControl1.Controls.Add(this.btnEditRecord);
            this.layoutControl1.Controls.Add(this.btnDelete);
            this.layoutControl1.Controls.Add(this.btnEdit);
            this.layoutControl1.Controls.Add(this.btnAdd);
            this.layoutControl1.Controls.Add(this.txtUpdateTime);
            this.layoutControl1.Controls.Add(this.txtCreateTime);
            this.layoutControl1.Controls.Add(this.txtRemark);
            this.layoutControl1.Controls.Add(this.txtYear);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(672, 151);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(58, 7);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtName.Properties.Appearance.Options.UseBackColor = true;
            this.txtName.Properties.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(275, 20);
            this.txtName.StyleController = this.layoutControl1;
            this.txtName.TabIndex = 0;
            // 
            // btnEditRecord
            // 
            this.btnEditRecord.Location = new System.Drawing.Point(496, 110);
            this.btnEditRecord.Name = "btnEditRecord";
            this.btnEditRecord.Size = new System.Drawing.Size(157, 22);
            this.btnEditRecord.StyleController = this.layoutControl1;
            this.btnEditRecord.TabIndex = 8;
            this.btnEditRecord.Text = "编辑记录";
            this.btnEditRecord.Click += new System.EventHandler(this.btnEditRecord_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(337, 110);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(155, 22);
            this.btnDelete.StyleController = this.layoutControl1;
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "删除统计";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(177, 110);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(156, 22);
            this.btnEdit.StyleController = this.layoutControl1;
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "编辑统计";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(19, 110);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(154, 22);
            this.btnAdd.StyleController = this.layoutControl1;
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "添加统计";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtUpdateTime
            // 
            this.txtUpdateTime.Location = new System.Drawing.Point(388, 31);
            this.txtUpdateTime.Name = "txtUpdateTime";
            this.txtUpdateTime.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtUpdateTime.Properties.Appearance.Options.UseBackColor = true;
            this.txtUpdateTime.Properties.ReadOnly = true;
            this.txtUpdateTime.Size = new System.Drawing.Size(277, 20);
            this.txtUpdateTime.StyleController = this.layoutControl1;
            this.txtUpdateTime.TabIndex = 3;
            // 
            // txtCreateTime
            // 
            this.txtCreateTime.Location = new System.Drawing.Point(58, 31);
            this.txtCreateTime.Name = "txtCreateTime";
            this.txtCreateTime.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtCreateTime.Properties.Appearance.Options.UseBackColor = true;
            this.txtCreateTime.Properties.ReadOnly = true;
            this.txtCreateTime.Size = new System.Drawing.Size(275, 20);
            this.txtCreateTime.StyleController = this.layoutControl1;
            this.txtCreateTime.TabIndex = 2;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(58, 55);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtRemark.Properties.Appearance.Options.UseBackColor = true;
            this.txtRemark.Properties.ReadOnly = true;
            this.txtRemark.Size = new System.Drawing.Size(607, 20);
            this.txtRemark.StyleController = this.layoutControl1;
            this.txtRemark.TabIndex = 4;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(388, 7);
            this.txtYear.Name = "txtYear";
            this.txtYear.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtYear.Properties.Appearance.Options.UseBackColor = true;
            this.txtYear.Properties.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(277, 20);
            this.txtYear.StyleController = this.layoutControl1;
            this.txtYear.TabIndex = 1;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlGroup2,
            this.layoutControlItem2,
            this.layoutControlItem9,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlGroup1.Size = new System.Drawing.Size(672, 151);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtYear;
            this.layoutControlItem1.Location = new System.Drawing.Point(330, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(332, 24);
            this.layoutControlItem1.Text = "年度";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtCreateTime;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(330, 24);
            this.layoutControlItem3.Text = "创建时间";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 72);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(662, 69);
            this.layoutControlGroup2.Text = "操作";
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnAdd;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(158, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnEdit;
            this.layoutControlItem6.Location = new System.Drawing.Point(158, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(160, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnDelete;
            this.layoutControlItem7.Location = new System.Drawing.Point(318, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(159, 26);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnEditRecord;
            this.layoutControlItem8.Location = new System.Drawing.Point(477, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(161, 26);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtRemark;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(662, 24);
            this.layoutControlItem2.Text = "备注";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.txtName;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(330, 24);
            this.layoutControlItem9.Text = "名称";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtUpdateTime;
            this.layoutControlItem4.Location = new System.Drawing.Point(330, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(332, 24);
            this.layoutControlItem4.Text = "更新时间";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(48, 14);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.frGrid);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(203, 183);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(676, 333);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "经费记录";
            // 
            // frGrid
            // 
            this.frGrid.DataSource = null;
            this.frGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frGrid.Editable = false;
            this.frGrid.Location = new System.Drawing.Point(2, 21);
            this.frGrid.Name = "frGrid";
            this.frGrid.ShowFooter = true;
            this.frGrid.ShowLineNumber = true;
            this.frGrid.Size = new System.Drawing.Size(672, 310);
            this.frGrid.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.lbFund);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(3, 3);
            this.groupControl3.Name = "groupControl3";
            this.tableLayoutPanel1.SetRowSpan(this.groupControl3, 2);
            this.groupControl3.Size = new System.Drawing.Size(194, 513);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "统计列表";
            // 
            // lbFund
            // 
            this.lbFund.DataSource = this.bsFund;
            this.lbFund.DisplayMember = "Name";
            this.lbFund.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbFund.Location = new System.Drawing.Point(2, 21);
            this.lbFund.Name = "lbFund";
            this.lbFund.Size = new System.Drawing.Size(190, 490);
            this.lbFund.SortOrder = System.Windows.Forms.SortOrder.Descending;
            this.lbFund.TabIndex = 0;
            this.lbFund.ValueMember = "Id";
            this.lbFund.SelectedIndexChanged += new System.EventHandler(this.lbFund_SelectedIndexChanged);
            // 
            // bsFund
            // 
            this.bsFund.DataSource = typeof(Poseidon.Energy.Core.DL.Fund);
            // 
            // FrmFundOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 519);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmFundOverview";
            this.Text = "经费统计总览";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdateTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbFund)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFund)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.BindingSource bsFund;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.ListBoxControl lbFund;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.TextEdit txtUpdateTime;
        private DevExpress.XtraEditors.TextEdit txtCreateTime;
        private DevExpress.XtraEditors.TextEdit txtRemark;
        private DevExpress.XtraEditors.TextEdit txtYear;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.SimpleButton btnEditRecord;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private FundRecordGrid frGrid;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
    }
}