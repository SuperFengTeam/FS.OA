using System;
using System.Activities.Statements;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Web;

namespace FS.OA.Common
{
    public class AppContext
    {
        public string UserCode
        {
            get
            {
                return HttpContext.Current.Session[ConstHelper.ConstID.SESSION_USERCODE].ToString();
            }
        }
        public string UserName
        {
            get
            {
                return HttpContext.Current.Session[ConstHelper.ConstID.SESSION_USERNAME].ToString();
            }
        }
        public string UserID
        {
            get
            {
                if (HttpContext.Current.Session[ConstHelper.ConstID.SESSION_USERID] == null)
                {
                    return string.Empty;
                }
                return HttpContext.Current.Session[ConstHelper.ConstID.SESSION_USERID].ToString();
            }
        }
        public string SystemId
        {
            get
            {
                return HttpContext.Current.Session[ConstHelper.ConstID.SESSION_SYSTEMID].ToString();
            }
        }

        public string AccId
        {
            get
            {
                if (HttpContext.Current.Session[ConstHelper.ConstID.SESSION_ACCID] == null)
                {
                    return string.Empty;
                }
                return HttpContext.Current.Session[ConstHelper.ConstID.SESSION_ACCID].ToString();
            }
        }

        //public List<M_Role> UserRole
        //{
        //    get
        //    {
        //        if (HttpContext.Current.Session[ConstHelper.ConstID.SESSION_USER_ROLES] == null)
        //        {
        //            return new List<M_Role>();
        //        }
        //        return (List<M_Role>)HttpContext.Current.Session[ConstHelper.ConstID.SESSION_USER_ROLES];
        //    }
        //}

        /// <summary>
        /// 逻辑删除标志
        /// </summary>
        public bool DeleteFle
        {
            get
            {
                var flg = HttpRuntime.Cache.Get(ConstHelper.ConstID.CACHE_DELETEFLG);

                if (flg != null)
                {
                    return (bool)flg;
                }

                return false;
            }
        }
        public string TimeStamp { get { return DateTime.Now.ToString("yyyyMMddHHmmssfff"); } }

        // 如果前端有反向代理或处于云环境可能需要获取代理地址
        // 具体参考：http://www.cnblogs.com/cmt/archive/2013/03/09/request_userhostaddress-x_forwarded_For.html
        private string _HostAddress = null;
        public string HostAddress
        {
            get
            {
                if (string.IsNullOrEmpty(_HostAddress))
                {
                    if (Request != null)
                    {
                        _HostAddress = Request.UserHostAddress;
                    }
                    else
                    {
                        _HostAddress = LocalIPAddress();
                    }
                }
                return _HostAddress;
            }
        }

        private string LocalIPAddress()
        {
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                    break;
                }
            }
            return localIP;
        }

        public HttpContext Context
        {
            get
            {
                return HttpContext.Current;
            }
        }

        public HttpRequest Request
        {
            get
            {
                return this.Context == null ? null : this.Context.Request;
            }
        }

        public HttpResponse Response
        {
            get
            {
                return this.Context == null ? null : this.Context.Response;
            }
        }

        [ThreadStatic]
        private static AppContext _Current = null;
        public static AppContext Current
        {
            get
            {
                if (_Current == null) _Current = new AppContext();
                return _Current;
            }
        }

        public TransactionScope Transaction { get; set; }

        public Exception Exception { get; set; }

        public MethodBase TransactionMethodBase { get; set; }

        private AppContext()
        {

        }

    }
}
