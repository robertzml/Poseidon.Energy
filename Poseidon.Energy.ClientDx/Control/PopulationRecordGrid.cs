﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Poseidon.Energy.ClientDx
{
    using Poseidon.Base.Framework;
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 人数记录表格控件
    /// </summary>
    public partial class PopulationRecordGrid : WinEntityGrid<PopulationRecord>
    {
        #region Field
        /// <summary>
        /// 关联部门数据
        /// </summary>
        private List<Department> departments;
        #endregion //Field

        #region Constructor
        public PopulationRecordGrid()
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
        private void PopulationRecordGrid_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
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
                e.DisplayText = department.Name;
            }
        }
        #endregion //Event
    }
}