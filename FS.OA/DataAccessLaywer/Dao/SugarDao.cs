using SqlSugar;
using System;
using System.Configuration;
using System.Linq;
using FS.OA.Common;

namespace FS.OA.DataAccessLaywer
{
    /// <summary>
    /// sqlSugar连接层
    /// </summary>
    public class SugarDao
    {
        /// <summary>
        /// 禁止实例化
        /// </summary>
        private SugarDao()
        {

        }

        /// <summary>
        /// 连接字符串
        /// </summary>
        public static string ConnectionString
        {
            get
            {
                string reval = ConfigurationManager.ConnectionStrings["SqlServer_net"].ConnectionString; //这里可以动态根据cookies或session实现多库切换
                return reval;
            }
        }

        /// <summary>
        /// 获取实例
        /// </summary>
        /// <returns></returns>
        public static SqlSugarClient GetInstance()
        {
            try
            {
                SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
                {
                    ConnectionString = ConnectionString,
                    DbType = DbType.SqlServer,
                    IsAutoCloseConnection = true
                });

                db.Ado.IsEnableLogEvent = true;
                db.Ado.LogEventStarting = (sql, pars) =>
                {
                    LogHelper.Debug(sql + "\r\n" + db.Utilities.SerializeObject(pars.ToDictionary(it => it.ParameterName, it => it.Value)));
                };

                db.Aop.OnError = (exp) =>
                {
                    LogHelper.Error(exp);
                };

                return db;
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex);
                return null;
            }
        }
    }
}
