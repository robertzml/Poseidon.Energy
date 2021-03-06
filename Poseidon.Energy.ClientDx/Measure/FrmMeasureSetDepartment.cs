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
    using Poseidon.Base.System;
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.Utility;

    /// <summary>
    /// 选择能源计量部门
    /// </summary>
    public partial class FrmMeasureSetDepartment : BaseSingleForm
    {
        #region Field
        private Measure currentMeasure;
        #endregion //Field

        #region Constructor
        public FrmMeasureSetDepartment(string measureId)
        {
            InitializeComponent();

            InitData(measureId);
        }
        #endregion //Constructor

        #region Function
        private void InitData(string measureId)
        {
            this.currentMeasure = BusinessFactory<MeasureBusiness>.Instance.FindById(measureId);
        }

        protected override void InitForm()
        {
            this.bsDepartment.DataSource = BusinessFactory<DepartmentBusiness>.Instance.FindInGroup(EnergyConstant.MeasureDepartmentGroupCode, true).ToList();
            SetSelectDepartment();

            base.InitForm();
        }

        /// <summary>
        /// 设置选中部门
        /// </summary>
        private void SetSelectDepartment()
        {
            var records = BusinessFactory<MeasureRecordBusiness>.Instance.FindByMeasureId(this.currentMeasure.Id);

            for (int i = 0; i < this.bsDepartment.Count; i++)
            {
                var department = this.bsDepartment[i] as Department;
                if (records.Any(r => r.DepartmentId == department.Id))
                    this.clbDepartments.SetItemChecked(i, true);
            }
        }

        /// <summary>
        /// 保存选中部门
        /// </summary>
        private void SaveSelectDepartment()
        {
            List<string> ids = new List<string>();

            foreach (Department item in this.clbDepartments.CheckedItems)
            {
                ids.Add(item.Id);
            }

            BusinessFactory<MeasureRecordBusiness>.Instance.CreateMany(this.currentMeasure.Id, ids, this.currentUser);
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            this.clbDepartments.CheckAll();
        }

        /// <summary>
        /// 反选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUncheckAll_Click(object sender, EventArgs e)
        {
            this.clbDepartments.UnCheckAll();
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                SaveSelectDepartment();

                MessageUtil.ShowInfo("保存成功");
                this.Close();
            }
            catch (PoseidonException pe)
            {
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
            }
        }
        #endregion //Event
    }
}
