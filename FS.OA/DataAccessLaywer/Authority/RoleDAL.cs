//-----------------------------------------------------------------------
// <copyright file="RoleDAL.cs" company="FengSoft">
//     Copyright (C) 2018
//     功能描述：RoleDAL
//     创建标识：任锋     ADD     2018-01-22
//     修改标识：
// </copyright>
//-----------------------------------------------------------------------
using FY.MVC.Common;
using FY.MVC.Entity;
using FY.MVC.IDAL;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FY.MVC.DAL
{
    /// <summary>
    /// 角色设置数据层
    /// </summary>
    public class RoleDal : DalBase, IRoleDal
    {
        /// <summary>
        /// 查询角色
        /// </summary>
        /// <param name="total">行数</param>
        /// <param name="take">显示行数</param>
        /// <param name="skip">第几页</param>
        /// <param name="searchParams">检索条件</param>
        /// <returns>角色信息</returns>
        public IEnumerable<IEntityBase> GetList(ref int total, int take, int skip, Dictionary<string, string> searchParams)
        {
            using (var db = DbFactory.GetSugarInstance())
            {
                var qable = db.Queryable<M_Role>();

                if (searchParams.ContainsKey("q_Name"))
                {
                    var name = searchParams["q_Name"];
                    qable = qable.Where(x => x.Name == name);
                }

                var userId = FY.MVC.Common.AppContext.Current.UserID;

                qable = qable.Where(x => x.CreateUser == userId);

                qable = qable.Where(x => x.DelFlg != false);

                qable = qable.OrderBy(x => x.UpdateTime, OrderByType.Desc);

                var valuePair = qable.ToPageListAsync((skip / take) + 1, take, 0);

                valuePair.Wait();

                var restult = valuePair.Result;

                var list = restult.Key;

                total = restult.Value;

                return list;
            }
        }

        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="entitys">角色类</param>
        /// <returns>处理条数</returns>
        public bool Delete(List<M_Role> entitys)
        {
            var db = DbFactory.GetSugarInstance();

            var idList = (from item in entitys select item.Id).ToList();

            var result = db.Ado.UseTran(() =>
            {
                if (XmlHelper.GetDeleteFlg())
                {
                    db.Deleteable<M_Role>(entitys).ExecuteCommandAsync();

                    db.Deleteable<M_PageAuthority>(x => idList.Contains((Guid)x.RoleId)).ExecuteCommandAsync();
                }
                else
                {
                    db.Updateable<M_Role>(entitys).ExecuteCommandAsync();
                    db.Updateable<M_PageAuthority>().UpdateColumns(
                        it => new M_PageAuthority()
                        {
                            DelFlg = false,
                            UpdateTime = entitys.First().UpdateTime
                        })
                        .Where(
                        x => idList.Contains((Guid)x.RoleId)).ExecuteCommandAsync();
                }
            });

            return result.IsSuccess;
        }

        /// <summary>
        /// 查询所有角色
        /// </summary>
        /// <returns>角色</returns>
        public List<M_Role> GetRole()
        {
            var db = DbFactory.GetSugarInstance();
            var result = db.Queryable<M_Role>().ToListAsync();
            result.Wait();
            return result.Result;
        }

        /// <summary>
        /// 根据人员id得到对应的所有角色
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <returns>角色</returns>
        public List<M_UserRole> GetUserRole(string userId)
        {
            var db = DbFactory.GetSugarInstance();
            var result = db.Queryable<M_UserRole>().Where(x => x.UserId == userId).ToListAsync();
            result.Wait();
            return result.Result;
        }
    }
}
