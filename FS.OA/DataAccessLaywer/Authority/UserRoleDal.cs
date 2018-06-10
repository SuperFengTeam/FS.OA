using FY.MVC.Entity;
using FY.MVC.IDAL;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FY.MVC.DAL
{
    public class UserRoleDal : DalBase, IUserRoleDal
    {
        public IEnumerable<IEntityBase> GetList(ref int total, int take, int skip, Dictionary<string, string> searchParams)
        {
            return null;
        }

        /// <summary>
        /// 查询所有角色
        /// </summary>
        /// <returns>角色</returns>
        public List<M_Role> GetRole(string userId)
        {
            var db = DbFactory.GetSugarInstance();

            var result = db.Queryable<M_Role, M_UserRole>((s1, s2) => new object[] {
                    JoinType.Inner, s1.Id==s2.RoleId
                })
                .Where((s1, s2) => s2.UserId == userId).ToListAsync();

            result.Wait();

            return result.Result;
        }
    }
}
