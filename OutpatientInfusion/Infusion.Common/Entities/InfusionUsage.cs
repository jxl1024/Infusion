using System;
using System.Collections.Generic;
using System.Text;

namespace Infusion.Common.Entities
{
    /// <summary>
    /// 对应输液项目表(药品用法) 和输液室关系是一对多 一个输液室可以对应多个药品用法
    /// </summary>
    public class InfusionUsage :BaseEntity
    {
        /// <summary>
        /// 输液项目序号
        /// </summary>
        public int ItemId { get; set; }

        /// <summary>
        /// 输液室Id
        /// </summary>
        public int RoomId { get; set; }

        /// <summary>
        /// 用法代码
        /// </summary>
        public string UsageNo { get; set; }

        /// <summary>
        /// 用法名称
        /// </summary>
        public string UsageName { get; set; }

        /// <summary>
        /// 是否有效
        /// </summary>
        public bool IsDel { get; set; }

        public InfusionRoom InfusionRoom { get; set; }

    }
}
