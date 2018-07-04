using System;
using System.Collections.Generic;
using System.Text;

namespace Infusion.Common.Entities
{
    /// <summary>
    /// 输液室对应的科室
    /// </summary>
    public class InfusionDept:BaseEntity
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int RdId { get; set; }

        /// <summary>
        ///  输液室Id
        /// </summary>
        public int RoomId { get; set; }

        /// <summary>
        /// 科室代码
        /// </summary>
        public string DeptNo { get; set; }

        /// <summary>
        /// 科室名称
        /// </summary>
        public string DeptName { get; set; }

        /// <summary>
        /// 是否有效
        /// </summary>
        public bool IsDel { get; set; }

        public InfusionRoom InfusionRoom { get; set; }
    }
}
