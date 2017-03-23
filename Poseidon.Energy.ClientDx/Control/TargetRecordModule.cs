using System;
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
    using Poseidon.Common;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 指标记录信息组件
    /// </summary>
    public partial class TargetRecordModule : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联指标记录
        /// </summary>
        private TargetRecord currentRecord;
        #endregion //Field

        #region Constructor
        public TargetRecordModule()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 显示信息
        /// </summary>
        /// <param name="entity"></param>
        private void DisplayInfo(TargetRecord entity)
        {
            this.txtDepartmentName.Text = BusinessFactory<DepartmentBusiness>.Instance.FindById(entity.DepartmentId).Name;

            this.txtType.Text = Poseidon.Core.Utility.DictUtility.GetDictValue(entity, "Type", entity.Type);
            this.txtFinance.Text = entity.Finance;
            this.spSchoolTake.Value = entity.SchoolTake;
            this.spSelfTake.Value = entity.SelfTake;
            this.txtRemark.Text = entity.Remark;
            this.txtPlanQuantum.Text = entity.PlanQuantum.ToString();
            this.txtPlanAmount.Text = entity.PlanAmount.ToString();
            this.txtCreateUser.Text = entity.CreateBy.Name;
            this.txtCreateTime.Text = entity.CreateBy.Time.ToDateTimeString();
            this.txtEditUser.Text = entity.UpdateBy.Name;
            this.txtEditTime.Text = entity.UpdateBy.Time.ToDateTimeString();

            this.stGrid.DataSource = entity.StaffTarget;
            this.atGrid.DataSource = entity.AllowanceTarget;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 设置指标记录
        /// </summary>
        /// <param name="id">指标记录ID</param>
        public void SetTargetRecord(string id)
        {
            this.currentRecord = BusinessFactory<TargetRecordBusiness>.Instance.FindById(id);
            DisplayInfo(this.currentRecord);
        }

        /// <summary>
        /// 清空显示
        /// </summary>
        public void Clear()
        {
            this.txtDepartmentName.Text = "";

            this.txtType.Text = "";
            this.txtFinance.Text = "";
            this.spSchoolTake.Value = 0;
            this.spSelfTake.Value = 0;
            this.txtRemark.Text = "";
            this.txtPlanQuantum.Text = "";
            this.txtPlanAmount.Text = "";
            this.txtCreateUser.Text = "";
            this.txtCreateTime.Text = "";
            this.txtEditUser.Text = "";
            this.txtEditTime.Text = "";

            this.stGrid.DataSource = null;
            this.atGrid.DataSource = null;
        }
        #endregion //Method
    }
}
