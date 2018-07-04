using Infusion.Framework.RedisInfo.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infusion.Framework.RedisInfo.Service
{
    public class RedisStringService : RedisBase
    {
        #region Set
        /// <summary>
        /// 设置key-value值 key：string类型，value：string类型
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Set(string key, string value)
        {
            return base.iClient.Set<string>(key, value);
        }

        /// <summary>
        /// 设置key-value值 key：string类型，Value：T类型
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Set<T>(string key, T value)
        {
            return base.iClient.Set<T>(key, value);
        }

        /// <summary>
        /// 设置key的value并设置过期时间
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Set(string key, string value, DateTime dt)
        {
            return base.iClient.Set<string>(key, value, dt);
        }

        /// <summary>
        /// 设置多个key/value
        /// </summary>
        /// <param name="dic"></param>
        public void Set(Dictionary<string, string> dic)
        {
            base.iClient.SetAll(dic);
        }
        #endregion

        #region Add
        public bool Add<T>(string key, T value)
        {
            return base.iClient.Add<T>(key, value);
        }
        #endregion

        #region 追加

        /// <summary>
        /// 在原有key的value值之后追加value，返回的是追加之后的value值的长度
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public long Append(string key, string value)
        {
            return base.iClient.AppendToValue(key, value);
        }

        #endregion

        #region 获取值

        /// <summary>
        /// 获取key的值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string Get(string key)
        {
            return base.iClient.GetValue(key);
        }

        /// <summary>
        /// 获取T类型的value值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public T Get<T>(string key)
        {
            return base.iClient.Get<T>(key);
        }

        /// <summary>
        /// 获取多个key的value值
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        public List<string> Get(List<string> keys)
        {
            return base.iClient.GetValues(keys);
        }

        /// <summary>
        /// 获取多个key的value值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="keys"></param>
        /// <returns></returns>
        public List<T> Get<T>(List<string> keys)
        {
            return base.iClient.GetValues<T>(keys);
        }
        #endregion

        #region 获取旧值并赋新值


        /// <summary>
        /// 获取旧值并赋新值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public string GetAndSetValue(string key, string value)
        {
            return base.iClient.GetAndSetEntry(key, value);
        }
        #endregion

        #region 移除

        /// <summary>
        /// 根据key移除value
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool Remove(string key)
        {
            return base.iClient.Remove(key);
        }

        /// <summary>
        /// 根据key移除所有
        /// </summary>
        /// <param name="keys"></param>
        public void RemoveAll(IEnumerable<string> keys)
        {
            base.iClient.RemoveAll(keys);
        }
        #endregion

        #region 替换

        public bool Replace<T>(string key, T value)
        {
            return base.iClient.Replace<T>(key, value);
        }
        #endregion

        #region 辅助方法

        /// <summary>
        /// 自增1，返回自增后的值
        /// 注意：使用此方法时value值必须是interger类型
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public long Incr(string key)
        {
            return base.iClient.IncrementValue(key);
        }


        /// <summary>
        /// 自减1，返回自减后的值
        /// 注意： 使用此方法时value值必须是interger类型
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public long Decr(string key)
        {
            return base.iClient.DecrementValue(key);
        }

        /// <summary>
        /// 自减count，返回自减后的值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public long DecrBy(string key, int count)
        {
            return base.iClient.DecrementValueBy(key, count);
        }
        #endregion
    }
}
