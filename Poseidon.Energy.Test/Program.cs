using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Energy.Test
{
    using Poseidon.Base.Framework;
    using Poseidon.Common;
    using Poseidon.Core.BL;

    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            GlobalAction.Initialize();

            var user = BusinessFactory<UserBusiness>.Instance.FindByUserName("admin");
            GlobalAction.CurrentUser = GlobalAction.ConvertToLoginUser(user);
            Cache.Instance.Add("CurrentUser", GlobalAction.CurrentUser); //缓存用户信息

            Application.Run(new MainForm());
        }
    }
}
