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
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 部门表格控件
    /// </summary>
    public partial class DepartmentGrid : WinEntityGrid<Department>
    {
        #region Constructor
        public DepartmentGrid()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Event
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

            var list = this.bsEntity.DataSource as List<Department>;
            if (e.Column.FieldName == "ParentId")
            {
                var department = this.bsEntity[rowIndex] as Department;
                if (department.ParentId != null)
                {
                    var parent = list.Find(r => r.Id == department.ParentId);
                    e.DisplayText = parent.Name;
                }
            }
        }
        #endregion //Event
    }
}
