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
    using Poseidon.Common;
    using Poseidon.Core.Utility;
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.Utility;

    /// <summary>
    /// 能源计量管理窗体
    /// </summary>
    public partial class FrmMeasureManage : BaseMdiForm
    {
        #region Field
        /// <summary>
        /// 当前选择计量
        /// </summary>
        private Measure currentMeasure;
        #endregion //Field

        #region Constructor
        public FrmMeasureManage()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            LoadMeasures();

            this.mrGrid.Init();
            base.InitForm();
        }

        /// <summary>
        /// 加载能源计量列表
        /// </summary>
        private void LoadMeasures()
        {
            var measures = BusinessFactory<MeasureBusiness>.Instance.FindAll().OrderByDescending(r => r.StartTime).ToList();
            this.bsMeasure.DataSource = measures;
        }

        /// <summary>
        /// 显示信息
        /// </summary>
        /// <param name="entity">能源计量信息</param>
        private void DisplayInfo(Measure entity)
        {
            this.txtName.Text = entity.Name;
            this.txtYear.Text = entity.Year.ToString();
            this.txtBelongTime.Text = entity.BelongTime;
            this.txtEnergyType.Text = ((EnergyType)entity.EnergyType).DisplayName();
            this.chkIncluded.Checked = entity.Included;
            this.txtStartTime.Text = entity.StartTime.ToDateString();
            this.txtEndTime.Text = entity.EndTime.ToDateString();
            this.txtCreateUser.Text = entity.CreateBy.Name;
            this.txtCreateTime.Text = entity.CreateBy.Time.ToDateTimeString();
            this.txtEditUser.Text = entity.UpdateBy.Name;
            this.txtEditTime.Text = entity.UpdateBy.Time.ToDateTimeString();
            this.txtRemark.Text = entity.Remark;

            var records = BusinessFactory<MeasureRecordBusiness>.Instance.FindByMeasureId(entity.Id).ToList();
            this.mrGrid.DataSource = records;
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 选择计量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbMeasure_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lbMeasure.SelectedItem == null)
                return;

            this.currentMeasure = this.lbMeasure.SelectedItem as Measure;
            if (this.currentMeasure == null)
                return;

            DisplayInfo(this.currentMeasure);
        }

        /// <summary>
        /// 添加计量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmMeasureAdd));
            LoadMeasures();
        }

        /// <summary>
        /// 编辑计量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.lbMeasure.SelectedItem == null || this.currentMeasure == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmMeasureEdit), new object[] { this.currentMeasure.Id });
            LoadMeasures();
        }

        /// <summary>
        /// 删除计量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.lbMeasure.SelectedItem == null || this.currentMeasure == null)
                return;

            if (MessageUtil.ConfirmYesNo("是否确认删除选中能耗计量") == DialogResult.Yes)
            {
                try
                {
                    var result = BusinessFactory<MeasureBusiness>.Instance.Delete(this.currentMeasure);

                    if (result.success)
                    {
                        LoadMeasures();
                        MessageUtil.ShowInfo("删除成功");
                    }
                    else
                    {
                        MessageUtil.ShowClaim("删除失败: " + result.errorMessage);
                    }
                }
                catch (PoseidonException pe)
                {
                    MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
                }
            }
        }

        /// <summary>
        /// 设置部门
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSet_Click(object sender, EventArgs e)
        {
            if (this.lbMeasure.SelectedItem == null || this.currentMeasure == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmMeasureSetDepartment), new object[] { this.currentMeasure.Id });
            LoadMeasures();
        }

        /// <summary>
        /// 录入能耗数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRecordEdit_Click(object sender, EventArgs e)
        {
            if (this.lbMeasure.SelectedItem == null || this.currentMeasure == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmMeasureRecordEdit), new object[] { this.currentMeasure.Id });
            LoadMeasures();
        }
        #endregion //Event
    }
}
