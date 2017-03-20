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
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 指标记录表格控件
    /// </summary>
    public partial class TargetRecordGrid : WinEntityGrid<TargetRecord>
    {
        #region Field
        /// <summary>
        /// 关联部门数据
        /// </summary>
        private List<Department> departments;
        #endregion //Field

        #region Constructor
        public TargetRecordGrid()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        #endregion //Function

        #region Method
        public void SelectRow(TargetRecord entity)
        {
            var ds = this.bsEntity.DataSource as List<TargetRecord>;
            var index = ds.FindIndex(r => r.Id == entity.Id);
            var rowIndex = this.dgvEntity.GetRowHandle(index);
            this.dgvEntity.SelectRow(rowIndex);
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 控件载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TargetRecordGrid_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                this.departments = BusinessFactory<DepartmentBusiness>.Instance.FindAll().ToList();
                ControlUtil.BindDictToComboBox(this.repoCmbType, typeof(TargetRecord), "Type");
            }
        }

        /// <summary>
        /// 格式化数据显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvEntity_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            int rowIndex = e.ListSourceRowIndex;
            if (rowIndex < 0 || rowIndex >= this.bsEntity.Count)
                return;

            if (e.Column.FieldName == "DepartmentId")
            {
                var department = this.departments.Find(r => r.Id == e.Value.ToString());
                e.DisplayText = department.Name;
            }
        }
        #endregion //Event
    }
}
