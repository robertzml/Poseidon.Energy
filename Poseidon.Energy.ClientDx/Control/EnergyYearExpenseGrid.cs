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
    using Poseidon.Energy.ClientDx.Model;
    using Poseidon.Energy.Core.Utility;

    /// <summary>
    /// 能源年度支出表格控件
    /// </summary>
    public partial class EnergyYearExpenseGrid : WinEntityGrid<EnergyExpense>
    {
        #region Field
        /// <summary>
        /// 是否显示单价列
        /// </summary>
        private bool showUnitPrice = true;

        /// <summary>
        /// 是否显示附加数据
        /// </summary>
        private bool showAdditionData = false;
        #endregion //Field

        #region Constructor
        public EnergyYearExpenseGrid()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 设置能源类型
        /// </summary>
        /// <param name="energyType">能源类型</param>
        public void SetEnergyType(EnergyExpenseType energyType)
        {
            switch (energyType)
            {
                case EnergyExpenseType.Electric:
                    this.colUnitPrice.Visible = false;
                    this.colQuantum.Caption = "用电量(度)";
                    break;
                case EnergyExpenseType.Water:
                    this.colQuantum.Caption = "用水量(吨)";
                    this.colUnitPrice.Caption = "单价(元/吨)";
                    break;
            }
        }

        /// <summary>
        /// 显示附加数据列
        /// </summary>
        /// <param name="caption">标题</param>
        public void ShowAddition(string caption)
        {
            this.colAdditionData.Caption = caption;
            this.colAdditionData.Visible = true;
        }
        #endregion //Method

        #region Event
        private void EnergyYearExpenseGrid_Load(object sender, EventArgs e)
        {
            this.colUnitPrice.Visible = this.showUnitPrice;
            this.colAdditionData.Visible = this.showAdditionData;
        }
        #endregion //Event

        #region Property
        /// <summary>
        /// 是否显示单价列
        /// </summary>
        [Description("是否显示单价列"), Category("界面"), Browsable(true)]
        public bool ShowUnitPrice
        {
            get
            {
                return this.showUnitPrice;
            }
            set
            {
                this.showUnitPrice = value;
            }
        }

        /// <summary>
        /// 是否显示附加数据
        /// </summary>
        [Description("是否显示附加数据"), Category("界面"), Browsable(true)]
        public bool ShowAddtionData
        {
            get
            {
                return this.showAdditionData;
            }
            set
            {
                this.showAdditionData = value;
            }
        }
        #endregion //Property
    }
}
