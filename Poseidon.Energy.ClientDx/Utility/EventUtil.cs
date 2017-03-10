using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Energy.ClientDx
{
    using DevExpress.Utils.Win;
    using DevExpress.XtraEditors;
    using DevExpress.XtraEditors.Popup;

    /// <summary>
    /// 通用事件处理类
    /// </summary>
    public static class EventUtil
    {
        #region Method
        /// <summary>
        /// 列表控件显示月份
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void lbMonth_DrawItem(object sender, DevExpress.XtraEditors.ListBoxDrawItemEventArgs e)
        {
            var lb = sender as ListBoxControl;

            DateTime date;
            if (!DateTime.TryParse(lb.GetItemText(e.Index), out date))
                return;

            string s = date.ToString("yyyy年MM月");
            e.Appearance.DrawBackground(e.Cache, e.Bounds);
            e.Graphics.DrawString(s, e.Appearance.Font, e.Cache.GetSolidBrush(e.Appearance.ForeColor), e.Bounds.Location);
            e.Handled = true;
        }

        /// <summary>
        /// Lookup弹出事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void Lookup_Popup(object sender, EventArgs e)
        {
            LookUpEdit edit = sender as LookUpEdit;
            PopupLookUpEditForm f = (edit as IPopupControl).PopupWindow as PopupLookUpEditForm;
            f.Width = edit.Width;
        }

        /// <summary>
        /// TreeListLookup弹出事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void TreeListLookup_Popup(object sender, EventArgs e)
        {
            TreeListLookUpEdit edit = sender as TreeListLookUpEdit;
            TreeListLookUpEditPopupForm f = (edit as IPopupControl).PopupWindow as TreeListLookUpEditPopupForm;
            f.Width = edit.Width;
        }
        #endregion //Method
    }
}
