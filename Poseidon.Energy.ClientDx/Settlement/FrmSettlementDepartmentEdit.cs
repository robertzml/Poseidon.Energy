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
    /// 编辑结算部门记录
    /// </summary>
    public partial class FrmSettlementDepartmentEdit : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 部门ID
        /// </summary>
        private string departmentId;

        /// <summary>
        /// 年度
        /// </summary>
        private int year;

        /// <summary>
        /// 能源类型
        /// </summary>
        private EnergyType energyType;
        #endregion //Field

        #region Constructor
        public FrmSettlementDepartmentEdit(string departmentId, int year, EnergyType energyType)
        {
            InitializeComponent();

            InitData(departmentId, year, energyType);
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 初始化数据
        /// </summary>
        /// <param name="departmentId"></param>
        /// <param name="year"></param>
        /// <param name="energyType"></param>
        private void InitData(string departmentId, int year, EnergyType energyType)
        {
            this.departmentId = departmentId;
            this.year = year;
            this.energyType = energyType;
        }

        protected override void InitForm()
        {
            var records = BusinessFactory<SettlementRecordBusiness>.Instance.FindByDepartment(departmentId, year, energyType);

            this.recordGrid.DataSource = records.ToList();

            base.InitForm();
        }

        /// <summary>
        /// 设置对象
        /// </summary>
        /// <param name="entity"></param>
        private void SetEntity(List<SettlementRecord> entity)
        {
            foreach (var item in entity)
            {
                item.Remark = item.Remark ?? "";
            }
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                this.recordGrid.CloseEditor();
                var recrods = this.recordGrid.DataSource;
                SetEntity(recrods);
                BusinessFactory<SettlementRecordBusiness>.Instance.Update(recrods, this.currentUser);

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
