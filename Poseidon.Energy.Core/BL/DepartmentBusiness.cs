using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Energy.Core.BL
{
    using Poseidon.Base.Framework;
    using Poseidon.Core.BL;
    using Poseidon.Core.DL;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.IDAL;

    /// <summary>
    /// 部门业务类
    /// </summary>
    public class DepartmentBusiness : AbstractBusiness<Department>
    {
        #region Constructor
        /// <summary>
        /// 部门业务类
        /// </summary>
        public DepartmentBusiness()
        {
            this.baseDal = RepositoryFactory<IDepartmentRepository>.Instance;
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 根据指定分组代码查找包含部门
        /// </summary>
        /// <param name="groupCode">分组代码</param>
        /// <param name="include">是否包含子分组</param>
        /// <returns></returns>
        public IEnumerable<Department> FindInGroup(string groupCode, bool include)
        {
            var dal = this.baseDal as IDepartmentRepository;
            List<Department> data = new List<Department>();

            var group = BusinessFactory<GroupBusiness>.Instance.FindByCode(groupCode);
            if (group == null)
                return data;

            List<GroupItem> groupItems = new List<GroupItem>();
            if (include)
                groupItems.AddRange(BusinessFactory<GroupBusiness>.Instance.FindAllItems(group.Id));
            else
                groupItems.AddRange(group.Items);

            var departments = dal.FindWithIds(groupItems.Select(r => r.OrganizationId).ToList());

            foreach (var item in groupItems.OrderBy(r => r.Sort))
            {
                data.Add(departments.Single(r => r.Id == item.OrganizationId));
            }

            return data;
        }
        #endregion //Method
    }
}
