using Infusion.Framework.Manager;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infusion.Framework.RedisInfo.Init
{
    /// <summary>
    /// Redis配置信息类
    /// </summary>
    public class RedisConfigInfo
    {
        //private ConnectionStringSettingsCollection _connectionStrings;

        public string RedisReadAdd { get; set; }
        public string RedisWriteAdd { get; set; }
        public int RedisMaxReadCount { get; set; }
        public int RedisMaxWriteCount { get; set; }
        public int LocalCacheTime { get; set; }
        public bool AutoStart { get; set; }
        public bool RecordeLog { get; set; }

        public RedisConfigInfo()
        {
            //GetConnectionStrings();
            SetRedisConfig();
        }

        private void SetRedisConfig()
        {
            try
            {

                /// <summary>
                /// 可读的Redis地址
                /// </summary>
                //public string ReadServiceAdd = ConfigurationManager.AppSettings["RedisReadAddress"];_connectionStrings[connectionName].ConnectionString
                //RedisReadAdd = _connectionStrings["RedisReadAddress"].ConnectionString;
                RedisReadAdd = JsonManager.GetValue("RedisReadAddress");

                /// <summary>
                /// 可写的Redis地址
                /// </summary>
                //RedisWriteAdd = ConfigurationManager.AppSettings["RedisWriteAddress"];
                //RedisWriteAdd = _connectionStrings["RedisWriteAddress"].ConnectionString;
                RedisWriteAdd = JsonManager.GetValue("RedisWriteAddress");

                
                /// <summary>
                /// 最大写连接数
                /// </summary>
                //RedisMaxReadCount = Convert.ToInt32(ConfigurationManager.AppSettings["MaxReadCount"]);
                //RedisMaxReadCount = Convert.ToInt32(_connectionStrings["MaxReadCount"].ConnectionString);
                RedisMaxReadCount = Convert.ToInt32(JsonManager.GetValue("RedisWriteAddress"));

                /// <summary>
                /// 最大读链接数
                /// </summary>
                //RedisMaxWriteCount = Convert.ToInt32(ConfigurationManager.AppSettings["RedisMaxWriteCount"]);
                RedisMaxWriteCount = Convert.ToInt32(JsonManager.GetValue("MaxWriteCount"));

                /// <summary>
                /// 本地缓存到期时间   单位：秒
                /// </summary>
                //LocalCacheTime = Convert.ToInt32(ConfigurationManager.AppSettings["CacheTimeOut"]);
                LocalCacheTime = Convert.ToInt32(JsonManager.GetValue("CacheTimeOut"));

                /// <summary>
                /// 自动重启
                /// </summary>
                AutoStart = true;
                /// <summary>
                /// 是否记录日志,该设置仅用于排查redis运行时出现的问题,
                /// 如redis工作正常,请关闭该项
                /// </summary>
                RecordeLog = true;
            }
            catch (Exception ex)
            {
                //SILogUtil.Error("设置Redis地址失败:" + ex.Message + "\r\n跟踪:" + ex.StackTrace);
            }
        }

        private void GetConnectionStrings()
        {
            try
            {
                // 当前目录的上一层目录
                //string sFilePath = HttpRuntime.AppDomainAppPath + "..\\Connect.config";
                //if (System.IO.File.Exists(sFilePath))
                //{
                //    ExeConfigurationFileMap file = new ExeConfigurationFileMap();
                //    file.ExeConfigFilename = sFilePath;
                //    Configuration config = ConfigurationManager.OpenMappedExeConfiguration(file, ConfigurationUserLevel.None);
                //    _connectionStrings = config.ConnectionStrings.ConnectionStrings;
                //}
                //else
                //{
                //    _connectionStrings = ConfigurationManager.ConnectionStrings;
                //}
            }
            catch (Exception ex)
            {
                //_connectionStrings = ConfigurationManager.ConnectionStrings;
                //SILogUtil.Error("Redis读取配置文件失败:" + ex.Message + "\r\n跟踪:" + ex.StackTrace);
            }
        }
    }
}
