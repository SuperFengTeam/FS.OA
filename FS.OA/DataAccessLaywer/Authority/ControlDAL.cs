//-----------------------------------------------------------------------
// <copyright file="ControlDal.cs" company="FengSoft">
//     Copyright (C) 2018
//     功能描述：ControlDal
//     创建标识：任锋     ADD     2018-01-22
//     修改标识：
// </copyright>
//-----------------------------------------------------------------------
using FY.MVC.Entity;
using FY.MVC.IDAL;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace FY.MVC.DAL
{
    /// <summary>
    /// 控件设置数据层
    /// </summary>
    public class ControlDal : DalBase, IControlDal
    {
        /// <summary>
        /// 查询控件表
        /// </summary>
        /// <param name="total">行数</param>
        /// <param name="take">显示行数</param>
        /// <param name="skip">第几页</param>
        /// <param name="searchParams">检索条件</param>
        /// <returns>控件信息</returns>
        public IEnumerable<IEntityBase> GetList(ref int total, int take, int skip, Dictionary<string, string> searchParams)
        {
            var db = DbFactory.GetSugarInstance();
            var qable = db.Queryable<M_Control, M_Page, M_System, M_ControlAuthority>(
                (s1, s2, s3, s4) => new object[]
                {
                    JoinType.Inner, s1.PageId == s2.Id,
                    JoinType.Inner, s2.SystemId == s3.Id,
                    JoinType.Left, s1.Id == s4.ControlId
                });

            if (searchParams.ContainsKey("q_PageId"))
            {
                var pageId = searchParams["q_PageId"];
                var guid = new Guid(pageId);
                qable = qable.Where(s1 => s1.PageId == guid);
            }

            if (searchParams.ContainsKey("q_Code"))
            {
                var code = searchParams["q_Code"].ToString();

                qable = qable.Where(s1 => s1.Code == code);
            }

            if (searchParams.ContainsKey("q_Name"))
            {
                var controlName = searchParams["q_Name"].ToString();
                qable = qable.Where(s1 => s1.Name.Contains(controlName.Trim()));
            }

            if (searchParams.ContainsKey("q_Type"))
            {
                var controlType = searchParams["q_Type"].ToString();
                qable = qable.Where(s1 => s1.Type == controlType);
            }

            qable = qable.OrderBy(s1 => s1.Id, OrderByType.Asc);

            total = qable.Count();

            var valuePair = qable.Select((s1, s2, s3, s4) => new ControlsEntity()
            {
                Id = s1.Id,
                Code = s1.Code,
                PageId = s1.PageId,
                Name = s1.Name,
                PageName = s2.Name,
                SystemName = s3.Name,
                Type = s1.Type,
                DelFlg = s1.DelFlg,
                CreateUser = s1.CreateUser,
                CreateTime = s1.CreateTime,
                UpdateUser = s1.UpdateUser,
                UpdateTime = s1.UpdateTime,
                ParentId = s1.ParentId,
                AuthorityId = s4.AuthorityIdList,
                SystemId = s2.SystemId
            }).ToPageListAsync((skip / take) + 1, take, 0);

            valuePair.Wait();

            var restult = valuePair.Result;

            var list = restult.Key;

            total = restult.Value;

            return list;
        }

        /// <summary>
        /// 新增控件
        /// </summary>
        /// <param name="controlEntity">控件</param>
        /// <param name="controlAuthority">控件权限</param>
        /// <returns>结果</returns>
        public bool Insert(M_Control controlEntity, M_ControlAuthority controlAuthority)
        {
            var db = DbFactory.GetSugarInstance();

            var result = db.Ado.UseTran(() =>
            {
                db.Insertable<M_Control>(controlEntity).ExecuteCommandAsync();
                db.Deleteable<M_ControlAuthority>().Where(x => x.ControlId == controlAuthority.ControlId).ExecuteCommandAsync();
                db.Insertable<M_ControlAuthority>(controlAuthority).ExecuteCommandAsync();
            });

            return result.IsSuccess;
        }

        /// <summary>
        /// 更新控件
        /// </summary>
        /// <param name="controlEntity">控件</param>
        /// <param name="controlAuthority">控件权限</param>
        /// <returns>结果</returns>
        public bool Update(M_Control controlEntity, M_ControlAuthority controlAuthority)
        {
            var db = DbFactory.GetSugarInstance();

            var result = db.Ado.UseTran(() =>
            {
                db.Updateable<M_Control>(controlEntity).ExecuteCommandAsync();
                db.Deleteable<M_ControlAuthority>().Where(x => x.ControlId == controlEntity.Id).ExecuteCommandAsync();
                db.Insertable<M_ControlAuthority>(controlAuthority).ExecuteCommandAsync();
            });

            return result.IsSuccess;
        }

        /// <summary>
        /// 删除控件
        /// </summary>
        /// <param name="entitys">控件</param>
        /// <returns>结果</returns>
        public bool Delete(List<ControlsEntity> entitys)
        {
            var db = DbFactory.GetSugarInstance();

            var result = db.Ado.UseTran(() =>
            {
                var idList = entitys.Select(x => x.Id).ToList();
                db.Deleteable<M_Control>().In(idList).ExecuteCommandAsync();
                db.Deleteable<M_ControlAuthority>().Where(x => idList.Contains((Guid)x.ControlId)).ExecuteCommandAsync();
            });
            return result.IsSuccess;
        }


        /// <summary>
        /// 通过CODE获取控件信息
        /// </summary>
        /// <param name="entity">控件类</param>
        /// <returns>控件信息</returns>
        public M_Control GetControlByCode(M_Control entity)
        {
            var db = DbFactory.GetSugarInstance();
            var result = db.Queryable<M_Control>().Where(x => x.Code == entity.Code && x.SystemId == entity.SystemId && x.PageId == entity.PageId && x.Id != entity.Id).SingleAsync();
            result.Wait();
            return result.Result;
        }

        /// <summary>
        /// 根据页面id查出所对应的控件
        /// </summary>
        /// <param name="pageId">页面ID</param>
        /// <returns>控件</returns>
        public IEnumerable<SelectEntity> GetControl(string pageId)
        {
            var db = DbFactory.GetSugarInstance();
            var guid = new Guid(pageId);
            var result = db.Queryable<M_Control, M_Page>(
                    (s1, s2) => new object[]
                    {
                        JoinType.Inner, s1.PageId == s2.Id
                    })
                    .Where(s1 =>
                                s1.PageId == guid &&
                                s1.DelFlg == true)
                    .Select((s1, s2) =>
                                new SelectEntity()
                                {
                                    text = s1.Name,
                                    id = s1.Id
                                }).ToListAsync();
            result.Wait();
            return result.Result;
        }

        /// <summary>
        /// 通过页面id列表获取对应所有页面下的控件信息
        /// </summary>
        /// <param name="pageIdList">页面ID列表</param>
        /// <returns>控件</returns>
        public List<M_Control> GetControlByList(List<string> pageIdList)
        {
            var db = DbFactory.GetSugarInstance();

            var result = db.Queryable<M_Control>().Where(
                x => pageIdList.Contains(x.PageId.ToString()) &&
                x.DelFlg != false).ToListAsync();

            result.Wait();
            return result.Result;
        }

        /// <summary>
        /// 获取控件权限
        /// </summary>
        /// <param name="acc">帐套ID</param>
        /// <param name="user">用户名</param>
        /// <param name="system">系统ID</param>
        /// <param name="page">页面ID</param>
        /// <returns>控件信息s</returns>
        public IEnumerable<SelectListItem> GetControlsAuthority(string acc, string user, string system, string page)
        {
            var db = DbFactory.GetSugarInstance();
            var accId = new Guid(acc);
            var qable = db.Queryable<M_Control, M_Page, M_System, M_ControlAuthority>((s1, s2, s3, s4) => new object[]
            {
                JoinType.Inner, s1.PageId == s2.Id && s2.DelFlg != false,
                JoinType.Inner, s2.SystemId == s3.Id && s3.DelFlg != false,
                JoinType.Left, s1.Id == s4.ControlId && s4.DelFlg != false
            });

            qable = qable.Where((s1, s2, s3, s4) =>
                                s1.DelFlg != false &&
                                s2.Code == page && 
                                s3.Code == system && 
                                s2.AccId == accId);

            var list = qable.Select((s1, s2, s3, s4) => new SelectListItem()
            {
                Value = s1.Code,
                Text = s4.AuthorityIdList
            }).ToListAsync();

            list.Wait();
            return list.Result;
        }
    }
}
