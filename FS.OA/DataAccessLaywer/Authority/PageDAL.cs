//-----------------------------------------------------------------------
// <copyright file="PageDal.cs" company="FengSoft">
//     Copyright (C) 2018
//     功能描述：PageDal
//     创建标识：任锋     ADD     2018-01-22
//     修改标识：
// </copyright>
//-----------------------------------------------------------------------
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using FY.MVC.DAL;

namespace FS.OA.DataAccessLaywer
{
    /// <summary>
    /// 页面管理数据层
    /// </summary>
    public class PageDal : DalBase, IPageDal
    {
        /// <summary>
        /// 查询页面
        /// </summary>
        /// <param name="total">行数</param>
        /// <param name="take">显示行数</param>
        /// <param name="skip">第几页</param>
        /// <param name="searchParams">检索条件</param>
        /// <returns>页面信息</returns>
        public IEnumerable<IEntityBase> GetList(ref int total, int take, int skip, Dictionary<string, string> searchParams)
        {
            var db = DbFactory.GetSugarInstance();

            var qable = db.Queryable<M_Page, M_System>((s1, s2) => new object[]
                    {
                        JoinType.Inner, s1.SystemId == s2.Id && s2.DelFlg != false
                });

            if (searchParams.ContainsKey("q_Code"))
            {
                var pageCode = searchParams["q_Code"];
                qable = qable.Where((s1, s2) => s1.Code == pageCode);
            }

            if (searchParams.ContainsKey("q_Name"))
            {
                var pageName = searchParams["q_Name"];
                qable = qable.Where((s1, s2) => s1.Name == pageName);
            }

            if (searchParams.ContainsKey("q_AccId"))
            {
                var accId = searchParams["q_AccId"];
                Guid acc = new Guid(accId);
                qable = qable.Where((s1, s2) => s1.AccId == acc);
            }

            if (searchParams.ContainsKey("q_SystemId"))
            {
                var systemId = searchParams["q_SystemId"];
                Guid system = new Guid(systemId);
                qable = qable.Where((s1, s2) => s1.SystemId == system);
            }

            qable = qable.Where((s1, s2) => s1.DelFlg != false).OrderBy((s1, s2) => s1.SystemId).OrderBy((s1, s2) => s1.Level);

            var pagesEntitys = qable.Select<PagesEntity>((s1, s2) => new PagesEntity()
            {
                AccId = s1.AccId,
                CreateUser = s1.CreateUser,
                DelFlg = s1.DelFlg,

                ImagePath = s1.ImagePath,
                ImageStyle = s1.ImageStyle,

                Id = s1.Id,
                Code = s1.Code,
                Level = s1.Level,
                Name = s1.Name,
                Path = s1.Path,
                Type = s1.Type,
                ParentId = s1.ParentId,
                CreateTime = s1.CreateTime,
                Remark = s1.Remark,

                SystemId = s1.SystemId,
                UpdateUser = s1.UpdateUser,
                UpdateTime = s1.UpdateTime,
                SystemName = s2.Name
            });

            var valuePair = pagesEntitys.ToPageListAsync((skip / take) + 1, take, 0);

            valuePair.Wait();

            var restult = valuePair.Result;

            var list = restult.Key;

            total = restult.Value;

            return list;
        }

        /// <summary>
        /// 通过Code获取页面
        /// </summary>
        /// <param name="entity">页面类</param>
        /// <returns>页面</returns>
        public M_Page GetPageByCode(M_Page entity)
        {
            var db = DbFactory.GetSugarInstance();
            var result = db.Queryable<M_Page>().Where(x => x.SystemId == entity.SystemId && x.Code == entity.Code && x.AccId == entity.AccId && x.Id != entity.Id).SingleAsync();
            result.Wait();
            return result.Result;
        }

