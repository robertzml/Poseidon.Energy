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
    using Poseidon.Core.BL;
    using Poseidon.Core.DL;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.Utility;
    using Poseidon.Winform.Base;

    /// <summary>
    /// 人数统计记录编辑
    /// </summary>
    public partial class FrmPopulationRecordEdit : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前关联记录
        /// </summary>
        private PopulationRecord currentRecord;
        #endregion //Field

        #region Constructor
        public FrmPopulationRecordEdit(string id)
        {
            InitializeComponent();

            InitData(id);
        }
        #endregion //Constructor

        #region Function
        private void InitData(string id)
        {
            this.currentRecord = BusinessFactory<PopulationRecordBusiness>.Instance.FindById(id);
        }

        protected override void InitForm()
        {
            var department = BusinessFactory<DepartmentBusiness>.Instance.FindById(this.currentRecord.DepartmentId);
            this.txtDepartmentName.Text = department.Name;

            SetDetailGrid();

            base.InitForm();
        }

        /// <summary>
        /// 设置人数记录表格
        /// </summary>
        private void SetDetailGrid()
        {
            List<PopulationDetail> details = new List<PopulationDetail>();
            details.AddRange(this.currentRecord.Details);

            var dict1 = BusinessFactory<DictBusiness>.Instance.FindItems(EnergyConstant.TeacherDictCode);
            foreach (var dictItem in dict1)
            {
                if (details.Any(r => r.Code == dictItem.Value))
                    continue;

                PopulationDetail detail = new PopulationDetail
                {
                    Code = dictItem.Value,
                    Name = dictItem.Remark,
                    Number = 0,
                    InTotal = false
                };

                details.Add(detail);
            }

            var dict2 = BusinessFactory<DictBusiness>.Instance.FindItems(EnergyConstant.StudentDictCode);
            foreach (var dictItem in dict2)
            {
                if (details.Any(r => r.Code == dictItem.Value))
                    continue;

                PopulationDetail detail = new PopulationDetail
                {
                    Code = dictItem.Value,
                    Name = dictItem.Remark,
                    Number = 0,
                    InTotal = false
                };

                details.Add(detail);
            }

            this.popDetailsGrid.DataSource = details;
        }

        /// <summary>
        /// 输入检查
        /// </summary>
        /// <returns></returns>
        private Tuple<bool, string> CheckInput()
        {
            string errorMessage = "";

            foreach (var item in this.popDetailsGrid.DataSource)
            {
                if (string.IsNullOrEmpty(item.Name))
                {
                    errorMessage = "人员类型不能为空";
                    return new Tuple<bool, string>(false, errorMessage);
                }
                if (string.IsNullOrEmpty(item.Code))
                {
                    errorMessage = "人员代码不能为空";
                    return new Tuple<bool, string>(false, errorMessage);
                }
            }

            return new Tuple<bool, string>(true, "");
        }

        /// <summary>
        /// 设置实体
        /// </summary>
        /// <param name="details"></param>
        private void SetEntity(List<PopulationDetail> details)
        {
            details.RemoveAll(r => r.Number <= 0);
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
            this.popDetailsGrid.CloseEditor();

            var input = CheckInput();
            if (!input.Item1)
            {
                MessageUtil.ShowError(input.Item2);
                return;
            }

            var data = this.popDetailsGrid.DataSource;
            SetEntity(data);

            try
            {
                bool result = BusinessFactory<PopulationRecordBusiness>.Instance.UpdateRecordDetails(this.currentRecord.Id, data, this.currentUser);

                if (result)
                {
                    MessageUtil.ShowInfo("保存成功");
                    this.Close();
                }
                else
                {
                    MessageUtil.ShowInfo("保存失败");
                }
            }
            catch (PoseidonException pe)
            {
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
            }
        }
        #endregion //Event
    }
}
