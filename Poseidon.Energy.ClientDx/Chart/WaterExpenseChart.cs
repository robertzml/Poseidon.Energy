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
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 水费支出图表控件
    /// </summary>
    public partial class WaterExpenseChart : DevExpress.XtraEditors.XtraUserControl
    {
        #region Constructor
        public WaterExpenseChart()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 设置数据源
        /// </summary>
        /// <param name="data"></param>
        public void SetDataSource(List<WaterExpense> data)
        {
            List<WaterExpense> format = new List<WaterExpense>();

            if (data.Count == 0)
                return;

            format.AddRange(data);
            var last = data.Max(r => r.BelongDate);
            for (int i = last.Month + 1; i <= 12; i++)
            {
                format.Add(new WaterExpense
                {
                    BelongDate = new DateTime(last.Year, i, 1),
                    TotalAmount = 0,
                    TotalQuantity = 0
                });
            }

            this.bsWaterExpense.DataSource = format.OrderBy(r => r.BelongDate).ToList();
        }
        #endregion //Method

        #region Property
        /// <summary>
        /// 数据源
        /// </summary>
        [Description("数据源")]
        public List<WaterExpense> DataSource
        {
            get
            {
                return this.bsWaterExpense.DataSource as List<WaterExpense>;
            }
        }
        #endregion //Property
    }
}
