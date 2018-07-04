using Infusion.Framework.RedisInfo.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infusion.Framework.RedisInfo.Service
{
    public class RedisZSetService : RedisBase
    {
        #region 添加

        /// <summary>
        /// 添加key/value，默认分数是从1.多*10的9次方以此递增的，自带自增效果
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool AddItemToSortedSet(string key, string value)
        {
            return base.iClient.AddItemToSortedSet(key, value);
        }

        /// <summary>
        /// 添加key/value,并设置value的score
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="score"></param>
        /// <returns></returns>
        public bool AddItemToSortedSet(string key, string value, double score)
        {
            return base.iClient.AddItemToSortedSet(key, value, score);
        }

        /// <summary>
        /// 为key添加values集合，values集合中每个value的分数设置为score
        /// </summary>
        /// <param name="key"></param>
        /// <param name="values"></param>
        /// <param name="score">double类型</param>
        /// <returns></returns>
        public bool AddRangeToSortedSet(string key, List<string> values, double score)
        {
            return base.iClient.AddRangeToSortedSet(key, values, score);
        }

        /// <summary>
        ///  为key添加values集合，values集合中每个value的分数设置为score
        /// </summary>
        /// <param name="key"></param>
        /// <param name="values"></param>
        /// <param name="score">long类型</param>
        /// <returns></returns>
        public bool AddRangeToSortedSet(string key, List<string> values, long score)
        {
            return base.iClient.AddRangeToSortedSet(key, values, score);
        }
        #endregion

        #region 获取

        /// <summary>
        /// 获取key的所有集合，升序输出
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public List<string> GetAllItemsFromSortedSet(string key)
        {
            return base.iClient.GetAllItemsFromSortedSet(key);
        }

        /// <summary>
        /// 获取key的所有集合，降序输出
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public List<string> GetAllItemsFromSortedSetDesc(string key)
        {
            return base.iClient.GetAllItemsFromSortedSetDesc(key);
        }

        /// <summary>
        /// 根据key获取所有集合，带有分数
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public IDictionary<string, double> GetAllWithScoresFromSortedSet(string key)
        {
            return base.iClient.GetAllWithScoresFromSortedSet(key);
        }

        /// <summary>
        /// 获取升序排序的key对应的value的索引值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public long GetItemIndexInSortedSet(string key, string value)
        {
            return base.iClient.GetItemIndexInSortedSet(key, value);
        }

        /// <summary>
        /// 获取降序排序的key的value的索引值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public long GetItemIndexInSortedSetDesc(string key, string value)
        {
            return base.iClient.GetItemIndexInSortedSetDesc(key, value);
        }

        /// <summary>
        /// 根据key，获取value的分数
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public double get(string key, string value)
        {
            return base.iClient.GetItemScoreInSortedSet(key, value);
        }

        /// <summary>
        /// 获取key所有集合的数据总数
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public long GetSortedSetCount(string key)
        {
            return base.iClient.GetSortedSetCount(key);
        }

        /// <summary>
        /// 获取key集合中分数从fromScore到toScore的数据总数
        /// </summary>
        /// <param name="key"></param>
        /// <param name="fromScore"></param>
        /// <param name="toScore"></param>
        /// <returns></returns>
        //public long GetSortedSetCount(string key, double fromScore, double toScore)
        //{
        //    return base.iClient.GetSortedSetCount(key, fromScore, toScore);
        //}

        /// <summary>
        /// 获取key集合中分数从fromScore到toScore的数据总数
        /// </summary>
        /// <param name="key"></param>
        /// <param name="fromScore"></param>
        /// <param name="toScore"></param>
        /// <returns></returns>
        //public long GetSortedSetCount(string key, long fromScore, long toScore)
        //{
        //    return base.iClient.GetSortedSetCount(key, fromScore, toScore);
        //}

        /// <summary>
        /// 获取key集合中分数从fromScore到toScore的数据总数
        /// </summary>
        /// <param name="key"></param>
        /// <param name="fromScore"></param>
        /// <param name="toScore"></param>
        /// <returns></returns>
        //public long GetSortedSetCount(string key, string fromScore, string toScore)
        //{
        //    return base.iClient.GetSortedSetCount(key, fromScore, toScore);
        //}

        /// <summary>
        /// 获取key集合中分数从fromScore到toScore之间从高到低排序的数据
        /// </summary>
        /// <param name="key"></param>
        /// <param name="fromScore"></param>
        /// <param name="toScore"></param>
        /// <returns></returns>
        public List<string> GetRangeFromSortedSetByHighestScore(string key, double fromScore, double toScore)
        {
            return base.iClient.GetRangeFromSortedSetByHighestScore(key, fromScore, toScore);
        }

        /// <summary>
        /// 获取key集合中分数从fromScore到toScore之间从高到低排序的数据
        /// </summary>
        /// <param name="key"></param>
        /// <param name="fromScore"></param>
        /// <param name="toScore"></param>
        /// <returns></returns>
        public List<string> GetRangeFromSortedSetByHighestScore(string key, long fromScore, long toScore)
        {
            return base.iClient.GetRangeFromSortedSetByHighestScore(key, fromScore, toScore);
        }

        /// <summary>
        /// 获取key集合中分数从fromScore到toScore之间从高到低排序的数据
        /// </summary>
        /// <param name="key"></param>
        /// <param name="fromScore"></param>
        /// <param name="toScore"></param>
        /// <returns></returns>
        public List<string> GetRangeFromSortedSetByHighestScore(string key, string fromScore, string toScore)
        {
            return base.iClient.GetRangeFromSortedSetByHighestScore(key, fromScore, toScore);
        }

        /// <summary>
        /// 获取key集合中分数从fromScore到toScore之间从高到低排序的数据,并分页
        /// </summary>
        /// <param name="key"></param>
        /// <param name="fromScore"></param>
        /// <param name="toScore"></param>
        /// <param name="skip">第几页</param>
        /// <param name="take">每页行数</param>
        /// <returns></returns>
        public List<string> GetRangeFromSortedSetByHighestScore(string key, double fromScore, double toScore, int? skip, int? take)
        {
            return base.iClient.GetRangeFromSortedSetByHighestScore(key, fromScore, toScore, skip, take);
        }

        /// <summary>
        /// 获取key集合中分数从fromScore到toScore之间从高到低排序的数据,并分页
        /// </summary>
        /// <param name="key"></param>
        /// <param name="fromScore"></param>
        /// <param name="toScore"></param>
        /// <param name="skip">第几页</param>
        /// <param name="take">每页行数</param>
        /// <returns></returns>
        public List<string> GetRangeFromSortedSetByHighestScore(string key, long fromScore, long toScore, int? skip, int? take)
        {
            return base.iClient.GetRangeFromSortedSetByHighestScore(key, fromScore, toScore, skip, take);
        }

        /// <summary>
        /// 获取key集合中分数从fromScore到toScore之间从高到低排序的数据,并分页
        /// </summary>
        /// <param name="key"></param>
        /// <param name="fromScore"></param>
        /// <param name="toScore"></param>
        /// <param name="skip">第几页</param>
        /// <param name="take">每页行数</param>
        /// <returns></returns>
        public List<string> GetRangeFromSortedSetByHighestScore(string key, string fromScore, string toScore, int? skip, int? take)
        {
            return base.iClient.GetRangeFromSortedSetByHighestScore(key, fromScore, toScore, skip, take);
        }

        /// <summary>
        /// 获取key集合中分数从fromScore到toScore之间从低到高排序的数据
        /// </summary>
        /// <param name="key"></param>
        /// <param name="fromScore"></param>
        /// <param name="toScore"></param>
        /// <returns></returns>
        public List<string> GetRangeFromSortedSetByLowestScore(string key, double fromScore, double toScore)
        {
            return base.iClient.GetRangeFromSortedSetByLowestScore(key, fromScore, toScore);
        }

        /// <summary>
        /// 获取key集合中分数从fromScore到toScore之间从低到高排序的数据
        /// </summary>
        /// <param name="key"></param>
        /// <param name="fromScore"></param>
        /// <param name="toScore"></param>
        /// <returns></returns>
        public List<string> GetRangeFromSortedSetByLowestScore(string key, long fromScore, long toScore)
        {
            return base.iClient.GetRangeFromSortedSetByLowestScore(key, fromScore, toScore);
        }

        /// <summary>
        /// 获取key集合中分数从fromScore到toScore之间从低到高排序的数据
        /// </summary>
        /// <param name="key"></param>
        /// <param name="fromScore"></param>
        /// <param name="toScore"></param>
        /// <returns></returns>
        public List<string> GetRangeFromSortedSetByLowestScore(string key, string fromScore, string toScore)
        {
            return base.iClient.GetRangeFromSortedSetByLowestScore(key, fromScore, toScore);
        }

        /// <summary>
        /// 获取key集合中分数从fromScore到toScore之间从低到高排序的数据,并分页
        /// </summary>
        /// <param name="key"></param>
        /// <param name="fromScore"></param>
        /// <param name="toScore"></param>
        /// <param name="skip">第几页</param>
        /// <param name="take">每页行数</param>
        /// <returns></returns>
        public List<string> GetRangeFromSortedSetByLowestScore(string key, double fromScore, double toScore, int? skip, int? take)
        {
            return base.iClient.GetRangeFromSortedSetByLowestScore(key, fromScore, toScore, skip, take);
        }

        /// <summary>
        /// 获取key集合中分数从fromScore到toScore之间从低到高排序的数据,并分页
        /// </summary>
        /// <param name="key"></param>
        /// <param name="fromScore"></param>
        /// <param name="toScore"></param>
        /// <param name="skip">第几页</param>
        /// <param name="take">每页行数</param>
        /// <returns></returns>
        public List<string> GetRangeFromSortedSetByLowestScore(string key, long fromScore, long toScore, int? skip, int? take)
        {
            return base.iClient.GetRangeFromSortedSetByLowestScore(key, fromScore, toScore, skip, take);
        }

        /// <summary>
        /// 获取key集合中分数从fromScore到toScore之间从低到高排序的数据,并分页
        /// </summary>
        /// <param name="key"></param>
        /// <param name="fromScore"></param>
        /// <param name="toScore"></param>
        /// <param name="skip">第几页</param>
        /// <param name="take">每页行数</param>
        /// <returns></returns>
        public List<string> GetRangeFromSortedSetByLowestScore(string key, string fromScore, string toScore, int? skip, int? take)
        {
            return base.iClient.GetRangeFromSortedSetByLowestScore(key, fromScore, toScore, skip, take);
        }

        /// <summary>
        /// 获取key集合中分数从fromScore到toScore之间带有分数的从高到低排序的字典集合
        /// </summary>
        /// <param name="key"></param>
        /// <param name="fromScore"></param>
        /// <param name="toScore"></param>
        /// <returns></returns>
        public IDictionary<string, double> GetRangeWithScoresFromSortedSetByHighestScore(string key, double fromScore, double toScore)
        {
            return base.iClient.GetRangeWithScoresFromSortedSetByHighestScore(key, fromScore, toScore);
        }

        /// <summary>
        /// 获取key集合中分数从fromScore到toScore之间带有分数的从高到低排序的字典集合
        /// </summary>
        /// <param name="key"></param>
        /// <param name="fromScore"></param>
        /// <param name="toScore"></param>
        /// <returns></returns>
        public IDictionary<string, double> GetRangeWithScoresFromSortedSetByHighestScore(string key, long fromScore, long toScore)
        {
            return base.iClient.GetRangeWithScoresFromSortedSetByHighestScore(key, fromScore, toScore);
        }

        /// <summary>
        /// 获取key集合中分数从fromScore到toScore之间带有分数的从高到低排序的字典集合
        /// </summary>
        /// <param name="key"></param>
        /// <param name="fromScore"></param>
        /// <param name="toScore"></param>
        /// <returns></returns>
        public IDictionary<string, double> GetRangeWithScoresFromSortedSetByHighestScore(string key, string fromScore, string toScore)
        {
            return base.iClient.GetRangeWithScoresFromSortedSetByHighestScore(key, fromScore, toScore);
        }

        /// <summary>
        /// 获取key集合中分数从fromScore到toScore之间带有分数的从高到低排序的字典集合，并分页
        /// </summary>
        /// <param name="key"></param>
        /// <param name="fromScore"></param>
        /// <param name="toScore"></param>
        /// <param name="skip">第几页</param>
        /// <param name="take">每页的行数</param>
        /// <returns></returns>
        public IDictionary<string, double> GetRangeWithScoresFromSortedSetByHighestScore(string key, double fromScore, double toScore, int? skip, int? take)
        {
            return base.iClient.GetRangeWithScoresFromSortedSetByHighestScore(key, fromScore, toScore, skip, take);
        }

        /// <summary>
        /// 获取key集合中分数从fromScore到toScore之间带有分数的从高到低排序的字典集合，并分页
        /// </summary>
        /// <param name="key"></param>
        /// <param name="fromScore"></param>
        /// <param name="toScore"></param>
        /// <param name="skip">第几页</param>
        /// <param name="take">每页的行数</param>
        /// <returns></returns>
        public IDictionary<string, double> GetRangeWithScoresFromSortedSetByHighestScore(string key, long fromScore, long toScore, int? skip, int? take)
        {
            return base.iClient.GetRangeWithScoresFromSortedSetByHighestScore(key, fromScore, toScore, skip, take);
        }

        /// <summary>
        /// 获取key集合中分数从fromScore到toScore之间带有分数的从高到低排序的字典集合，并分页
        /// </summary>
        /// <param name="key"></param>
        /// <param name="fromScore"></param>
        /// <param name="toScore"></param>
        /// <param name="skip">第几页</param>
        /// <param name="take">每页的行数</param>
        /// <returns></returns>
        public IDictionary<string, double> GetRangeWithScoresFromSortedSetByHighestScore(string key, string fromScore, string toScore, int? skip, int? take)
        {
            return base.iClient.GetRangeWithScoresFromSortedSetByHighestScore(key, fromScore, toScore, skip, take);
        }

        /// <summary>
        /// 获取key集合中分数从fromScore到toScore之间带有分数的从低到高排序的字典集合
        /// </summary>
        /// <param name="key"></param>
        /// <param name="fromScore"></param>
        /// <param name="toScore"></param>
        /// <returns></returns>
        public IDictionary<string, double> GetRangeWithScoresFromSortedSetByLowestScore(string key, double fromScore, double toScore)
        {
            return base.iClient.GetRangeWithScoresFromSortedSetByLowestScore(key, fromScore, toScore);
        }

        /// <summary>
        /// 获取key集合中分数从fromScore到toScore之间带有分数的从低到高排序的字典集合
        /// </summary>
        /// <param name="key"></param>
        /// <param name="fromScore"></param>
        /// <param name="toScore"></param>
        /// <returns></returns>
        public IDictionary<string, double> GetRangeWithScoresFromSortedSetByLowestScore(string key, long fromScore, long toScore)
        {
            return base.iClient.GetRangeWithScoresFromSortedSetByLowestScore(key, fromScore, toScore);
        }

        /// <summary>
        /// 获取key集合中分数从fromScore到toScore之间带有分数的从低到高排序的字典集合
        /// </summary>
        /// <param name="key"></param>
        /// <param name="fromScore"></param>
        /// <param name="toScore"></param>
        /// <returns></returns>
        public IDictionary<string, double> GetRangeWithScoresFromSortedSetByLowestScore(string key, string fromScore, string toScore)
        {
            return base.iClient.GetRangeWithScoresFromSortedSetByLowestScore(key, fromScore, toScore);
        }

        /// <summary>
        /// 获取key集合中分数从fromScore到toScore之间带有分数的从低到高排序的字典集合
        /// </summary>
        /// <param name="key"></param>
        /// <param name="fromScore"></param>
        /// <param name="toScore"></param>
        /// <returns></returns>
        public IDictionary<string, double> GetRangeWithScoresFromSortedSetByLowestScore(string key, double fromScore, double toScore, int? skip, int? take)
        {
            return base.iClient.GetRangeWithScoresFromSortedSetByLowestScore(key, fromScore, toScore, skip, take);
        }

        /// <summary>
        /// 获取key集合中分数从fromScore到toScore之间带有分数的从低到高排序的字典集合
        /// </summary>
        /// <param name="key"></param>
        /// <param name="fromScore"></param>
        /// <param name="toScore"></param>
        /// <returns></returns>
        public IDictionary<string, double> GetRangeWithScoresFromSortedSetByLowestScore(string key, long fromScore, long toScore, int? skip, int? take)
        {
            return base.iClient.GetRangeWithScoresFromSortedSetByLowestScore(key, fromScore, toScore, skip, take);
        }

        /// <summary>
        /// 获取key集合中分数从fromScore到toScore之间带有分数的从低到高排序的字典集合
        /// </summary>
        /// <param name="key"></param>
        /// <param name="fromScore"></param>
        /// <param name="toScore"></param>
        /// <returns></returns>
        public IDictionary<string, double> GetRangeWithScoresFromSortedSetByLowestScore(string key, string fromScore, string toScore, int? skip, int? take)
        {
            return base.iClient.GetRangeWithScoresFromSortedSetByLowestScore(key, fromScore, toScore, skip, take);
        }

        /// <summary>
        /// 根据key获取下标从fronRank到toRank升序排序的集合
        /// </summary>
        /// <param name="key"></param>
        /// <param name="fronRank"></param>
        /// <param name="toRank"></param>
        /// <returns></returns>
        public List<string> GetRangeFromSortedSet(string key, int fronRank, int toRank)
        {
            return base.iClient.GetRangeFromSortedSet(key, fronRank, toRank);
        }

        /// <summary>
        /// 根据key获取下标从fronRank到toRank降序排序的集合
        /// </summary>
        /// <param name="key"></param>
        /// <param name="fronRank"></param>
        /// <param name="toRank"></param>
        /// <returns></returns>
        public List<string> GetRangeFromSortedSetDesc(string key, int fronRank, int toRank)
        {
            return base.iClient.GetRangeFromSortedSetDesc(key, fronRank, toRank);
        }

        /// <summary>
        /// 获取key集合数据，下标从fromRank到分数为toRank的数据，带分数
        /// </summary>
        /// <param name="key"></param>
        /// <param name="fromRank"></param>
        /// <param name="toRank"></param>
        /// <returns></returns>
        public IDictionary<string, double> GetRangeWithScoresFromSortedSet(string key, int fromRank, int toRank)
        {
            return base.iClient.GetRangeWithScoresFromSortedSet(key, fromRank, toRank);
        }

        /// <summary>
        /// 获取key集合倒叙排列数据，下标从fromRank到分数为toRank的数据，带分数
        /// </summary>
        /// <param name="key"></param>
        /// <param name="fromRank"></param>
        /// <param name="toRank"></param>
        /// <returns></returns>
        public IDictionary<string, double> GetRangeWithScoresFromSortedSetDesc(string key, int fromRank, int toRank)
        {
            return base.iClient.GetRangeWithScoresFromSortedSetDesc(key, fromRank, toRank);
        }
        #endregion

        #region 删除

        /// <summary>
        /// 删除key为value的数据
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool RemoveItemFromSortedSet(string key, string value)
        {
            return base.iClient.RemoveItemFromSortedSet(key, value);
        }

        /// <summary>
        /// 删除索引从minRank到maxRank的key集合数据
        /// </summary>
        /// <param name="key"></param>
        /// <param name="minRank"></param>
        /// <param name="maxRank"></param>
        /// <returns></returns>
        public long RemoveRangeFromSortedSet(string key, int minRank, int maxRank)
        {
            return base.iClient.RemoveRangeFromSortedSet(key, minRank, maxRank);
        }

        /// <summary>
        /// 删除分数从fromScore到toScore的key集合数据
        /// </summary>
        /// <param name="key"></param>
        /// <param name="fromScore"></param>
        /// <param name="toScore"></param>
        /// <returns></returns>
        public long RemoveRangeFromSortedSetByScore(string key, double fromScore, double toScore)
        {
            return base.iClient.RemoveRangeFromSortedSetByScore(key, fromScore, toScore);
        }

        /// <summary>
        /// 根据key删除集合中分数最大的数据
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string PopItemWithHighestScoreFromSortedSet(string key)
        {
            return base.iClient.PopItemWithHighestScoreFromSortedSet(key);
        }

        /// <summary>
        /// 根据key删除集合中分数最小的数据
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string PopItemWithLowestScoreFromSortedSet(string key)
        {
            return base.iClient.PopItemWithLowestScoreFromSortedSet(key);
        }
        #endregion

        #region 其他

        /// <summary>
        /// 判断key集合中是否存在value数据
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool SortedSetContainsItem(string key, string value)
        {
            return base.iClient.SortedSetContainsItem(key, value);
        }

        /// <summary>
        /// 为key集合值为value的数据的分数加scoreBy，返回相加后的分数
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="scoreBy"></param>
        /// <returns></returns>
        public double IncrementItemInSortedSet(string key, string value, double scoreBy)
        {
            return base.iClient.IncrementItemInSortedSet(key, value, scoreBy);
        }

        /// <summary>
        ///  获取keys多个集合的交集，并把交集添加的newkey集合中，返回交集数据的总数
        /// </summary>
        /// <param name="newKey"></param>
        /// <param name="keys"></param>
        /// <returns></returns>
        public long ss(string newKey, string[] keys)
        {
            return base.iClient.StoreIntersectFromSortedSets(newKey, keys);
        }

        /// <summary>
        /// 获取keys多个集合的并集，并把并集数据添加到newkey集合中，返回并集数据的总数
        /// </summary>
        public long StoreUnionFromSortedSets(string newkey, string[] keys)
        {
            return base.iClient.StoreUnionFromSortedSets(newkey, keys);
        }
        #endregion
    }
}
