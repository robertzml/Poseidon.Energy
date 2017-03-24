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
    using Poseidon.Core.BL;
    using Poseidon.Core.DL;
    using Poseidon.Core.Utility;
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.Utility;

    /// <summary>
    /// 能耗数据录入窗体
    /// </summary>
    public partial class FrmMeasureRecordEdit : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前关联能耗计量
        /// </summary>
        private Measure currentMeasure;
        #endregion //Field

        #region Constructor
        public FrmMeasureRecordEdit(string id)
        {
            InitializeComponent();
            InitData(id);
        }
        #endregion //Constructor

        #region Function
        private void InitData(string id)
        {
            this.currentMeasure = BusinessFactory<MeasureBusiness>.Instance.FindById(id);
        }

        protected override void InitForm()
        {
            var groups = BusinessFactory<GroupBusiness>.Instance.FindWithChildrenByCode(EnergyConstant.MeasureDepartmentGroupCode).ToList();
            this.measureGroup.DataSource = groups;
            base.InitForm();
        }

        private void LoadDepartments(Group group)
        {
            var departments = BusinessFactory<DepartmentBusiness>.Instance.FindInGroup(group.Code, true);
            var records = BusinessFactory<MeasureRecordBusiness>.Instance.FindByMeasureId(this.currentMeasure.Id);

            List<MeasureRecord> data = new List<MeasureRecord>();

            foreach(var item in departments)
            {
                var record = records.SingleOrDefault(r => r.DepartmentId == item.Id);
                if (record != null)
                    data.Add(record);
                else
                {
                    MeasureRecord mr = new MeasureRecord
                    {
                        MeasureId = this.currentMeasure.Id,
                        DepartmentId = item.Id
                    };
                    data.Add(mr);
                }
            }

            this.mrGrid.DataSource = data;
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 分组选择
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        private void measureGroup_GroupSelected(object arg1, EventArgs arg2)
        {
            var group = this.measureGroup.GetCurrentSelect();

            this.txtGroupName.Text = group.Name;

            LoadDepartments(group);
        }
        #endregion //Event
    }
}
