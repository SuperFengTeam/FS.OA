//-----------------------------------------------------------------------
// <copyright file="ApprovalAuthorityDal.cs" company="FengSoft">
//     Copyright (C) 2018
//     功能描述：ApprovalAuthorityDal
//     创建标识：葛枫     ADD     2018-01-29
//     修改标识：
// </copyright>
//-----------------------------------------------------------------------
using FY.MVC.Common;
using FY.MVC.Entity;
using FY.MVC.IDAL;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FY.MVC.DAL
{
    public class ApprovalAuthorityDal : DalBase,IApprovalAuthorityDal
    {
        /// <summary>
        /// 审批权限
        /// </summary>
        /// <param name="total">行数</param>
        /// <param name="take">显示行数</param>
        /// <param name="skip">第几页</param>
        /// <param name="searchParams">检索条件</param>
        /// <returns>审批权限信息</returns>
        public IEnumerable<IEntityBase> GetList(ref int total, int take, int skip, Dictionary<string, string> searchParams) {
            var db = DbFactory.GetSugarInstance();

            //var qable = db.Queryable<M_ApprovalAuthority, M_ApprovalType, M_Organization, M_TaskType>((s1, s2, s3, s4) => new object[] {
            //    JoinType.Left,s1.ApprovalType == s2.Id,
            //    JoinType.Left,s1.OrganizationId==s3.Id,
            //    JoinType.Left,s1.TaskType==s4.Id

            //});

            //var list = qable.Select((s1, s2, s3, s4) => new ApprovalAuthority()
            //{
            //    Id = s1.Id,
            //    ApprovalType = s1.ApprovalType,
            //    UserId = s1.UserId,
            //    OrganizationId = s1.OrganizationId,
            //    TaskType = s1.TaskType,
            //    DelFlg = s1.DelFlg,
            //    CreateUser = s1.CreateUser,
            //    CreateTime = s1.CreateTime,
            //    UpdateUser = s1.UpdateUser,
            //    UpdateTime = s1.UpdateTime,
            //    IsAct = s1.IsAct,
            //    StartDate = s1.StartDate,
            //    EndDate = s1.EndDate,
            //    ApprovalTypeName = s2.ApprovalTypeName,
            //    UserName = s3.UserName,
            //    OrganizationName = s4.Name,
            //    TaskTypeName = TaskTypeName
            //}).Take(take).Skip(skip).ToListAsync();

            var qable = db.Queryable<M_ApprovalAuthority>();

            if (searchParams.ContainsKey("q_approvalType"))
            {
                var approvalType = new Guid(searchParams["q_approvalType"]);
                qable = qable.Where(x => x.ApprovalType == approvalType);
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
        /// 通过审批权限Name获取审批权限信息
        /// </summary>
        /// <param name="entity">审批权限</param>
        /// <returns>审批权限信息</returns>
        public M_ApprovalAuthority GetApprovalAuthorityByName(M_ApprovalAuthority entity)
        {
            var db = DbFactory.GetSugarInstance();

            var result = db.Queryable<M_ApprovalAuthority>().Where(x => x.ApprovalType == entity.ApprovalType).SingleAsync();
            result.Wait();
            return result.Result;
        }

        public IEnumerable<SelectEntity> GetAll(string id, int level)
        {
            using (var db = DbFactory.GetSugarInstance())
            {
                var qable = db.Queryable<M_ApprovalType>();

                if (!string.IsNullOrEmpty(id))
                {
                    var guid = new Guid(id);
                    qable.Where(x => x.Id == guid);
                }

                qable = qable.Where(x => x.DelFlg != false);
                qable = qable.OrderBy(x => x.Id, OrderByType.Asc);
                var list = qable.Select<SelectEntity>(x => new SelectEntity() { text = x.Name, id = x.Id.ToString() }).ToListAsync();

                list.Wait();
                return list.Result;
            }
        }
    }
}
