using log4net;
using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Web;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace FS.OA.Common
{
    public static class LogHelper
    {
        #region Private Members
        private static readonly ILog log = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        #region Public Members
        public static bool IsDebugEnabled { get { return log.IsDebugEnabled; } }
        public static bool IsInfoEnabled { get { return log.IsInfoEnabled; } }
        public static bool IsWarnEnabled { get { return log.IsWarnEnabled; } }
        public static bool IsErrorEnabled { get { return log.IsErrorEnabled; } }
        public static bool IsFatalEnabled { get { return log.IsFatalEnabled; } }
        #endregion

        #region Logging Methods
        public static void Debug(string message,
                                 string file = "",
                                 int line = 0,
                                 string method = "")
        {
            try
            {
                if (log.IsDebugEnabled)
                {
                    if (string.IsNullOrEmpty(file))
                    {
                        StackFrame frame = new StackTrace(true).GetFrame(1);
                        file = frame.GetFileName();
                        line = frame.GetFileLineNumber();
                        method = frame.GetMethod().Name;
                    }

                    log.Debug(LogFormat(file, line, method,
                                        message));
                }
            }
            catch (Exception)
            { }
        }

        public static void Info(string message,
                                string file = "",
                                int line = 0,
                                string method = "")
        {
            try
            {
                if (log.IsInfoEnabled)
                {
                    if (string.IsNullOrEmpty(file))
                    {
                        StackFrame frame = new StackTrace(true).GetFrame(1);
                        file = frame.GetFileName();
                        line = frame.GetFileLineNumber();
                        method = frame.GetMethod().Name;
                    }
                    log.Info(LogFormat(file, line, method,
                                       message));
                }
            }
            catch (Exception)
            { }
        }

        public static void Warn(string message,
                                string file = "",
                                int line = 0,
                                string method = "")
        {
            try
            {
                if (log.IsWarnEnabled)
                {
                    if (string.IsNullOrEmpty(file))
                    {
                        StackFrame frame = new StackTrace(true).GetFrame(1);
                        file = frame.GetFileName();
                        line = frame.GetFileLineNumber();
                        method = frame.GetMethod().Name;
                    }
                    log.Warn(LogFormat(file, line, method,
                                       message));
                }
            }
            catch (Exception)
            { }
        }

        public static void Error(Exception ex,
                                 string file = "",
                                 int line = 0,
                                 string method = "")
        {
             try
            {
                if (log.IsErrorEnabled)
                {
                    if (string.IsNullOrEmpty(file))
                    {
                        StackFrame frame = new StackTrace(true).GetFrame(1);
                        file = frame.GetFileName();
                        line = frame.GetFileLineNumber();
                        method = frame.GetMethod().Name;
                    }
                    log.Error(LogFormat(file, line, method,
                                        ex));
                }
            }
            catch (Exception)
            { }
        }

        public static void Fatal(Exception ex,
                                 string file = "",
                                 int line = 0,
                                 string method = "")
        {
            try
            {
                if (log.IsFatalEnabled)
                {
                    if (string.IsNullOrEmpty(file))
                    {
                        StackFrame frame = new StackTrace(true).GetFrame(1);
                        file = frame.GetFileName();
                        line = frame.GetFileLineNumber();
                        method = frame.GetMethod().Name;
                    }
                    log.Fatal(LogFormat(file, line, method,
                                        ex));
                }
            }
             catch (Exception)
             { }
        }
        #endregion

        #region Utility Methods
        private static string LogFormat(string file,
                                       int line,
                                       string method,
                                       string message)
        {
            var address = string.Empty;

            if (HttpContext.Current.Request != null)
            {
                address = HttpContext.Current.Request.UserHostAddress;
            }
            else
            {
                address = LocalIPAddress();
            }



            var userCode = HttpContext.Current.Session["UserCode"] != null ? HttpContext.Current.Session["UserCode"] : "System";

            return string.Format("[{4}][{5}][{0}:{1} - {2}]{3}",
                                 file, line, method,
                                 message, address, userCode);
        }

        private static string LogFormat(string file,
                                        int line,
                                        string method,
                                        Exception ex)
        {
            var address = string.Empty;

            if (HttpContext.Current.Request != null)
            {
                address = HttpContext.Current.Request.UserHostAddress;
            }
            else
            {
                address = LocalIPAddress();
            }



            var userCode = HttpContext.Current.Session["UserCode"] != null ? HttpContext.Current.Session["UserCode"] : "System";

            return string.Format("[{4}][{5}][{0}:{1} - {2}]{3}",
                                 file, line, method,
                                 SerializeException(ex), address, userCode);
        }

        private static string SerializeException(Exception ex)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(ex);
        }
        #endregion

        private static string LocalIPAddress()
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
    }
}
