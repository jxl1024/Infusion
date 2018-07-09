using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using log4net.Repository;
using log4net;
using log4net.Config;

namespace Infusion.Framework.Log
{
    //[assembly: log4net.Config.XmlConfigurator(ConfigFile = @"log4net.xml", Watch = true)]
    public static class LogUtil
    {
        public static ILoggerRepository repository { get; set; }
        private const string _configFileName = "log4net.config";
        private const string _loggerName = "SILog";
        private static log4net.ILog _log4netInstance = null;

        static LogUtil()
        {
            Loadconfiguration();
        }

        public static log4net.ILog Log4netInstance
        {
            get
            {
                if (_log4netInstance == null || _log4netInstance.Logger.Repository.Configured == false)
                {
                    Loadconfiguration();
                }

                return _log4netInstance;
            }
        }

        public static void Loadconfiguration()
        {
            if (_log4netInstance == null || _log4netInstance.Logger.Repository.Configured == false)
            {
                string iisBinPath = Directory.GetCurrentDirectory();
                //string iisBinPath = AppDomain.CurrentDomain.RelativeSearchPath;
                if (!string.IsNullOrEmpty(iisBinPath))
                {
                    //string sFilePath = System.Web.HttpRuntime.AppDomainAppPath + "..\\" + _configFileName;
                    string sFilePath = iisBinPath + "..\\" + _configFileName;
                    try
                    {
                        if (System.IO.File.Exists(sFilePath))
                        {
                            repository = LogManager.CreateRepository("NETCoreRepository");
                            // 指定配置文件
                            XmlConfigurator.Configure(repository, new FileInfo("log4net.config"));

                            //log4net.Config.XmlConfigurator.Configure()
                            //log4net.Config.XmlConfigurator.Configure(new FileInfo(sFilePath));
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.Write(ex.Message + "\r\n" + ex.StackTrace);
                    }

                    _log4netInstance = log4net.LogManager.GetLogger("NETCoreRepository", _loggerName);
                }
                else
                {
                    _log4netInstance = log4net.LogManager.GetLogger("NETCoreRepository",_loggerName);
                }
            }
        }

        public static bool IsDebugEnabled
        {
            get { return _log4netInstance.IsDebugEnabled; }
        }

        public static bool IsErrorEnabled
        {
            get { return _log4netInstance.IsErrorEnabled; }
        }

        public static bool IsFatalEnabled
        {
            get { return _log4netInstance.IsFatalEnabled; }
        }

        public static bool IsInfoEnabled
        {
            get { return _log4netInstance.IsInfoEnabled; }
        }

        public static bool IsWarnEnabled
        {
            get { return _log4netInstance.IsWarnEnabled; }
        }

        public static void Debug(object message)
        {
            _log4netInstance.Debug(message);
        }

        public static void Debug(object message, Exception exception)
        {
            _log4netInstance.Debug(message, exception);
        }

        public static void DebugFormat(string format, object arg0)
        {
            _log4netInstance.DebugFormat(format, arg0);
        }

        public static void DebugFormat(string format, params object[] args)
        {
            _log4netInstance.DebugFormat(format, args);
        }

        public static void DebugFormat(IFormatProvider provider, string format, params object[] args)
        {
            _log4netInstance.DebugFormat(provider, format, args);
        }

        public static void DebugFormat(string format, object arg0, object arg1)
        {
            _log4netInstance.DebugFormat(format, arg0, arg1);
        }

        public static void DebugFormat(string format, object arg0, object arg1, object arg2)
        {
            _log4netInstance.DebugFormat(format, arg0, arg1, arg2);
        }

        public static void Error(object message)
        {
            _log4netInstance.Error(message);
        }

        public static void Error(object message, Exception exception)
        {
            _log4netInstance.Error(message, exception);
        }

        public static void ErrorFormat(string format, object arg0)
        {
            _log4netInstance.ErrorFormat(format, arg0);
        }

        public static void ErrorFormat(string format, params object[] args)
        {
            _log4netInstance.ErrorFormat(format, args);
        }

        public static void ErrorFormat(IFormatProvider provider, string format, params object[] args)
        {
            _log4netInstance.ErrorFormat(provider, format, args);
        }

        public static void ErrorFormat(string format, object arg0, object arg1)
        {
            _log4netInstance.ErrorFormat(format, arg0, arg1);
        }

        public static void ErrorFormat(string format, object arg0, object arg1, object arg2)
        {
            _log4netInstance.ErrorFormat(format, arg0, arg1, arg2);
        }

        public static void Fatal(object message)
        {
            _log4netInstance.Fatal(message);
        }

        public static void Fatal(object message, Exception exception)
        {
            _log4netInstance.Fatal(message, exception);
        }

        public static void FatalFormat(string format, object arg0)
        {
            _log4netInstance.FatalFormat(format, arg0);
        }

        public static void FatalFormat(string format, params object[] args)
        {
            _log4netInstance.FatalFormat(format, args);
        }

        public static void FatalFormat(IFormatProvider provider, string format, params object[] args)
        {
            _log4netInstance.FatalFormat(provider, format, args);
        }

        public static void FatalFormat(string format, object arg0, object arg1)
        {
            _log4netInstance.FatalFormat(format, arg0, arg1);
        }

        public static void FatalFormat(string format, object arg0, object arg1, object arg2)
        {
            _log4netInstance.FatalFormat(format, arg0, arg1, arg2);
        }

        public static void Info(object message)
        {
            _log4netInstance.Info(message);
        }

        public static void Info(object message, Exception exception)
        {
            _log4netInstance.Info(message, exception);
        }

        public static void InfoFormat(string format, object arg0)
        {
            _log4netInstance.InfoFormat(format, arg0);
        }

        public static void InfoFormat(string format, params object[] args)
        {
            _log4netInstance.InfoFormat(format, args);
        }

        public static void InfoFormat(IFormatProvider provider, string format, params object[] args)
        {
            _log4netInstance.InfoFormat(provider, format, args);
        }

        public static void InfoFormat(string format, object arg0, object arg1)
        {
            _log4netInstance.InfoFormat(format, arg0, arg1);
        }

        public static void InfoFormat(string format, object arg0, object arg1, object arg2)
        {
            _log4netInstance.InfoFormat(format, arg0, arg1, arg2);
        }

        public static void Warn(object message)
        {
            _log4netInstance.Warn(message);
        }

        public static void Warn(object message, Exception exception)
        {
            _log4netInstance.Warn(message, exception);
        }

        public static void WarnFormat(string format, object arg0)
        {
            _log4netInstance.WarnFormat(format, arg0);
        }

        public static void WarnFormat(string format, params object[] args)
        {
            _log4netInstance.WarnFormat(format, args);
        }

        public static void WarnFormat(IFormatProvider provider, string format, params object[] args)
        {
            _log4netInstance.WarnFormat(provider, format, args);
        }

        public static void WarnFormat(string format, object arg0, object arg1)
        {
            _log4netInstance.WarnFormat(format, arg0, arg1);
        }

        public static void WarnFormat(string format, object arg0, object arg1, object arg2)
        {
            _log4netInstance.WarnFormat(format, arg0, arg1, arg2);
        }
    }
}
