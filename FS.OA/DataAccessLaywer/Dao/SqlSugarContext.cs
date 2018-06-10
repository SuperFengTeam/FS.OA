using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FS.OA.Common;
using SqlSugar;

namespace FS.OA.DataAccessLaywer
{
    public class SqlSugarContext
    {
        public SqlSugarContext()
        {
            Db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = "xx",
                DbType = DbType.SqlServer,
                IsAutoCloseConnection = true
            });

            Db.Ado.IsEnableLogEvent = true;
            Db.Ado.LogEventStarting = (sql, pars) =>
            {
                LogHelper.Debug(sql + "\r\n" + Db.Utilities.SerializeObject(pars.ToDictionary(it => it.ParameterName, it => it.Value)));
            };

            Db.Aop.OnError = (exp) =>
            {
                LogHelper.Error(exp);
            };
        }
        public SqlSugarClient Db;//用来处理事务多表查询和复杂的操作
        //public SimpleClient<Student> StudentDb { get { return new SimpleClient<Student>(Db); } }//用来处理Student表的常用操作
        //public SimpleClient<School> SchoolDb { get { return new SimpleClient<School>(Db); } }//用来处理School表的常用操作
    }
}
