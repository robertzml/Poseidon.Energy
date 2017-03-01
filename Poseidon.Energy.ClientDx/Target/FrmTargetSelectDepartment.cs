using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Energy.ClientDx
{
    using DevExpress.XtraEditors.Controls;
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 指标计划部门选择窗体
    /// </summary>
    public partial class FrmTargetSelectDepartment : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 关联指标计划
        /// </summary>
        private Target currentEntity;
        #endregion //Field

        #region Constructor
        public FrmTargetSelectDepartment(string targetId)
        {
            InitializeComponent();

            InitData(targetId);
        }
        #endregion //Constructor

        #region Function
        private void InitData(string id)
        {
            this.currentEntity = BusinessFactory<TargetBusiness>.Instance.FindById(id);
        }

        protected override void InitForm()
        {
            var departments = BusinessFactory<DepartmentBusiness>.Instance.FindAll().ToList();
            this.bsDepartment.DataSource = departments;    

            SetSelectDepartment();

            base.InitForm();
        }

        /// <summary>
        /// 设置选中部门
        /// </summary>
        private void SetSelectDepartment()
        {
            var records = BusinessFactory<TargetRecordBusiness>.Instance.FindByTarget(this.currentEntity.Id);

            for (int i = 0; i < this.bsDepartment.Count; i++)
            {
                var department = this.bsDepartment[i] as Department;
                if (records.Any(r => r.DepartmentId == department.Id))
                    this.clbDepartment.SetItemChecked(i, true);
            }
        }

        /// <summary>
        /// 保存选中部门
        /// </summary>
        private void SaveSelectDepartment()
        {
            List<string> ids = new List<string>();

            foreach (Department item in this.clbDepartment.CheckedItems)
            {
                ids.Add(item.Id);
            }

            BusinessFactory<TargetRecordBusiness>.Instance.Set(this.currentEntity.Id, ids);
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
            this.clbDepartment.CheckAll();
        }

        /// <summary>
        /// 反选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUncheckAll_Click(object sender, EventArgs e)
        {
            this.clbDepartment.UnCheckAll();
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
