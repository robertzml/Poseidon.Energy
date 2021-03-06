﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Energy.ClientDx
{
    using Poseidon.Base.Framework;
    using Poseidon.Core.BL;
    using Poseidon.Core.DL;
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.ClientDx.Report;
    using DevExpress.XtraReports.UI;

    /// <summary>
    /// 部门总览窗体
    /// </summary>
    public partial class FrmDepartmentOverview : BaseMdiForm
    {
        #region Field
        /// <summary>
        /// 关联部门列表
        /// </summary>
        private List<Department> bindDepartments;
        #endregion //Field

        #region Constructor
        public FrmDepartmentOverview()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 初始化窗体
        /// </summary>
        protected override void InitForm()
        {
            LoadGroups();
            LoadDepartment();

            base.InitForm();
        }

        /// <summary>
        /// 载入分组
        /// </summary>
        private void LoadGroups()
        {
            var groups = BusinessFactory<GroupBusiness>.Instance.FindByModelType(Core.Utility.ModelTypeCode.Department).ToList();

            this.gtDepartment.DataSource = groups;
        }

        /// <summary>
        /// 载入部门
        /// </summary>
        private void LoadDepartment()
        {
            this.bindDepartments = BusinessFactory<DepartmentBusiness>.Instance.FindAll().ToList();
            this.depGrid.DataSource = this.bindDepartments;
            this.depTree.DataSource = this.bindDepartments;
        }

        /// <summary>
        /// 筛选部门
        /// </summary>
        /// <param name="group">关联分组</param>
        /// <param name="include">是否显示子分组部门</param>
        private void FilterDepartment(Group group, bool include)
        {
            var data = BusinessFactory<DepartmentBusiness>.Instance.FindInGroup(group.Code, include).ToList();

            this.depGrid.DataSource = data;
            this.depGrid.UpdateBindingData();

            this.depTree.DataSource = data;
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 显示全部
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            this.depGrid.DataSource = this.bindDepartments;
            this.depGrid.UpdateBindingData();

            this.depTree.DataSource = this.bindDepartments;
        }

        /// <summary>
        /// 添加部门
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmDepartmentAdd));

            LoadDepartment();
        }

        /// <summary>
        /// 编辑部门
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            var select = this.depGrid.GetCurrentSelect();
            if (select == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmDepartmentEdit), new object[] { select.Id });
            LoadDepartment();
        }

        /// <summary>
        /// 选择分组
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        private void gtDepartment_GroupSelected(object arg1, EventArgs arg2)
        {
            var select = this.gtDepartment.GetCurrentSelect();
            if (select == null)
                return;

            FilterDepartment(select, this.chkInclude.Checked);
        }

        /// <summary>
        /// 打印票据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            BonusReport report = new BonusReport();

            ReportPrintTool printTool = new ReportPrintTool(report);

            printTool.ShowRibbonPreview();
        }
        #endregion //Event
    }
}
