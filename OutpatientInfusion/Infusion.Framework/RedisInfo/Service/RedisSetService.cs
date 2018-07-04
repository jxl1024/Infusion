using Infusion.Framework.RedisInfo.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infusion.Framework.RedisInfo.Service
{
    public class RedisSetService : RedisBase
    {
        #region 添加

        /// <summary>
        /// key集合中添加value值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Add(string key, string value)
        {
            base.iClient.AddItemToSet(key, value);
        }

        /// <summary>
        /// key集合中添加list集合
        /// </summary>
        /// <param name="key"></param>
        /// <param name="list"></param>
        public void Add(string key, List<string> list)
        {
            base.iClient.AddRangeToSet(key, list);
        }


        public void Add<T>(string key, T value)
        {
            base.iClient.Add<T>(key, value);
        }

        public void Set<T>(string key, T value)
        {
            base.iClient.Set<T>(key, value);
        }
        #endregion

        #region 获取


        public T Get<T>(string key)
        {
            return base.iClient.Get<T>(key);
        }
        /// <summary>
        /// 获取key集合中的一个随机值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string GetRandomItemFromSet(string key)
        {
            return base.iClient.GetRandomItemFromSet(key);
        }

        /// <summary>
        /// 获取key集合值的数量
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public long GetSetCount(string key)
        {
            return base.iClient.GetSetCount(key);
        }

        /// <summary>
        /// 获取key集合所有的值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public HashSet<string> GetAllItemsFromSet(string key)
        {
            return base.iClient.GetAllItemsFromSet(key);
        }
        #endregion

        #region 删除

        /// <summary>
        /// 随机删除key集合中的一个值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string RandomRemoveItemFromSet(string key)
        {
            return base.iClient.PopItemFromSet(key);
        }

        /// <summary>
        /// 删除key集合中的一个value值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void RemoveItemFromSet(string key, string value)
        {
            base.iClient.RemoveItemFromSet(key, value);
        }

        /// <summary>
        /// 根据key值删除对应的value值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool RemoveValueByKey(string key)
        {
            return iClient.Remove(key);
        }
        #endregion

        #region 其他

        /// <summary>
        /// 从fromkey集合中移除值为value的值，并把value添加到tokey集合中
        /// </summary>
        /// <param name="fromkey"></param>
        /// <param name="tokey"></param>
        /// <param name="value"></param>
        public void MoveBetweenSets(string fromkey, string tokey, string value)
        {
            base.iClient.MoveBetweenSets(fromkey, tokey, value);
        }

        /// <summary>
        /// 返回keys多个集合中的并集，返回HashSet
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        public HashSet<string> GetUnionFromSets(params string[] keys)
        {
            return base.iClient.GetUnionFromSets(keys);
        }

        /// <summary>
        /// 返回keys多个集合中的交集，返回HashSet
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        public HashSet<string> GetIntersectFromSets(params string[] keys)
        {
            return base.iClient.GetIntersectFromSets(keys);
        }

        /// <summary>
        /// 返回keys多个集合中的差集，返回HashSet
        /// </summary>
        /// <param name="fromkey">原集合</param>
        /// <param name="keys">其他集合</param>
        /// <returns>出现在原集合中，但不包含在其他集合中的value值</returns>
        public HashSet<string> GetDifferencesFromSet(string fromkey, params string[] keys)
        {
            return base.iClient.GetDifferencesFromSet(fromkey, keys);
        }

        /// <summary>
        ///  keys多个集合中的并集，放入newkey集合中
        /// </summary>
        /// <param name="newkey"></param>
        /// <param name="keys"></param>
        public void StoreUnionFromSets(string newkey, string[] keys)
        {
            base.iClient.StoreUnionFromSets(newkey, keys);
        }

        /// <summary>
        /// 把fromkey集合中的数据与keys集合中的数据对比，fromkey集合中不存在keys集合中的value值，则把这些不存在的数据放入newkey集合中
        /// </summary>
        /// <param name="newkey"></param>
        /// <param name="fromkey"></param>
        /// <param name="keys"></param>
        public void StoreDifferencesFromSet(string newkey, string fromkey, string[] keys)
        {
            base.iClient.StoreDifferencesFromSet(newkey, fromkey, keys);
        }


        public bool ContainsKey(string key)
        {
            return base.iClient.ContainsKey(key);
        }
        #endregion

        //public void ChangeCurrentDb()
        //{

        //    base.iClient.ChangeDb();
        //}
    }
}
