namespace Poseidon.Energy.ClientDx
{
    partial class WaterExpenseReceipt
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
            this.lbWaterReceipt = new DevExpress.XtraEditors.ListBoxControl();
            this.bsWaterExpense = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.waterExpRecGrid = new Poseidon.Energy.ClientDx.WaterExpenseRecordGrid();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtRemark = new DevExpress.XtraEditors.MemoEdit();
            this.txtEditTime = new DevExpress.XtraEditors.TextEdit();
            this.txtEditUser = new DevExpress.XtraEditors.TextEdit();
            this.txtCreateTime = new DevExpress.XtraEditors.TextEdit();
            this.txtCreateUser = new DevExpress.XtraEditors.TextEdit();
            this.txtTotalAmount = new DevExpress.XtraEditors.TextEdit();
            this.txtTotalQuantity = new DevExpress.XtraEditors.TextEdit();
            this.txtFeeType = new DevExpress.XtraEditors.TextEdit();
            this.txtTicketDate = new DevExpress.XtraEditors.TextEdit();
            this.txtBelongDate = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem18 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem20 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem21 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcGroupAction = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem22 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem23 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lbWaterReceipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWaterExpense)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFeeType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTicketDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelongDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcGroupAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem23)).BeginInit();
            this.SuspendLayout();
            // 
            // lbWaterReceipt
            // 
            this.lbWaterReceipt.DataSource = this.bsWaterExpense;
            this.lbWaterReceipt.DisplayMember = "BelongDate";
            this.lbWaterReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbWaterReceipt.Location = new System.Drawing.Point(3, 3);
            this.lbWaterReceipt.Name = "lbWaterReceipt";
            this.lbWaterReceipt.Size = new System.Drawing.Size(154, 471);
            this.lbWaterReceipt.TabIndex = 4;
            this.lbWaterReceipt.ValueMember = "Id";
            this.lbWaterReceipt.SelectedIndexChanged += new System.EventHandler(this.lbWaterReceipt_SelectedIndexChanged);
            // 
            // bsWaterExpense
            // 
            this.bsWaterExpense.DataSource = typeof(Poseidon.Energy.Core.DL.WaterExpense);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lbWaterReceipt, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.layoutControl1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(896, 477);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.waterExpRecGrid);
            this.layoutControl1.Controls.Add(this.btnDelete);
            this.layoutControl1.Controls.Add(this.btnEdit);
            this.layoutControl1.Controls.Add(this.btnAdd);
            this.layoutControl1.Controls.Add(this.txtRemark);
            this.layoutControl1.Controls.Add(this.txtEditTime);
            this.layoutControl1.Controls.Add(this.txtEditUser);
            this.layoutControl1.Controls.Add(this.txtCreateTime);
            this.layoutControl1.Controls.Add(this.txtCreateUser);
            this.layoutControl1.Controls.Add(this.txtTotalAmount);
            this.layoutControl1.Controls.Add(this.txtTotalQuantity);
            this.layoutControl1.Controls.Add(this.txtFeeType);
            this.layoutControl1.Controls.Add(this.txtTicketDate);
            this.layoutControl1.Controls.Add(this.txtBelongDate);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(163, 3);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(730, 471);
            this.layoutControl1.TabIndex = 5;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // waterExpRecGrid
            // 
            this.waterExpRecGrid.AllowFilter = true;
            this.waterExpRecGrid.AllowGroup = true;
            this.waterExpRecGrid.AllowSort = true;
            this.waterExpRecGrid.DataSource = null;
            this.waterExpRecGrid.Editable = false;
            this.waterExpRecGrid.Location = new System.Drawing.Point(12, 177);
            this.waterExpRecGrid.Name = "waterExpRecGrid";
            this.waterExpRecGrid.ShowAddMenu = false;
            this.waterExpRecGrid.ShowFooter = false;
            this.waterExpRecGrid.ShowLineNumber = true;
            this.waterExpRecGrid.ShowNavigator = false;
            this.waterExpRecGrid.Size = new System.Drawing.Size(706, 282);
            this.waterExpRecGrid.TabIndex = 18;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(494, 139);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(212, 22);
            this.btnDelete.StyleController = this.layoutControl1;
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "删除单据";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(249, 139);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(241, 22);
            this.btnEdit.StyleController = this.layoutControl1;
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "编辑单据";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(24, 139);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(221, 22);
            this.btnAdd.StyleController = this.layoutControl1;
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "登记单据";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(572, 36);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtRemark.Properties.Appearance.Options.UseBackColor = true;
            this.txtRemark.Properties.ReadOnly = true;
            this.txtRemark.Size = new System.Drawing.Size(146, 68);
            this.txtRemark.StyleController = this.layoutControl1;
            this.txtRemark.TabIndex = 14;
            // 
            // txtEditTime
            // 
            this.txtEditTime.Location = new System.Drawing.Point(323, 84);
            this.txtEditTime.Name = "txtEditTime";
            this.txtEditTime.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtEditTime.Properties.Appearance.Options.UseBackColor = true;
            this.txtEditTime.Properties.ReadOnly = true;
            this.txtEditTime.Size = new System.Drawing.Size(172, 20);
            this.txtEditTime.StyleController = this.layoutControl1;
            this.txtEditTime.TabIndex = 13;
            // 
            // txtEditUser
            // 
            this.txtEditUser.Location = new System.Drawing.Point(85, 84);
            this.txtEditUser.Name = "txtEditUser";
            this.txtEditUser.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtEditUser.Properties.Appearance.Options.UseBackColor = true;
            this.txtEditUser.Properties.ReadOnly = true;
            this.txtEditUser.Size = new System.Drawing.Size(161, 20);
            this.txtEditUser.StyleController = this.layoutControl1;
            this.txtEditUser.TabIndex = 12;
            // 
            // txtCreateTime
            // 
            this.txtCreateTime.Location = new System.Drawing.Point(323, 60);
            this.txtCreateTime.Name = "txtCreateTime";
            this.txtCreateTime.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtCreateTime.Properties.Appearance.Options.UseBackColor = true;
            this.txtCreateTime.Properties.ReadOnly = true;
            this.txtCreateTime.Size = new System.Drawing.Size(172, 20);
            this.txtCreateTime.StyleController = this.layoutControl1;
            this.txtCreateTime.TabIndex = 11;
            // 
            // txtCreateUser
            // 
            this.txtCreateUser.Location = new System.Drawing.Point(85, 60);
            this.txtCreateUser.Name = "txtCreateUser";
            this.txtCreateUser.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtCreateUser.Properties.Appearance.Options.UseBackColor = true;
            this.txtCreateUser.Properties.ReadOnly = true;
            this.txtCreateUser.Size = new System.Drawing.Size(161, 20);
            this.txtCreateUser.StyleController = this.layoutControl1;
            this.txtCreateUser.TabIndex = 10;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(323, 36);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtTotalAmount.Properties.Appearance.Options.UseBackColor = true;
            this.txtTotalAmount.Properties.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(172, 20);
            this.txtTotalAmount.StyleController = this.layoutControl1;
            this.txtTotalAmount.TabIndex = 9;
            // 
            // txtTotalQuantity
            // 
            this.txtTotalQuantity.Location = new System.Drawing.Point(85, 36);
            this.txtTotalQuantity.Name = "txtTotalQuantity";
            this.txtTotalQuantity.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtTotalQuantity.Properties.Appearance.Options.UseBackColor = true;
            this.txtTotalQuantity.Properties.ReadOnly = true;
            this.txtTotalQuantity.Size = new System.Drawing.Size(161, 20);
            this.txtTotalQuantity.StyleController = this.layoutControl1;
            this.txtTotalQuantity.TabIndex = 8;
            // 
            // txtFeeType
            // 
            this.txtFeeType.Location = new System.Drawing.Point(572, 12);
            this.txtFeeType.Name = "txtFeeType";
            this.txtFeeType.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtFeeType.Properties.Appearance.Options.UseBackColor = true;
            this.txtFeeType.Properties.ReadOnly = true;
            this.txtFeeType.Size = new System.Drawing.Size(146, 20);
            this.txtFeeType.StyleController = this.layoutControl1;
            this.txtFeeType.TabIndex = 7;
            // 
            // txtTicketDate
            // 
            this.txtTicketDate.Location = new System.Drawing.Point(323, 12);
            this.txtTicketDate.Name = "txtTicketDate";
            this.txtTicketDate.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtTicketDate.Properties.Appearance.Options.UseBackColor = true;
            this.txtTicketDate.Properties.ReadOnly = true;
            this.txtTicketDate.Size = new System.Drawing.Size(172, 20);
            this.txtTicketDate.StyleController = this.layoutControl1;
            this.txtTicketDate.TabIndex = 6;
            // 
            // txtBelongDate
            // 
            this.txtBelongDate.Location = new System.Drawing.Point(85, 12);
            this.txtBelongDate.Name = "txtBelongDate";
            this.txtBelongDate.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtBelongDate.Properties.Appearance.Options.UseBackColor = true;
            this.txtBelongDate.Properties.ReadOnly = true;
            this.txtBelongDate.Size = new System.Drawing.Size(161, 20);
            this.txtBelongDate.StyleController = this.layoutControl1;
            this.txtBelongDate.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem10,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem11,
            this.layoutControlItem12,
            this.layoutControlItem16,
            this.layoutControlItem17,
            this.layoutControlItem18,
            this.layoutControlItem20,
            this.layoutControlItem21,
            this.lcGroupAction,
            this.layoutControlItem23});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(730, 471);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.txtBelongDate;
            this.layoutControlItem10.CustomizationFormText = "归属日期";
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(238, 24);
            this.layoutControlItem10.Text = "归属日期";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(70, 14);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtTicketDate;
            this.layoutControlItem8.Location = new System.Drawing.Point(238, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(249, 24);
            this.layoutControlItem8.Text = "票据日期";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(70, 14);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.txtFeeType;
            this.layoutControlItem9.Location = new System.Drawing.Point(487, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(223, 24);
            this.layoutControlItem9.Text = "费用类型";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(70, 14);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.txtTotalQuantity;
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(238, 24);
            this.layoutControlItem11.Text = "用水量(吨)";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(70, 14);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.txtTotalAmount;
            this.layoutControlItem12.Location = new System.Drawing.Point(238, 24);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(249, 24);
            this.layoutControlItem12.Text = "用水金额(元)";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(70, 14);
            // 
            // layoutControlItem16
            // 
            this.layoutControlItem16.Control = this.txtCreateUser;
            this.layoutControlItem16.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem16.Name = "layoutControlItem16";
            this.layoutControlItem16.Size = new System.Drawing.Size(238, 24);
            this.layoutControlItem16.Text = "登记人";
            this.layoutControlItem16.TextSize = new System.Drawing.Size(70, 14);
            // 
            // layoutControlItem17
            // 
            this.layoutControlItem17.Control = this.txtCreateTime;
            this.layoutControlItem17.Location = new System.Drawing.Point(238, 48);
            this.layoutControlItem17.Name = "layoutControlItem17";
            this.layoutControlItem17.Size = new System.Drawing.Size(249, 24);
            this.layoutControlItem17.Text = "登记时间";
            this.layoutControlItem17.TextSize = new System.Drawing.Size(70, 14);
            // 
            // layoutControlItem18
            // 
            this.layoutControlItem18.Control = this.txtEditUser;
            this.layoutControlItem18.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem18.Name = "layoutControlItem18";
            this.layoutControlItem18.Size = new System.Drawing.Size(238, 24);
            this.layoutControlItem18.Text = "编辑人";
            this.layoutControlItem18.TextSize = new System.Drawing.Size(70, 14);
            // 
            // layoutControlItem20
            // 
            this.layoutControlItem20.Control = this.txtEditTime;
            this.layoutControlItem20.Location = new System.Drawing.Point(238, 72);
            this.layoutControlItem20.Name = "layoutControlItem20";
            this.layoutControlItem20.Size = new System.Drawing.Size(249, 24);
            this.layoutControlItem20.Text = "编辑时间";
            this.layoutControlItem20.TextSize = new System.Drawing.Size(70, 14);
            // 
            // layoutControlItem21
            // 
            this.layoutControlItem21.Control = this.txtRemark;
            this.layoutControlItem21.Location = new System.Drawing.Point(487, 24);
            this.layoutControlItem21.Name = "layoutControlItem21";
            this.layoutControlItem21.Size = new System.Drawing.Size(223, 72);
            this.layoutControlItem21.Text = "备注";
            this.layoutControlItem21.TextSize = new System.Drawing.Size(70, 14);
            // 
            // lcGroupAction
            // 
            this.lcGroupAction.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem22,
            this.layoutControlItem6,
            this.layoutControlItem5});
            this.lcGroupAction.Location = new System.Drawing.Point(0, 96);
            this.lcGroupAction.Name = "lcGroupAction";
            this.lcGroupAction.Size = new System.Drawing.Size(710, 69);
            this.lcGroupAction.Text = "操作";
            // 
            // layoutControlItem22
            // 
            this.layoutControlItem22.Control = this.btnDelete;
            this.layoutControlItem22.Location = new System.Drawing.Point(470, 0);
            this.layoutControlItem22.Name = "layoutControlItem22";
            this.layoutControlItem22.Size = new System.Drawing.Size(216, 26);
            this.layoutControlItem22.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem22.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnEdit;
            this.layoutControlItem6.Location = new System.Drawing.Point(225, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(245, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnAdd;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(225, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem23
            // 
            this.layoutControlItem23.Control = this.waterExpRecGrid;
            this.layoutControlItem23.Location = new System.Drawing.Point(0, 165);
            this.layoutControlItem23.Name = "layoutControlItem23";
            this.layoutControlItem23.Size = new System.Drawing.Size(710, 286);
            this.layoutControlItem23.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem23.TextVisible = false;
            // 
            // WaterExpenseReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "WaterExpenseReceipt";
            this.Size = new System.Drawing.Size(896, 477);
            this.Load += new System.EventHandler(this.WaterExpenseControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lbWaterReceipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWaterExpense)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFeeType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTicketDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelongDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcGroupAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem23)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.ListBoxControl lbWaterReceipt;
        private System.Windows.Forms.BindingSource bsWaterExpense;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txtBelongDate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraEditors.TextEdit txtTotalAmount;
        private DevExpress.XtraEditors.TextEdit txtTotalQuantity;
        private DevExpress.XtraEditors.TextEdit txtFeeType;
        private DevExpress.XtraEditors.TextEdit txtTicketDate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private WaterExpenseRecordGrid waterExpRecGrid;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.MemoEdit txtRemark;
        private DevExpress.XtraEditors.TextEdit txtEditTime;
        private DevExpress.XtraEditors.TextEdit txtEditUser;
        private DevExpress.XtraEditors.TextEdit txtCreateTime;
        private DevExpress.XtraEditors.TextEdit txtCreateUser;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem16;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem17;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem18;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem20;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem21;
        private DevExpress.XtraLayout.LayoutControlGroup lcGroupAction;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem22;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem23;
    }
}
