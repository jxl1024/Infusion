using Infusion.Framework.RedisInfo.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infusion.Framework.RedisInfo.Service
{
    public class RedisHashService : RedisBase
    {
        #region 添加

        /// <summary>
        /// 想hash集合中添加key/value
        /// </summary>
        /// <param name="hasdid"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool SetEntryInHash(string hasdid, string key, string value)
        {
            return base.iClient.SetEntryInHash(hasdid, key, value);
        }

        /// <summary>
        /// 如果hash集合中已经存在key/value，则不添加，返回false
        /// 如果hash集合中不存在key/value，则添加，并返回true
        /// </summary>
        /// <param name="hasdid"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool SetEntryInHashIfNoExists(string hasdid, string key, string value)
        {
            return base.iClient.SetEntryInHashIfNotExists(hasdid, key, value);
        }

        /// <summary>
        /// 存储对象T到hash集合中
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        //public void StoreAsHash<T>(T t)
        //{
        //    base.iClient.StoreAsHash<T>(t);
        //}
        #endregion

        #region 获取

        /// <summary>
        /// 获取对象中ID为id的数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        //public T GetFromHash<T>(object id)
        //{
        //    return base.iClient.GetFromHash<T>(id);
        //}

        /// <summary>
        /// 根据hashid获取哈希表中所有的key/value集合
        /// </summary>
        /// <param name="hashid"></param>
        /// <returns></returns>
        public Dictionary<string, string> GetAllEntriesFromHash(string hashid)
        {
            return base.iClient.GetAllEntriesFromHash(hashid);
        }

        /// <summary>
        /// 获取hashid数据集中的数据总数
        /// </summary>
        /// <param name="hashid"></param>
        /// <returns></returns>
        public long GetHashCount(string hashid)
        {
            return base.iClient.GetHashCount(hashid);
        }

        /// <summary>
        /// 根据hashid获取哈希表中所有keys的集合
        /// </summary>
        /// <param name="hashid"></param>
        /// <returns></returns>
        public List<string> GetHashKeys(string hashid)
        {
            return base.iClient.GetHashKeys(hashid);
        }

        /// <summary>
        ///  根据hashid获取哈希表中所有values的集合
        /// </summary>
        /// <param name="hashid"></param>
        /// <returns></returns>
        public List<string> GetHashValues(string hashid)
        {
            return base.iClient.GetHashValues(hashid);
        }

        /// <summary>
        /// 根据hashid和key获取value的值
        /// </summary>
        /// <param name="hashid"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public string GetValueFromHash(string hashid, string key)
        {
            return base.iClient.GetValueFromHash(hashid, key);
        }

        /// <summary>
        /// 根据hashid，获取多个keys的values
        /// </summary>
        /// <param name="hashid"></param>
        /// <param name="keys"></param>
        /// <returns></returns>
        public List<string> GetValuesFromHash(string hashid, string[] keys)
        {
            return base.iClient.GetValuesFromHash(hashid, keys);
        }
        #endregion

        #region 删除

        /// <summary>
        /// 根据hashid和key删除
        /// </summary>
        /// <param name="hashid"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool RemoveEntryFromHash(string hashid, string key)
        {
            return base.iClient.RemoveEntryFromHash(hashid, key);
        }

        #endregion

        #region 其他

        /// <summary>
        /// 根据hashid和key判断是否存在
        /// </summary>
        /// <param name="hashid"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool HashContainsEntry(string hashid, string key)
        {
            return base.iClient.HashContainsEntry(hashid, key);
        }


        #endregion
    }
}
