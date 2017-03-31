using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Energy.ClientDx
{
    using DevExpress.Data;
    using DevExpress.XtraGrid;
    using Poseidon.Base.Framework;
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 能源结算记录表格控件
    /// </summary>
    public partial class SettlementRecordGrid : WinEntityGrid<SettlementRecord>
    {
        #region Field
        /// <summary>
        /// 缓存部门数据
        /// </summary>
        private List<Department> departments;
        #endregion //Field

        #region Constructor
        public SettlementRecordGrid()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Event
        /// <summary>
        /// 控件载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SettlementRecordGrid_Load(object sender, EventArgs e)
        {
            if (!ControlUtil.IsInDesignMode())
                this.departments = BusinessFactory<DepartmentBusiness>.Instance.FindAll().ToList();
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
                e.DisplayText = department.ShortName;
            }
        }
        #endregion //Event

    }
}
