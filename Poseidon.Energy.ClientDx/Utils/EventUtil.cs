using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Energy.ClientDx
{
    using DevExpress.XtraEditors;

    /// <summary>
    /// 通用事件处理类
    /// </summary>
    public static class EventUtil
    {
        /// <summary>
        /// 列表控件显示月份
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void lbMonth_DrawItem(object sender, DevExpress.XtraEditors.ListBoxDrawItemEventArgs e)
        {
            var lb = sender as ListBoxControl;
            var date = Convert.ToDateTime(lb.GetItemText(e.Index));

            string s = date.ToString("yyyy年MM月");
            e.Appearance.DrawBackground(e.Cache, e.Bounds);
            e.Graphics.DrawString(s, e.Appearance.Font, e.Cache.GetSolidBrush(e.Appearance.ForeColor), e.Bounds.Location);
            e.Handled = true;
        }
    }
}
