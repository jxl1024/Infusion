using Infusion.Framework.RedisInfo.Init;
using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infusion.Framework.RedisInfo.Interface
{
    /// <summary>
    /// RedisBase类，是redis操作的基类，继承自IDisposable接口，主要用于释放内存
    /// </summary>
    public abstract class RedisBase : IDisposable
    {

        public IRedisClient iClient
        { get; private set; }

        public RedisBase()
        {
            try
            {
                iClient = RedisManager.GetClient();
            }
            catch (Exception ex)
            {
                //SILogUtil.Error("创建Redis客户端对象失败:" + ex.Message + "\r\n跟踪:" + ex.StackTrace);
            }
        }

        public virtual void FlushAll()
        {
            iClient.FlushAll();
        }

        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    iClient.Dispose();
                    iClient = null;
                }
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// 保存数据DB文件到硬盘
        /// </summary>
        public void Save()
        {
            iClient.Save();
        }

        /// <summary>
        /// 异步保存数据DB文件到硬盘
        /// </summary>
        public void SaveAsync()
        {
            iClient.SaveAsync();
        }
    }
}
