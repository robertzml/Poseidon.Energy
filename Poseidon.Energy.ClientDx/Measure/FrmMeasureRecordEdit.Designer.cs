namespace Poseidon.Energy.ClientDx
{
    partial class FrmMeasureRecordEdit
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
            this.measureGroup = new Poseidon.Winform.Core.GroupsTree();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtRefTotalQuantum = new DevExpress.XtraEditors.TextEdit();
            this.txtRefDepartmentCount = new DevExpress.XtraEditors.TextEdit();
            this.luRefMeasure = new DevExpress.XtraEditors.LookUpEdit();
            this.bsMeasure = new System.Windows.Forms.BindingSource(this.components);
            this.txtTotalQuantum = new DevExpress.XtraEditors.TextEdit();
            this.txtDepartmentCount = new DevExpress.XtraEditors.TextEdit();
            this.txtEndTime = new DevExpress.XtraEditors.TextEdit();
            this.txtStartTime = new DevExpress.XtraEditors.TextEdit();
            this.txtEnergyType = new DevExpress.XtraEditors.TextEdit();
            this.txtBelongTime = new DevExpress.XtraEditors.TextEdit();
            this.txtGroupName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.mrGrid = new Poseidon.Energy.ClientDx.MeasureRecordGrid();
            ((System.ComponentModel.ISupportInitialize)(this.plFill)).BeginInit();
            this.plFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plBottom)).BeginInit();
            this.plBottom.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRefTotalQuantum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRefDepartmentCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luRefMeasure.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeasure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalQuantum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartmentCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnergyType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelongTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(713, 18);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(604, 18);
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // plFill
            // 
            this.plFill.Appearance.BackColor = System.Drawing.Color.White;
            this.plFill.Appearance.Options.UseBackColor = true;
            this.plFill.Controls.Add(this.tableLayoutPanel1);
            this.plFill.Size = new System.Drawing.Size(805, 490);
            // 
            // plBottom
            // 
            this.plBottom.Appearance.BackColor = System.Drawing.Color.White;
            this.plBottom.Appearance.Options.UseBackColor = true;
            this.plBottom.Location = new System.Drawing.Point(0, 490);
            this.plBottom.Size = new System.Drawing.Size(805, 60);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(805, 490);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.measureGroup);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.tableLayoutPanel1.SetRowSpan(this.groupControl1, 2);
            this.groupControl1.Size = new System.Drawing.Size(194, 484);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "能耗部门分组";
            // 
            // measureGroup
            // 
            this.measureGroup.DataSource = null;
            this.measureGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.measureGroup.Location = new System.Drawing.Point(2, 21);
            this.measureGroup.Name = "measureGroup";
            this.measureGroup.ShowCode = false;
            this.measureGroup.ShowRemark = false;
            this.measureGroup.Size = new System.Drawing.Size(190, 461);
            this.measureGroup.TabIndex = 0;
            this.measureGroup.GroupSelected += new System.Action<object, System.EventArgs>(this.measureGroup_GroupSelected);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.layoutControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(203, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(599, 194);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "基本信息";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtRefTotalQuantum);
            this.layoutControl1.Controls.Add(this.txtRefDepartmentCount);
            this.layoutControl1.Controls.Add(this.luRefMeasure);
            this.layoutControl1.Controls.Add(this.txtTotalQuantum);
            this.layoutControl1.Controls.Add(this.txtDepartmentCount);
            this.layoutControl1.Controls.Add(this.txtEndTime);
            this.layoutControl1.Controls.Add(this.txtStartTime);
            this.layoutControl1.Controls.Add(this.txtEnergyType);
            this.layoutControl1.Controls.Add(this.txtBelongTime);
            this.layoutControl1.Controls.Add(this.txtGroupName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(595, 171);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtRefTotalQuantum
            // 
            this.txtRefTotalQuantum.Location = new System.Drawing.Point(374, 132);
            this.txtRefTotalQuantum.Name = "txtRefTotalQuantum";
            this.txtRefTotalQuantum.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtRefTotalQuantum.Properties.Appearance.Options.UseBackColor = true;
            this.txtRefTotalQuantum.Properties.ReadOnly = true;
            this.txtRefTotalQuantum.Size = new System.Drawing.Size(209, 20);
            this.txtRefTotalQuantum.StyleController = this.layoutControl1;
            this.txtRefTotalQuantum.TabIndex = 13;
            // 
            // txtRefDepartmentCount
            // 
            this.txtRefDepartmentCount.Location = new System.Drawing.Point(87, 132);
            this.txtRefDepartmentCount.Name = "txtRefDepartmentCount";
            this.txtRefDepartmentCount.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtRefDepartmentCount.Properties.Appearance.Options.UseBackColor = true;
            this.txtRefDepartmentCount.Properties.ReadOnly = true;
            this.txtRefDepartmentCount.Size = new System.Drawing.Size(208, 20);
            this.txtRefDepartmentCount.StyleController = this.layoutControl1;
            this.txtRefDepartmentCount.TabIndex = 12;
            // 
            // luRefMeasure
            // 
            this.luRefMeasure.Location = new System.Drawing.Point(87, 108);
            this.luRefMeasure.Name = "luRefMeasure";
            this.luRefMeasure.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luRefMeasure.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 21, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "名称", 54, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Descending),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BelongTime", "归属时间", 78, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EnergyType", "能源类型", 80, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far)});
            this.luRefMeasure.Properties.DataSource = this.bsMeasure;
            this.luRefMeasure.Properties.DisplayMember = "Name";
            this.luRefMeasure.Properties.NullText = "请选择";
            this.luRefMeasure.Properties.ShowFooter = false;
            this.luRefMeasure.Properties.ValueMember = "Id";
            this.luRefMeasure.Size = new System.Drawing.Size(496, 20);
            this.luRefMeasure.StyleController = this.layoutControl1;
            this.luRefMeasure.TabIndex = 11;
            this.luRefMeasure.EditValueChanged += new System.EventHandler(this.luRefMeasure_EditValueChanged);
            // 
            // bsMeasure
            // 
            this.bsMeasure.DataSource = typeof(Poseidon.Energy.Core.DL.Measure);
            // 
            // txtTotalQuantum
            // 
            this.txtTotalQuantum.Location = new System.Drawing.Point(374, 84);
            this.txtTotalQuantum.Name = "txtTotalQuantum";
            this.txtTotalQuantum.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtTotalQuantum.Properties.Appearance.Options.UseBackColor = true;
            this.txtTotalQuantum.Properties.ReadOnly = true;
            this.txtTotalQuantum.Size = new System.Drawing.Size(209, 20);
            this.txtTotalQuantum.StyleController = this.layoutControl1;
            this.txtTotalQuantum.TabIndex = 10;
            // 
            // txtDepartmentCount
            // 
            this.txtDepartmentCount.Location = new System.Drawing.Point(87, 84);
            this.txtDepartmentCount.Name = "txtDepartmentCount";
            this.txtDepartmentCount.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtDepartmentCount.Properties.Appearance.Options.UseBackColor = true;
            this.txtDepartmentCount.Properties.ReadOnly = true;
            this.txtDepartmentCount.Size = new System.Drawing.Size(208, 20);
            this.txtDepartmentCount.StyleController = this.layoutControl1;
            this.txtDepartmentCount.TabIndex = 9;
            // 
            // txtEndTime
            // 
            this.txtEndTime.Location = new System.Drawing.Point(374, 60);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtEndTime.Properties.Appearance.Options.UseBackColor = true;
            this.txtEndTime.Properties.ReadOnly = true;
            this.txtEndTime.Size = new System.Drawing.Size(209, 20);
            this.txtEndTime.StyleController = this.layoutControl1;
            this.txtEndTime.TabIndex = 8;
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(87, 60);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtStartTime.Properties.Appearance.Options.UseBackColor = true;
            this.txtStartTime.Properties.ReadOnly = true;
            this.txtStartTime.Size = new System.Drawing.Size(208, 20);
            this.txtStartTime.StyleController = this.layoutControl1;
            this.txtStartTime.TabIndex = 7;
            // 
            // txtEnergyType
            // 
            this.txtEnergyType.Location = new System.Drawing.Point(374, 36);
            this.txtEnergyType.Name = "txtEnergyType";
            this.txtEnergyType.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtEnergyType.Properties.Appearance.Options.UseBackColor = true;
            this.txtEnergyType.Properties.ReadOnly = true;
            this.txtEnergyType.Size = new System.Drawing.Size(209, 20);
            this.txtEnergyType.StyleController = this.layoutControl1;
            this.txtEnergyType.TabIndex = 6;
            // 
            // txtBelongTime
            // 
            this.txtBelongTime.Location = new System.Drawing.Point(87, 36);
            this.txtBelongTime.Name = "txtBelongTime";
            this.txtBelongTime.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtBelongTime.Properties.Appearance.Options.UseBackColor = true;
            this.txtBelongTime.Properties.ReadOnly = true;
            this.txtBelongTime.Size = new System.Drawing.Size(208, 20);
            this.txtBelongTime.StyleController = this.layoutControl1;
            this.txtBelongTime.TabIndex = 5;
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(87, 12);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtGroupName.Properties.Appearance.Options.UseBackColor = true;
            this.txtGroupName.Properties.ReadOnly = true;
            this.txtGroupName.Size = new System.Drawing.Size(496, 20);
            this.txtGroupName.StyleController = this.layoutControl1;
            this.txtGroupName.TabIndex = 4;
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
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem10});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(595, 171);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtGroupName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(575, 24);
            this.layoutControlItem1.Text = "分组名称";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtBelongTime;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(287, 24);
            this.layoutControlItem2.Text = "归属时间";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtEnergyType;
            this.layoutControlItem3.Location = new System.Drawing.Point(287, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(288, 24);
            this.layoutControlItem3.Text = "能源类型";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtStartTime;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(287, 24);
            this.layoutControlItem4.Text = "起始时间";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtEndTime;
            this.layoutControlItem5.Location = new System.Drawing.Point(287, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(288, 24);
            this.layoutControlItem5.Text = "截至时间";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtDepartmentCount;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(287, 24);
            this.layoutControlItem6.Text = "部门数量";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtTotalQuantum;
            this.layoutControlItem7.Location = new System.Drawing.Point(287, 72);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(288, 24);
            this.layoutControlItem7.Text = "用量合计";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.luRefMeasure;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(575, 24);
            this.layoutControlItem8.Text = "选择参考记录";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.txtRefDepartmentCount;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(287, 31);
            this.layoutControlItem9.Text = "参考部门数量";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.txtRefTotalQuantum;
            this.layoutControlItem10.Location = new System.Drawing.Point(287, 120);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(288, 31);
            this.layoutControlItem10.Text = "参考用量合计";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(72, 14);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.mrGrid);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(203, 203);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(599, 284);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "能耗数据";
            // 
            // mrGrid
            // 
            this.mrGrid.AllowFilter = false;
            this.mrGrid.AllowGroup = false;
            this.mrGrid.AllowSort = false;
            this.mrGrid.DataSource = null;
            this.mrGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mrGrid.Editable = true;
            this.mrGrid.EnableMasterView = false;
            this.mrGrid.Location = new System.Drawing.Point(2, 21);
            this.mrGrid.Name = "mrGrid";
            this.mrGrid.ShowAddMenu = false;
            this.mrGrid.ShowFooter = true;
            this.mrGrid.ShowLineNumber = true;
            this.mrGrid.ShowMenu = false;
            this.mrGrid.ShowNavigator = false;
            this.mrGrid.Size = new System.Drawing.Size(595, 261);
            this.mrGrid.TabIndex = 0;
            // 
            // FrmMeasureRecordEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 550);
            this.Name = "FrmMeasureRecordEdit";
            this.Text = "录入能耗记录";
            ((System.ComponentModel.ISupportInitialize)(this.plFill)).EndInit();
            this.plFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plBottom)).EndInit();
            this.plBottom.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtRefTotalQuantum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRefDepartmentCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luRefMeasure.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeasure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalQuantum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartmentCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnergyType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelongTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private Winform.Core.GroupsTree measureGroup;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtGroupName;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private MeasureRecordGrid mrGrid;
        private DevExpress.XtraEditors.TextEdit txtEnergyType;
        private DevExpress.XtraEditors.TextEdit txtBelongTime;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TextEdit txtEndTime;
        private DevExpress.XtraEditors.TextEdit txtStartTime;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.TextEdit txtTotalQuantum;
        private DevExpress.XtraEditors.TextEdit txtDepartmentCount;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.TextEdit txtRefTotalQuantum;
        private DevExpress.XtraEditors.TextEdit txtRefDepartmentCount;
        private DevExpress.XtraEditors.LookUpEdit luRefMeasure;
        private System.Windows.Forms.BindingSource bsMeasure;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
    }
}