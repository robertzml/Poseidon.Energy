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
    /// 人数记录详情查看
    /// </summary>
    public partial class FrmPopulationRecordView : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前关联记录
        /// </summary>
        private PopulationRecord currentRecord;
        #endregion //Field

        #region Constructor
        public FrmPopulationRecordView(string id)
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
            this.popDetailsGrid.DataSource = this.currentRecord.Details;

            base.InitForm();
        }
        #endregion //Function

        #region Event
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion //Event
    }
}
