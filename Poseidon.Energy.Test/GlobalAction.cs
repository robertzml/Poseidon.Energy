using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Energy.Test
{
    using Poseidon.Base.System;
    using Poseidon.Core.DL;
    using Poseidon.Core.Utility;
    using Poseidon.Common;

    public static class GlobalAction
    {
        #region Field
        public static LoginUser CurrentUser = null;
        #endregion //Field

        #region Constructor

        #endregion //Constructor

        #region Method
        /// <summary>
        /// 全局初始化
        /// </summary>
        public static void Initialize()
        {
            // 设置连接字符串
            string source = AppConfig.GetAppSetting("ConnectionSource");
            string connection = "";
            if (source == "dbconfig")
            {
                string name = AppConfig.GetAppSetting("DbConnection");
                connection = ConfigUtility.GetConnectionString(name);
                if (string.IsNullOrEmpty(connection))
                    throw new PoseidonException(ErrorCode.DatabaseConnectionNotFound);
            }
            else if (source == "appconfig")
            {
                connection = AppConfig.GetConnectionString();
            }

            Cache.Instance.Add("ConnectionString", connection);
        }

        /// <summary>
        /// 设置登录用户
        /// </summary>
        /// <param name="user">用户信息</param>
        public static LoginUser ConvertToLoginUser(User user)
        {
            LoginUser lu = new LoginUser
            {
                Id = user.Id,
                UserName = user.UserName,
                IsRoot = true,
                Name = user.Name,
                LastLoginTime = user.LastLoginTime,
                CurrentLoginTime = user.CurrentLoginTime,
                Remark = user.Remark,
                Status = user.Status
            };

            return lu;
        }
        #endregion //Method
    }
}
