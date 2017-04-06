using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Energy.ClientDx
{
    using DevExpress.XtraEditors;
    using DevExpress.XtraEditors.Controls;
    using DevExpress.XtraEditors.Repository;
    using Poseidon.Core.DL;
    using Poseidon.Core.Utility;

    /// <summary>
    /// 通用控件处理类
    /// </summary>
    public static class ControlUtil
    {
        #region Method
        /// <summary>
        /// 检查控件是否在设计模式
        /// </summary>
        /// <returns></returns>
        public static bool IsInDesignMode()
        {
            if (Application.ExecutablePath.IndexOf("devenv.exe", StringComparison.OrdinalIgnoreCase) > -1)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 绑定字典到ComboBox
        /// </summary>
        /// <param name="cmb">控件</param>
        /// <param name="classType">类型</param>
        /// <param name="field">属性名称</param>
        /// <param name="value">默认值</param>
        public static void BindDictToComboBox(ImageComboBoxEdit cmb, Type classType, string field, int? value = null)
        {
            var items = DictUtility.GetDictItem(classType, field);

            foreach (var item in items)
            {
                cmb.Properties.Items.Add(new ImageComboBoxItem
                {
                    Description = item.Value,
                    Value = item.Key
                });
            }

            if (value != null)
                cmb.EditValue = value.Value;
        }

        /// <summary>
        /// 绑定字典到ComboBox
        /// </summary>
        /// <param name="cmb">控件</param>
        /// <param name="classType">类型</param>
        /// <param name="field">属性名称</param>
        public static void BindDictToComboBox(RepositoryItemImageComboBox cmb, Type classType, string field)
        {
            var items = DictUtility.GetDictItem(classType, field);

            foreach (var item in items)
            {
                cmb.Items.Add(new ImageComboBoxItem
                {
                    Description = item.Value,
                    Value = item.Key
                });
            }
        }
        #endregion //Method
    }
}
