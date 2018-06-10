//-----------------------------------------------------------------------
// <copyright file="AuthorityDAL.cs" company="FengSoft">
//     Copyright (C) 2018
//     功能描述：AuthorityDAL
//     创建标识：任锋     ADD     2018-01-22
//     修改标识：
// </copyright>
//-----------------------------------------------------------------------
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using FS.OA.Common;
using FS.OA.Entity;

namespace FS.OA.DataAccessLaywer
{
    /// <summary>
    /// 权限设置数据层
    /// </summary>
    public class AuthorityDal : DalBase
    {
        /// <summary>
        /// 查询权限
        /// </summary>
        /// <param name="total">行数</param>
        /// <param name="take">显示行数</param>
        /// <param name="skip">第几页</param>
        /// <param name="searchParams">检索条件</param>
        /// <returns>权限信息</returns>
        public async Task<List<M_Authority>> GetList(int take, int skip, Dictionary<string, string> searchParams)
        {
            try
            {


                //ParameterExpression parameter1 = Expression.Parameter(typeof(T), "p");

                //for (int i = 0; i < searchParams.Count; i++)
                //{
                //    MemberExpression member = Expression.PropertyOrField(parameter1, searchParams.Keys.ElementAt(i));
                //    ConstantExpression constant = Expression.Constant(searchParams.Keys.ElementAt(i));
                //    explist[i] = Expression.Equal(member, constant);//根据操作符arry3调用equal或者其他
                //}

                var q = from item in M_Authority select item;

                if (searchParams.ContainsKey("q_AuthorityName"))
                {
                    var authorityName = searchParams["q_AuthorityName"];
                    q = q.Where(x => x.Name == authorityName);
                }

                q = q.Where(x => x.DelFlg != false);

                q = q.OrderBy(x => x.Id);

                q = q.Take(take).Skip(skip);

                var result = q.ToListAsync();

                await result;

                return result.Result;

                //var db = DbFactory.GetSugarInstance();
                //var qable = db.Queryable<M_Authority>();

                //if (searchParams.ContainsKey("q_AuthorityName"))
                //{
                //    var authorityName = searchParams["q_AuthorityName"];
                //    qable = qable.Where(x => x.Name == authorityName);
                //}

                //qable = qable.Where(x => x.DelFlg != false);

                //qable = qable.OrderBy(x => x.Id, OrderByType.Asc);

                //var valuePair = qable.ToPageListAsync((skip / take) + 1, take, 0);

                //valuePair.Wait();

                //var restult = valuePair.Result;

                //var list = restult.Key;

                //total = restult.Value;

                //return list;
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex);
                return null;
            }
        }

        /// <summary>
        /// 获取权限下拉框
        /// </summary>
        /// <returns>权限下拉框数据</returns>
        public List<SelectEntity> GetAll()
        {
            try
            {
                var db = DbFactory.GetSugarInstance();
                var qable = db.Queryable<M_Authority>();
                qable = qable.Where(x => x.DelFlg != false);
                qable = qable.OrderBy(x => x.Id, OrderByType.Asc);
                var list = qable.Select<SelectEntity>(x => new SelectEntity()
                {
                    text = x.Name,
                    id = x.Id.ToString()
                }).ToListAsync();

                list.Wait();
                return list.Result;
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex);
                return null;
            }
        }
    }
}
