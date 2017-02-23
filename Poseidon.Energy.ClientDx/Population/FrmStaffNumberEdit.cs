using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Poseidon.Energy.ClientDx
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Winform.Base;

    /// <summary>
    /// 编辑人数记录
    /// </summary>
    public partial class FrmStaffNumberEdit : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前关联人数统计
        /// </summary>
        private Population currentEntity;
        #endregion //Field

        #region Constructor
        public FrmStaffNumberEdit(string populationId)
        {
            InitializeComponent();

            InitData(populationId);
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 初始化数据
        /// </summary>
        /// <param name="populationId"></param>
        private void InitData(string populationId)
        {
            this.currentEntity = BusinessFactory<PopulationBusiness>.Instance.FindById(populationId);
        }

        protected override void InitForm()
        {
            this.txtYear.Text = this.currentEntity.Year.ToString();
            this.txtBelongTime.Text = this.currentEntity.BelongTime.ToString();

            var data = LoadStaffNumbers();
            this.snGrid.DataSource = data;

            base.InitForm();
        }

        /// <summary>
        /// 载入人数记录
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// 同时插入未统计部门
        /// </remarks>
        private List<StaffNumber> LoadStaffNumbers()
        {
            var numbers = BusinessFactory<StaffNumberBusiness>.Instance.FindByPopulationId(currentEntity.Id);
            var departments = BusinessFactory<DepartmentBusiness>.Instance.FindAll();

            List<StaffNumber> data = new List<StaffNumber>();
            data.AddRange(numbers);

            foreach (var item in departments)
            {
                if (!numbers.Any(r => r.DepartmentId == item.Id))
                {
                    StaffNumber sn = new StaffNumber();
                    sn.PopulationId = this.currentEntity.Id;
                    sn.DepartmentId = item.Id;

                    data.Add(sn);
                }
            }

            return data;
        }

        private void SetEntity(List<StaffNumber> entity)
        {
            foreach (var item in entity)
            {
                item.PopulationId = this.currentEntity.Id;
                item.Remark = item.Remark == null ? "" : item.Remark;
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
            this.snGrid.CloseEditor();

            var data = this.snGrid.DataSource;
            SetEntity(data);

            try
            {
                BusinessFactory<StaffNumberBusiness>.Instance.Update(data);

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
