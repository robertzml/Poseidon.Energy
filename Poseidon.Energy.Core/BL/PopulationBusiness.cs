using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Energy.Core.BL
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.IDAL;
    using Poseidon.Energy.Core.Utility;

    /// <summary>
    /// 人数统计业务类
    /// </summary>
    public class PopulationBusiness : AbstractBusiness<Population>
    {
        #region Constructor
        /// <summary>
        /// 人数统计业务类
        /// </summary>
        public PopulationBusiness()
        {
            this.baseDal = RepositoryFactory<IPopulationRepository>.Instance;
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取教师人数
        /// </summary>
        /// <param name="id">人数统计ID</param>
        /// <returns></returns>
        public int GetTeacherNumber(string id)
        {
            Poseidon.Core.BL.DictBusiness dictBusiness = new Poseidon.Core.BL.DictBusiness();
            var dictItems = dictBusiness.FindItems(EnergyConstant.TeacherDictCode);

            PopulationRecordBusiness recordBusiness = new PopulationRecordBusiness();
            int number = recordBusiness.GetDetailsNumber(id, dictItems.Select(r => r.Value).ToList(), true);
            return number;
        }

        /// <summary>
        /// 获取学生人数
        /// </summary>
        /// <param name="id">人数统计ID</param>
        /// <returns></returns>
        public int GetStudentNumber(string id)
        {
            Poseidon.Core.BL.DictBusiness dictBusiness = new Poseidon.Core.BL.DictBusiness();
            var dictItems = dictBusiness.FindItems(EnergyConstant.StudentDictCode);

            PopulationRecordBusiness recordBusiness = new PopulationRecordBusiness();
            int number = recordBusiness.GetDetailsNumber(id, dictItems.Select(r => r.Value).ToList(), true);
            return number;
        }

        /// <summary>
        /// 添加人数统计
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        public void Create(Population entity, LoginUser user)
        {
            entity.CreateBy = new UpdateStamp
            {
                UserId = user.Id,
                Name = user.Name,
                Time = DateTime.Now
            };
            entity.UpdateBy = new UpdateStamp
            {
                UserId = user.Id,
                Name = user.Name,
                Time = DateTime.Now
            };
            base.Create(entity);
        }

        /// <summary>
        /// 编辑人数统计
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        /// <returns></returns>
        public bool Update(Population entity, LoginUser user)
        {
            entity.UpdateBy = new UpdateStamp
            {
                UserId = user.Id,
                Name = user.Name,
                Time = DateTime.Now
            };
            return base.Update(entity);
        }

        /// <summary>
        /// 删除人数统计
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        public override bool Delete(Population entity)
        {
            // delete the records
            PopulationRecordBusiness recordBusiness = new PopulationRecordBusiness();
            recordBusiness.DeleteByPopulation(entity.Id);

            return base.Delete(entity);
        }
        #endregion //Method
    }
}
