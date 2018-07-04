using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infusion.Framework.RedisInfo.Init
{
    /// <summary>
    /// Redis管理中心
    /// </summary>
    public class RedisManager
    {


        /// <summary>
        /// Redis配置信息
        /// </summary>
        private static RedisConfigInfo RedisConfigInfo = new RedisConfigInfo();

        /// <summary>
        /// Redis客户端池化管理
        /// </summary>
        private static PooledRedisClientManager prcManager;

        /// <summary>
        /// 静态构造方法，初始化链接池管理对象
        /// </summary>
        static RedisManager()
        {
            CreateManager();
        }

        /// <summary>
        /// 创建连接池管理对象
        /// </summary>
        private static void CreateManager()
        {
            try
            {
                string[] WriteServiceConstr = RedisConfigInfo.RedisWriteAdd.Split(',');
                string[] ReadServiceConstr = RedisConfigInfo.RedisReadAdd.Split(',');
                prcManager = new PooledRedisClientManager(WriteServiceConstr, ReadServiceConstr,
                    new RedisClientManagerConfig
                    {
                        MaxReadPoolSize = RedisConfigInfo.RedisMaxReadCount,
                        MaxWritePoolSize = RedisConfigInfo.RedisMaxWriteCount,
                        AutoStart = RedisConfigInfo.AutoStart
                    });
            }
            catch (Exception ex)
            {
                //SILogUtil.Error("创建Redis连接池管理对象失败:" + ex.Message + "\r\n跟踪:" + ex.StackTrace);
            }
        }


        /// <summary>
        /// 客户端缓存操作对象
        /// </summary>
        public static IRedisClient GetClient()
        {
            try
            {
                return prcManager.GetClient();
            }
            catch (Exception ex)
            {
                //SILogUtil.Error("创建客户端缓存操作对象失败:" + ex.Message + "\r\n跟踪:" + ex.StackTrace);
                return null;
            }
        }
    }
}
