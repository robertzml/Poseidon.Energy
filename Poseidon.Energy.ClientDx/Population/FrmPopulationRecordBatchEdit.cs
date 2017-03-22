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
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.Utility;
    using Poseidon.Winform.Base;

    /// <summary>
    /// 批量编辑人数记录窗体
    /// </summary>
    public partial class FrmPopulationRecordBatchEdit : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前关联人数统计
        /// </summary>
        private Population currentEntity;
        #endregion //Field

        #region Constructor
        public FrmPopulationRecordBatchEdit(string populationId)
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
            this.txtName.Text = this.currentEntity.Name;
            this.txtYear.Text = this.currentEntity.Year.ToString();
            this.txtBelongTime.Text = this.currentEntity.BelongTime;
            this.txtRemark.Text = this.currentEntity.Remark;

            var data = LoadPopulationRecords();
            this.prGrid.DataSource = data;

            base.InitForm();
        }

        /// <summary>
        /// 载入人数记录
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// 同时插入未统计部门
        /// </remarks>
        private List<PopulationRecord> LoadPopulationRecords()
        {
            var records = BusinessFactory<PopulationRecordBusiness>.Instance.FindByPopulationId(currentEntity.Id);
            var departments = BusinessFactory<DepartmentBusiness>.Instance.FindInGroup(EnergyConstant.PopulationDepartmentGroupCode, true);

            List<PopulationRecord> data = new List<PopulationRecord>();
            data.AddRange(records);

            foreach (var item in departments)
            {
                if (!records.Any(r => r.DepartmentId == item.Id))
                {
                    PopulationRecord pr = new PopulationRecord();
                    pr.PopulationId = this.currentEntity.Id;
                    pr.DepartmentId = item.Id;
                    pr.Details = new List<PopulationDetail>();

                    data.Add(pr);
                }
            }

            return data;
        }

        /// <summary>
        /// 设置人数记录项
        /// </summary>
        /// <param name="entity">人数记录项</param>
        private void SetEntity(List<PopulationRecord> entity)
        {
            foreach (var item in entity)
            {
                //item.Details.RemoveAll(r => r.Number <= 0);
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
            this.prGrid.CloseEditor();

            var data = this.prGrid.DataSource;
            SetEntity(data);

            try
            {
                BusinessFactory<PopulationRecordBusiness>.Instance.UpdateRecords(data, this.currentUser);

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
