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
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 部门指标计划组件
    /// </summary>
    public partial class DepartmentTargetModule : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联部门
        /// </summary>
        private Department currentDepartment;
        #endregion //Field

        #region Constructor
        public DepartmentTargetModule()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 载入相关指标计划
        /// </summary>
        private void LoadTargets()
        {
            List<Target> data = new List<Target>();
            var targets = BusinessFactory<TargetBusiness>.Instance.FindAll().OrderByDescending(r => r.Year);

            foreach (var item in targets)
            {
                var records = BusinessFactory<TargetRecordBusiness>.Instance.FindByDepartment(item.Id, this.currentDepartment.Id);
                if (records.Count() > 0)
                    data.Add(item);
            }

            this.bsTarget.DataSource = data;
        }

        /// <summary>
        /// 显示指标信息
        /// </summary>
        /// <param name="target">相关计划指标</param>
        private void DisplayInfo(Target target)
        {
            var records = BusinessFactory<TargetRecordBusiness>.Instance.FindByDepartment(target.Id, this.currentDepartment.Id);

            foreach (var item in records)
            {
                if (item.Type == 1)
                {
                    this.recordElectric.SetTargetRecord(item.Id);
                    this.tabPageElectric.PageVisible = true;
                }
                else if (item.Type == 2)
                {
                    this.recordWater.SetTargetRecord(item.Id);
                    this.tabPageWater.PageVisible = true;
                }
            }

            //避免界面闪烁
            if (records.All(r => r.Type != 1))
                this.tabPageElectric.PageVisible = false;
            if (records.All(r => r.Type != 2))
                this.tabPageWater.PageVisible = false;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 设置关联部门
        /// </summary>
        /// <param name="id">部门ID</param>
        public void SetDepartment(string id)
        {
            this.currentDepartment = BusinessFactory<DepartmentBusiness>.Instance.FindById(id);
            LoadTargets();
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 选择指标计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbTargets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lbTargets.SelectedItem == null)
            {
                this.recordElectric.Clear();
                this.tabPageElectric.PageVisible = false;

                this.recordWater.Clear();
                this.tabPageWater.PageVisible = false;
                return;
            }

            var target = this.lbTargets.SelectedItem as Target;
            DisplayInfo(target);
        }
        #endregion //Event
    }
}
