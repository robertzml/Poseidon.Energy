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
    using Poseidon.Base.System;
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.Utility;

    /// <summary>
    /// 选择能源结算部门
    /// </summary>
    public partial class FrmSettlementSetDepartment : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前关联结算
        /// </summary>
        private Settlement currentSettlement;
        #endregion //Field

        #region Constructor
        public FrmSettlementSetDepartment(string settlementId)
        {
            InitializeComponent();
            InitData(settlementId);
        }
        #endregion //Constructor

        #region Function
        private void InitData(string settlementId)
        {
            this.currentSettlement = BusinessFactory<SettlementBusiness>.Instance.FindById(settlementId);
        }

        protected override void InitForm()
        {
            this.bsDepartment.DataSource = BusinessFactory<DepartmentBusiness>.Instance.FindInGroup(EnergyConstant.SettlementDepartmentGroupCode, true).ToList();
            SetSelectDepartment();

            base.InitForm();
        }

        /// <summary>
        /// 设置选中部门
        /// </summary>
        private void SetSelectDepartment()
        {
            var records = BusinessFactory<SettlementRecordBusiness>.Instance.FindBySettlement(this.currentSettlement.Id, EnergyType.Electric);

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

            BusinessFactory<SettlementRecordBusiness>.Instance.CreateMany(this.currentSettlement.Id, ids, this.currentUser);
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
