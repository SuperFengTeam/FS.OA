//-----------------------------------------------------------------------
// <copyright file="UserDal.cs" company="FengSoft">
//     Copyright (C) 2018
//     功能描述：UserDal
//     创建标识：任锋     ADD     2018-01-22
//     修改标识：
// </copyright>
//-----------------------------------------------------------------------

using System;
using FY.MVC.Entity;
using FY.MVC.IDAL;
using SqlSugar;
using System.Collections.Generic;
using FY.MVC.Common;

namespace FY.MVC.DAL
{
    /// <summary>
    /// 用户数据层
    /// </summary>
    public class UserDal : DalBase, IUserDal
    {
        /// <summary>
        /// 使用用户名，密码获取用户
        /// </summary>
        /// <param name="userId">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>用户</returns>
        public M_User GetUserInfo(string userId, string password)
        {
            try
            {
                var db = SugarDao.GetInstance();
                var result = db.Queryable<M_User>().Where(x => x.UserName == userId && x.Password == password && x.DelFlg!=false).SingleAsync();
                result.Wait();
                return result.Result;
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex);
                return null;
            }
        }

        /// <summary>
        /// 使用用户名获取用户
        /// </summary>
        /// <param name="userId">用户名</param>
        /// <returns>用户</returns>
        public M_User GetUserById(string userId)
        {
            try
            {
                var db = SugarDao.GetInstance();
                var result = db.Queryable<M_User>().Where(x => x.UserName == userId && x.DelFlg != false).SingleAsync();
                result.Wait();
                return result.Result;
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex);
                return null;
            }
        }

        /// <summary>
        /// 使用用户名获取用户
        /// </summary>
        /// <param name="userId">用户名</param>
        /// <param name="accId">账套Id</param>
        /// <returns>用户</returns>
        public M_User GetUserById(string userId, string accId)
        {
            try
            {
                var db = SugarDao.GetInstance();

                var id = new Guid(accId);

                var queryable = db.Queryable<M_User, M_UserAcc>((s1, s2) => new object[]
                {
                JoinType.Inner, s1.UserName == s2.UserId
                });

                queryable = queryable.Where((s1, s2) =>
                    s1.UserName == userId && s2.AccId == id && s1.DelFlg != false && s2.DelFlg != false);

                var result = queryable.SingleAsync();

                result.Wait();

                return result.Result;
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex);
                return null;
            }
        }

        /// <summary>
        /// 获取用户列表
        /// </summary>
        /// <param name="total">结果总条数</param>
        /// <param name="take">每页条数</param>
        /// <param name="skip">页数</param>
        /// <param name="searchParams">查询条件</param>
        /// <returns>用户列表</returns>
        public IEnumerable<IEntityBase> GetList(ref int total, int take, int skip, Dictionary<string, string> searchParams)
        {
            using (var db = SugarDao.GetInstance())
            {
                return null;
            }
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="entity">用户类</param>
        /// <returns>操作结果</returns>
        public bool DeleteUser(List<M_User> entity)
        {
            try
            {
                return this.Delete(entity);
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex);
                return false;
            }
        }

        /// <summary>
        /// 插入用户
        /// </summary>
        /// <param name="entity">用户类</param>
        /// <returns>操作结果</returns>
        public bool InsertUser(M_User entity)
        {
            try
            {
                return this.Insert(entity);
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex);
                return false;
            }
        }

        /// <summary>
        /// 更新用户
        /// </summary>
        /// <param name="entity">用户类</param>
        /// <returns>操作结果</returns>
        public bool UpdateUser(M_User entity)
        {
            try
            {
                return this.Update(entity);
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex);
                return false;
            }
        }

        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="entity">用户类</param>
        /// <param name="userAcc">账号类</param>
        /// <returns>操作结果</returns>
        public bool SignUp(M_User entity, M_UserAcc userAcc)
        {
            try
            {
                var db = DbFactory.GetSugarInstance();

                var result = db.Ado.UseTran(() =>
                {
                    db.Insertable<M_User>(entity).ExecuteCommand();
                    db.Insertable<M_UserAcc>(userAcc).ExecuteCommand();
                });

                return result.IsSuccess;
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex);
                return false;
            }
        }
    }
}
