using FS.OA.Common;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace FS.OA.DataAccessLaywer
{
    public class DalBase : EFContext
    {
        #region sqlSugar
        /// <summary>
        /// 插入
        /// </summary>
        /// <param name="sql">插入语句</param>
        /// <returns>插入条数</returns>
        public int SqlInsert(string sql)
        {
            var dao = DbFactory.GetSugarInstance();

            return dao.Ado.ExecuteCommand(sql);
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="sql">更新语句</param>
        /// <param name="param">参数</param>
        /// <returns>更新条数</returns>
        public int SqlUpdate(string sql, object param)
        {
            var dao = DbFactory.GetSugarInstance();

            return dao.Ado.ExecuteCommand(sql, param);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sql">删除语句</param>
        /// <param name="param">参数</param>
        /// <returns>删除条数</returns>
        public int SqlDelete(string sql, object param)
        {
            var dao = DbFactory.GetSugarInstance();

            return dao.Ado.ExecuteCommand(sql, param);
        }

        /// <summary>
        /// 插入数据
        /// </summary>
        /// <typeparam name="T">插入表</typeparam>
        /// <param name="t">插入数据</param>
        /// <returns>插入后主键</returns>
        public virtual bool InsertForSugar<T>(T t) where T : class, new()
        {
            var dao = DbFactory.GetSugarInstance();

            var result = dao.Insertable<T>(t).ExecuteCommandAsync();

            result.Wait();

            return result.Result > 0;
        }

        /// <summary>
        /// 插入数据
        /// </summary>
        /// <typeparam name="T">插入表</typeparam>
        /// <param name="list">插入数据</param>
        /// <returns>插入后主键</returns>
        public virtual bool InsertForSugar<T>(List<T> list) where T : class, new()
        {
            var dao = DbFactory.GetSugarInstance();

            var result = dao.Insertable<T>(list).ExecuteCommandAsync();

            result.Wait();

            return result.Result > 0;
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <typeparam name="T">更新表</typeparam>
        /// <param name="t">更新数据</param>
        /// <returns>更新结果</returns>
        public virtual bool UpdateForSugar<T>(T t) where T : class, new()
        {
            var dao = DbFactory.GetSugarInstance();

            var result = dao.Updateable<T>(t).IgnoreColumns(it => it == "CreateUser" || it == "CreateTime").ExecuteCommandAsync();

            result.Wait();

            return result.Result > 0;
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <typeparam name="T">更新表</typeparam>
        /// <param name="t">更新数据</param>
        /// <returns>更新结果</returns>
        public virtual bool UpdateForSugar<T>(List<T> t) where T : class, new()
        {
            var dao = DbFactory.GetSugarInstance();

            var result = dao.Updateable<T>(t).IgnoreColumns(it => it == "CreateUser" || it == "CreateTime").ExecuteCommandAsync();

            result.Wait();

            return result.Result > 0;
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <typeparam name="T">删除表</typeparam>
        /// <param name="t">删除数据</param>
        /// <returns>删除结果</returns>
        public virtual bool DeleteForSugar<T>(List<T> t) where T : class, new()
        {
            var dao = DbFactory.GetSugarInstance();
            if (XmlHelper.GetDeleteFlg())
            {
                var result = dao.Deleteable<T>(t).ExecuteCommandAsync();

                result.Wait();

                return result.Result > 0;
            }
            else
            {
                return this.UpdateForSugar<T>(t);
            }   
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <typeparam name="T">删除表</typeparam>
        /// <param name="ids">删除数据的主键</param>
        /// <returns>删除结果</returns>
        public virtual bool DeleteForSugar<T>(string[] ids) where T : class,new()
        {
            var dao = DbFactory.GetSugarInstance();

            var result = dao.Deleteable<T>().In(ids).ExecuteCommandAsync();

            result.Wait();

            return result.Result > 0;
        }

        /// <summary>
        /// 获取数据库时间
        /// </summary>
        /// <returns>数据库时间</returns>
        public DateTime GetDateTime()
        {
            var db = DbFactory.GetSugarInstance();
            var dateTime = db.Ado.GetDateTime("select getdate()");
            return dateTime;
        }

        /// <summary>
        /// 通过ID获取对象
        /// </summary>
        /// <typeparam name="T">对象</typeparam>
        /// <param name="t">对象</param>
        /// <returns>对象</returns>
        public virtual T GetObjById<T>(T t) where T : class, new()
        {
            var db = DbFactory.GetSugarInstance();

            Type target = t.GetType();

            PropertyInfo targetPP = target.GetProperty("Id");

            return db.Queryable<T>().InSingle(targetPP.GetValue(t, null));
        }

        #endregion
    }
}
