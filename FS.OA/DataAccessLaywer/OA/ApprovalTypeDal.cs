//-----------------------------------------------------------------------
// <copyright file="ApprovalTypeDal.cs" company="FengSoft">
//     Copyright (C) 2018
//     功能描述：ApprovalTypeDal
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
    /// 审批类型数据层
    /// </summary>
    public class ApprovalTypeDal : DalBase, IApprovalTypeDal
    {
        /// <summary>
        /// 查询审批类型
        /// </summary>
        /// <param name="total">行数</param>
        /// <param name="take">显示行数</param>
        /// <param name="skip">第几页</param>
        /// <param name="searchParams">检索条件</param>
        /// <returns></returns>
        public IEnumerable<IEntityBase> GetList(ref int total, int take, int skip, Dictionary<string, string> searchParams)
        {
            var db = DbFactory.GetSugarInstance();
            var qable = db.Queryable<M_ApprovalType>();

            if (searchParams.ContainsKey("q_Name"))
            {
                var name = (searchParams["q_Name"]).ToString();
                qable = qable.Where(s1 => s1.Name.Contains(name));
            }

            qable = qable.OrderBy(s1 => s1.Id, OrderByType.Asc);

            var valuePair = qable.ToPageListAsync((skip / take) + 1, take, 0);

            valuePair.Wait();

            var restult = valuePair.Result;

            var list = restult.Key;

            total = restult.Value;

            return list;
        }

        /// <summary>
        /// 审批类型下拉框
        /// </summary>
        /// <returns>审批类型下拉框数据</returns>
        public List<SelectEntity> GetAll()
        {
            var db = DbFactory.GetSugarInstance();
            var now = this.GetDateTime();

            var result = db.Queryable<M_ApprovalType>()
                .Where(x => x.DelFlg != false)
                .Select(x => new SelectEntity() { id = x.Id, text = x.Name }).ToListAsync();

            result.Wait();
            return result.Result;
        }
    }
}
