//-----------------------------------------------------------------------
// <copyright file="ApprovalFlowDal.cs" company="FengSoft">
//     Copyright (C) 2018
//     功能描述：ApprovalFlowDal
//     创建标识：任锋     ADD     2018-01-22
//     修改标识：
// </copyright>
//-----------------------------------------------------------------------
using FY.MVC.Entity;
using FY.MVC.IDAL;
using SqlSugar;
using System;
using System.Collections.Generic;

namespace FY.MVC.DAL
{
    /// <summary>
    /// 审批流程数据层
    /// </summary>
    public class ApprovalFlowDal : DalBase, IApprovalFlowDal
    {
        /// <summary>
        /// 查询审批流程
        /// </summary>
        /// <param name="total">行数</param>
        /// <param name="take">显示行数</param>
        /// <param name="skip">第几页</param>
        /// <param name="searchParams">检索条件</param>
        /// <returns>审批流程</returns>
        public IEnumerable<IEntityBase> GetList(ref int total, int take, int skip, Dictionary<string, string> searchParams)
        {
            var db = DbFactory.GetSugarInstance();
            var qable = db.Queryable<M_ApprovalFlow>();

            if (searchParams.ContainsKey("ApprovalId") && searchParams["ApprovalId"]!=string.Empty)
            {
                var approvalId = new Guid(searchParams["ApprovalId"]);

                qable = qable.Where(x => x.ApprovalId == approvalId);
            }

            qable = qable.OrderBy(s1 => s1.Seq, OrderByType.Asc);

            var valuePair = qable.ToPageListAsync((skip / take) + 1, take, 0);

            valuePair.Wait();

            var restult = valuePair.Result;

            var list = restult.Key;

            total = restult.Value;

            return list;
        }
    }
}
