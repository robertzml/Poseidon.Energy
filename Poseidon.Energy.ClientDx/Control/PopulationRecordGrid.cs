using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Poseidon.Energy.ClientDx
{
    using DevExpress.XtraGrid.Columns;
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
                e.DisplayText = department.ShortName;
            }
        }

        /// <summary>
        /// 自定义数据显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvEntity_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            int rowIndex = e.ListSourceRowIndex;
            if (rowIndex < 0 || rowIndex >= this.bsEntity.Count)
                return;

            var record = this.bsEntity[rowIndex] as PopulationRecord;

            switch (e.Column.FieldName)
            {
                case "colEstablishment":
                    {
                        var detail = record.Details.Find(r => r.Code == "Establishment");
                        if (detail == null)
                        {
                            detail = new PopulationDetail
                            {
                                Name = "在职在编",
                                Code = "Establishment",
                                Number = 0,
                                InTotal = true
                            };
                            record.Details.Add(detail);
                        }

                        if (e.IsGetData)
                            e.Value = detail.Number;
                        if (e.IsSetData)
                            detail.Number = Convert.ToInt32(e.Value);
                    }
                    break;
                case "colPersonnelAgency":
                    {
                        var detail = record.Details.Find(r => r.Code == "PersonnelAgency");
                        if (detail == null)
                        {
                            detail = new PopulationDetail
                            {
                                Name = "人事代理",
                                Code = "PersonnelAgency",
                                Number = 0,
                                InTotal = true
                            };
                            record.Details.Add(detail);
                        }

                        if (e.IsGetData)
                            e.Value = detail.Number;
                        if (e.IsSetData)
                            detail.Number = Convert.ToInt32(e.Value);
                    }
                    break;
                case "colUndergraduate":
                    {
                        var detail = record.Details.Find(r => r.Code == "Undergraduate");
                        if (detail == null)
                        {
                            detail = new PopulationDetail
                            {
                                Name = "本科生",
                                Code = "Undergraduate",
                                Number = 0,
                                InTotal = true
                            };
                            record.Details.Add(detail);
                        }

                        if (e.IsGetData)
                            e.Value = detail.Number;
                        if (e.IsSetData)
                            detail.Number = Convert.ToInt32(e.Value);
                    }
                    break;
                case "colMaster":
                    {
                        var detail = record.Details.Find(r => r.Code == "Master");
                        if (detail == null)
                        {
                            detail = new PopulationDetail
                            {
                                Name = "硕士生",
                                Code = "Master",
                                Number = 0,
                                InTotal = true
                            };
                            record.Details.Add(detail);
                        }

                        if (e.IsGetData)
                            e.Value = detail.Number;
                        if (e.IsSetData)
                            detail.Number = Convert.ToInt32(e.Value);
                    }
                    break;
                case "colProfessionalMaster":
                    {
                        var detail = record.Details.Find(r => r.Code == "ProfessionalMaster");
                        if (detail == null)
                        {
                            detail = new PopulationDetail
                            {
                                Name = "专业硕士生",
                                Code = "ProfessionalMaster",
                                Number = 0,
                                InTotal = true
                            };
                            record.Details.Add(detail);
                        }

                        if (e.IsGetData)
                            e.Value = detail.Number;
                        if (e.IsSetData)
                            detail.Number = Convert.ToInt32(e.Value);
                    }
                    break;
                case "colDoctor":
                    {
                        var detail = record.Details.Find(r => r.Code == "Doctor");
                        if (detail == null)
                        {
                            detail = new PopulationDetail
                            {
                                Name = "博士生",
                                Code = "Doctor",
                                Number = 0,
                                InTotal = true
                            };
                            record.Details.Add(detail);
                        }

                        if (e.IsGetData)
                            e.Value = detail.Number;
                        if (e.IsSetData)
                            detail.Number = Convert.ToInt32(e.Value);
                    }
                    break;
                case "colAbroadStudent":
                    {
                        var detail = record.Details.Find(r => r.Code == "AbroadStudent");
                        if (detail == null)
                        {
                            detail = new PopulationDetail
                            {
                                Name = "留学生",
                                Code = "AbroadStudent",
                                Number = 0,
                                InTotal = true
                            };
                            record.Details.Add(detail);
                        }

                        if (e.IsGetData)
                            e.Value = detail.Number;
                        if (e.IsSetData)
                            detail.Number = Convert.ToInt32(e.Value);
                    }
                    break;
            }
        }
        #endregion //Event
    }
}