        /// <summary>
        /// 获取所有的页面下来框的值
        /// </summary>
        /// <returns>页面下来框</returns>
        public IEnumerable<SelectEntity> GetAll()
        {
            var db = DbFactory.GetSugarInstance();
            var result = db.Queryable<M_Page>()
                         .Where(x => x.DelFlg != false)
                         .Select<SelectEntity>(x =>
                            new SelectEntity()
                            {
                                text = x.Name,
                                id = x.Id.ToString()
                            }).ToListAsync();
            result.Wait();
            return result.Result;
        }

        /// <summary>
        /// 通过系统Id获取所有的页面下来框的值
        /// </summary>
        /// <param name="systemId">系统Id</param>
        /// <param name="level">页面级别</param>
        /// <returns>页面下来框</returns>
        public IEnumerable<SelectEntity> GetAll(string systemId, int level)
        {
            var db = DbFactory.GetSugarInstance();

            var query = db.Queryable<M_Page>();

            if (!string.IsNullOrEmpty(systemId))
            {
                var guid = new Guid(systemId);
                query.Where(x => x.SystemId == guid);
            }

            var result = query
                        .Where(x => x.DelFlg != false && x.Level >= level)
                        .Select<SelectEntity>(x =>
                        new SelectEntity()
                        {
                            text = x.Name,
                            id = x.Id.ToString()
                        }).ToListAsync();
            result.Wait();
            return result.Result;
        }

        /// <summary>
        /// 通过系统名，用户id，帐套id 获得人员权限信息（即此人在该帐套下对应的所有页面信息）
        /// </summary>
        /// <param name="systemCode">系统code</param>
        /// <param name="userId">用户名</param>
        /// <param name="accId">帐套Id</param>
        /// <returns>页面信息</returns>
        public List<M_Page> GetAuthorityInfo(string systemCode, string userId, Guid accId)
        {
            var db = DbFactory.GetSugarInstance();

            var pageList = db.Queryable<M_Page, M_PageAuthority, M_UserRole, M_System, M_UserAcc>(
                    (s1, s2, s3, s4, s5) => new object[]
                    {
                        JoinType.Inner, s1.Id == s2.PageId && s2.DelFlg != false,
                        JoinType.Inner, s2.Id == s3.RoleId && s3.DelFlg != false,
                        JoinType.Inner, s1.SystemId == s4.Id && s4.Code == systemCode,
                        JoinType.Inner, s3.UserId == s5.UserId && s5.DelFlg != false,
                })
             .Where((s1, s3, s5) =>
                                s3.UserId == userId &&
                                s1.AccId == accId &&
                                s1.DelFlg != false)
             .Select("distinct s1.*").ToList();
            return pageList;
        }

        /// <summary>
        /// 通过系统名，用户id，帐套id，获取可跳转的页面信息（即菜单树底层页面）
        /// </summary>
        /// <param name="systemCode">系统code</param>
        /// <param name="userId">用户名</param>
        /// <param name="accId">帐套Id</param>
        /// <returns>树信息</returns>
        public List<MenuEntity> GetPageInfo(string systemCode, string userId, Guid accId)
        {
            var db = DbFactory.GetSugarInstance();

            var pageList = db.Queryable<M_Page, M_PageAuthority, M_UserRole, M_System, M_UserAcc>(
                (s1, s2, s3, s4, s5) => new object[]
                {
                    JoinType.Inner, s1.Id == s2.PageId && s2.DelFlg != false,
                    JoinType.Inner, s2.RoleId == s3.RoleId && s3.DelFlg != false,
                    JoinType.Inner, s1.SystemId == s4.Id && s4.Code == systemCode && s4.DelFlg != false,
                    JoinType.Inner, s3.UserId == s5.UserId && s5.DelFlg != false
                })
                .Where((s1, s2, s3, s4, s5) =>
                          s3.UserId == userId &&
                          s1.AccId == accId &&
                          s1.DelFlg != false)
                .Select((s1, s2, s3, s4, s5) => new MenuEntity()
                {
                    PageId = s1.Id.ToString(),
                    PageCode = s1.Code,
                    PageName = s1.Name,
                    PagePath = s1.Path,
                    ParentId = s1.ParentId,
                    ImageStyle = s1.ImageStyle,
                    ImagePath = s1.ImagePath,
                    PageLevel = s1.Level,
                    AuthorityIdList = s2.AuthorityIdList
                }).ToList();
            return pageList;
        }

