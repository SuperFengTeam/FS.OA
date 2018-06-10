//-----------------------------------------------------------------------
// <copyright file="SystemDAL.cs" company="FengSoft">
//     Copyright (C) 2018
//     功能描述：SystemDAL
//     创建标识：任锋     ADD     2018-01-22
//     修改标识：
// </copyright>
//-----------------------------------------------------------------------
using FY.MVC.Entity;
using FY.MVC.IDAL;
using SqlSugar;
using System.Collections.Generic;

namespace FY.MVC.DAL
{
    /// <summary>
    /// 系统数据层
    /// </summary>
    public class SystemDal : DalBase, ISystemDal
    {
        /// <summary>
        /// 查询系统
        /// </summary>
        /// <param name="total">行数</param>
        /// <param name="take">显示行数</param>
        /// <param name="skip">第几页</param>
        /// <param name="searchParams">检索条件</param>
        /// <returns>系统信息</returns>
        public IEnumerable<IEntityBase> GetList(ref int total, int take, int skip, Dictionary<string, string> searchParams)
        {
            var db = DbFactory.GetSugarInstance();

            var qable = db.Queryable<M_System>();

            if (searchParams.ContainsKey("q_Code"))
            {
                var systemCode = searchParams["q_Code"];
                qable = qable.Where(x => x.Code == systemCode);
            }

            if (searchParams.ContainsKey("q_Name"))
            {
                var systemName = searchParams["q_Name"];
                qable = qable.Where(x => x.Name == systemName);
            }

            qable = qable.Where(x => x.DelFlg != false);

            qable = qable.OrderBy(x => x.UpdateTime, OrderByType.Desc);

            var valuePair = qable.ToPageListAsync((skip / take) + 1, take, 0);

            valuePair.Wait();

            var restult = valuePair.Result;

            var list = restult.Key;

            total = restult.Value;

            return list;
        }

        /// <summary>
        /// 获取系统下拉框
        /// </summary>
        /// <returns>系统下拉框数据</returns>
        public IEnumerable<SelectEntity> GetAll()
        {
            using (var db = DbFactory.GetSugarInstance())
            {
                var qable = db.Queryable<M_System>();
                qable = qable.Where(x => x.DelFlg != false);
                qable = qable.OrderBy(x => x.Id, OrderByType.Asc);
                var list = qable.Select<SelectEntity>(x => new SelectEntity() { text = x.Name, id = x.Id.ToString() }).ToListAsync();

                list.Wait();
                return list.Result;
            }
        }


        /// <summary>
        /// 通过系统Code获取系统信息
        /// </summary>
        /// <param name="entity">系统</param>
        /// <returns>系统信息</returns>
        public M_System GetSystemByCode(M_System entity)
        {
            var db = DbFactory.GetSugarInstance();

            var result = db.Queryable<M_System>().Where(x => x.Code == entity.Code && x.Id != entity.Id).SingleAsync();

            result.Wait();
            return result.Result;
        }
    }
}
