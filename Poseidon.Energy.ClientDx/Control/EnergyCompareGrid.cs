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
    using DevExpress.XtraGrid;
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 能源比较表格控件
    /// </summary>
    public partial class EnergyCompareGrid : WinEntityGrid<EnergyCompare>
    {
        #region Field
        private decimal totalQuantumFirst;

        private decimal totalQuantumSecond;

        private decimal totalAmountFirst;

        private decimal totalAmountSecond;
        #endregion //Field

        #region Constructor
        public EnergyCompareGrid()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 设置标题
        /// </summary>
        /// <param name="index">系列</param>
        /// <param name="quantumTitile">用量标题</param>
        /// <param name="amountTitle">金额标题</param>
        public void SetTitle(int index, string quantumTitile, string amountTitle)
        {
            if (index == 1)
            {
                this.colQuantumFirst.Caption = quantumTitile;
                this.colAmountFirst.Caption = amountTitle;
            }
            else if (index == 2)
            {
                this.colQuantumSecond.Caption = quantumTitile;
                this.colAmountSecond.Caption = amountTitle;
            }
        }

        /// <summary>
        /// 设置归属时间标题，默认月份
        /// </summary>
        /// <param name="title">标题</param>
        public void SetBelongTimeTitle(string title)
        {
            this.colMonth.Caption = title;
        }

        /// <summary>
        /// 显示用量
        /// </summary>
        /// <param name="visible">是否显示</param>
        public void ShowQuantum(bool visible)
        {
            this.colQuantumFirst.Visible = visible;
            this.colQuantumSecond.Visible = visible;
            this.colDiffQuantum.Visible = visible;
            this.colIncQuantum.Visible = visible;
        }

        /// <summary>
        /// 显示金额
        /// </summary>
        /// <param name="visible">是否显示</param>
        public void ShowAmount(bool visible)
        {
            this.colAmountFirst.Visible = visible;
            this.colAmountSecond.Visible = visible;
            this.colDiffAmount.Visible = visible;
            this.colIncAmount.Visible = visible;
        }

        /// <summary>
        /// 选择全部
        /// </summary>
        public void CheckAll()
        {
            this.dgvEntity.SelectAll();
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 自定义汇总
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvEntity_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Start)
            {
                this.totalQuantumFirst = 0;
                this.totalQuantumSecond = 0;
                this.totalAmountFirst = 0;
                this.totalAmountSecond = 0;
            }

            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Calculate)
            {
                bool include = (bool)this.dgvEntity.GetRowCellValue(e.RowHandle, "Include");

                if (include)
                {
                    var item = e.Item as GridSummaryItem;

                    if (item.FieldName == "QuantumFirst")
                        this.totalQuantumFirst += Convert.ToDecimal(e.FieldValue);
                    if (item.FieldName == "QuantumSecond")
                        this.totalQuantumSecond += Convert.ToDecimal(e.FieldValue);
                    if (item.FieldName == "AmountFirst")
                        this.totalAmountFirst += Convert.ToDecimal(e.FieldValue);
                    if (item.FieldName == "AmountSecond")
                        this.totalAmountSecond += Convert.ToDecimal(e.FieldValue);
                }
            }

            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Finalize)
            {
                var item = e.Item as GridSummaryItem;

                if (item.FieldName == "QuantumFirst")
                    e.TotalValue = totalQuantumFirst;
                if (item.FieldName == "QuantumSecond")
                    e.TotalValue = totalQuantumSecond;
                if (item.FieldName == "colDiffQuantum")
                {
                    decimal quanFirst = Convert.ToDecimal(this.colQuantumFirst.SummaryItem.SummaryValue);
                    decimal quanSecond = Convert.ToDecimal(this.colQuantumSecond.SummaryItem.SummaryValue);
                    e.TotalValue = quanSecond - quanFirst;
                }
                if (item.FieldName == "colIncQuantum")
                {
                    decimal quanFirst = Convert.ToDecimal(this.colQuantumFirst.SummaryItem.SummaryValue);
                    decimal quanSecond = Convert.ToDecimal(this.colQuantumSecond.SummaryItem.SummaryValue);

                    if (quanFirst == 0)
                        e.TotalValue = 1;
                    else
                        e.TotalValue = (quanSecond - quanFirst) / quanFirst;
                }

                if (item.FieldName == "AmountFirst")
                    e.TotalValue = this.totalAmountFirst;
                if (item.FieldName == "AmountSecond")
                    e.TotalValue = this.totalAmountSecond;
                if (item.FieldName == "colDiffAmount")
                {
                    decimal amouFirst = Convert.ToDecimal(this.colAmountFirst.SummaryItem.SummaryValue);
                    decimal amouSecond = Convert.ToDecimal(this.colAmountSecond.SummaryItem.SummaryValue);
                    e.TotalValue = amouSecond - amouFirst;
                }
                if (item.FieldName == "colIncAmount")
                {
                    decimal amouFirst = Convert.ToDecimal(this.colAmountFirst.SummaryItem.SummaryValue);
                    decimal amouSecond = Convert.ToDecimal(this.colAmountSecond.SummaryItem.SummaryValue);

                    if (amouFirst == 0)
                        e.TotalValue = 1;
                    else
                        e.TotalValue = (amouSecond - amouFirst) / amouFirst;
                }
            }
        }
        #endregion //Event
    }
}