        /// <summary>
        /// 获取所有页面以及其权限
        /// </summary>
        /// <param name="accId">帐套ID</param>
        /// <param name="roleId">角色ID</param>
        /// <returns></returns>
        public IEnumerable<PagesEntity> GetAllPageAuthority(string accId, string roleId)
        {
            var db = DbFactory.GetSugarInstance();

            var Role = new Guid(roleId);

            var myRoles = AppContext.Current.UserRole.Select(x => x.Id).ToList();

            var acc = new Guid(accId);

            var result = db.Queryable<M_Page, M_PageAuthority>((s1, s2) => new object[] {
                    JoinType.Inner, s1.Id==s2.PageId && s2.DelFlg != false
                })
                .Where((s1, s2) => (s2.RoleId == Role || myRoles.Contains((Guid)s2.RoleId)) && s1.AccId == acc)
                .GroupBy((s1, s2) => s1.SystemId)
                .Select((s1, s2) => s1.SystemId).ToListAsync();

            result.Wait();

            var systemList = result.Result;

            var qable = db.Queryable<M_Page, M_PageAuthority, M_System, M_Page>(
                (s1, s2, s3, s4) => new object[] {
                    JoinType.Left, s1.Id == s2.PageId && s2.RoleId == Role,
                    JoinType.Left, s1.SystemId == s3.Id && s3.DelFlg != false,
                    JoinType.Left, s1.ParentId == s4.Id && s4.DelFlg != false
                });

            if (!string.IsNullOrEmpty(accId))
            {
                qable = qable.Where(s1 => s1.AccId == acc);
            }

            qable = qable.Where((s1, s2, s3, s4) => systemList.Contains(s1.SystemId));

            qable = qable.Where((s1, s2, s3, s4) => s1.DelFlg != false);

            qable = qable.OrderBy(s1 => s1.Id, OrderByType.Asc);

            var list = qable.Select((s1, s2, s3, s4) => new PagesEntity()
            {
                Id = s1.Id,
                Name = s1.Name,
                Remark = s1.Remark,
                Path = s1.Path,
                ParentId = s1.ParentId,
                Type = s1.Type,
                Level = s1.Level,
                ImageStyle = s1.ImageStyle,
                ImagePath = s1.ImagePath,
                DelFlg = s2.DelFlg,
                AccId = s1.AccId,
                SystemId = s1.SystemId,
                CreateUser = s1.CreateUser,
                CreateTime = s1.CreateTime,
                UpdateUser = s1.UpdateUser,
                UpdateTime = s1.UpdateTime,
                SystemName = s3.Name,
                ParentName = s4.Name,
                AuthorityIdList = s2.AuthorityIdList,
                PageAuthorityId = s2.Id,
                RoleId = s2.Id
            }).ToListAsync();
            list.Wait();
            return list.Result;
        }

        public List<M_Page> GetPageAuthorityInfo(string systemCode, string userId, Guid accId, string pageCode)
        {
            var db = DbFactory.GetSugarInstance();

            var pageList = db.Queryable<M_Page, M_PageAuthority, M_UserRole, M_System, M_UserAcc>(
                    (s1, s2, s3, s4, s5) => new object[]
                    {
                        JoinType.Inner, s1.Id == s2.PageId && s2.DelFlg != false,
                        JoinType.Inner, s2.Id == s3.RoleId && s3.DelFlg != false,
                        JoinType.Inner, s1.SystemId == s4.Id && s4.Code == systemCode,
                        JoinType.Inner, s3.UserId == s5.UserId && s5.DelFlg != false,
                })
             .Where((s1, s3, s5) =>
                                s3.UserId == userId &&
                                s1.AccId == accId &&
                                s1.DelFlg != false)
             .Select("distinct s1.*").ToList();
            return pageList;
        }
    }
}
