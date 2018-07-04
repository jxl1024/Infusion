using System;
using System.Collections.Generic;
using System.Text;

namespace Infusion.Common.Entities
{
    public class InfusionBadnessEvent:BaseEntity
    {
        public int BnId { get; set; }

        /// <summary>
        ///  输液序号
        /// </summary>
        public int InfusionId { get; set; }

        /// <summary>
        /// 记录编号
        /// </summary>
        public string RecorderId { get; set; }

        /// <summary>
        /// 记录名称
        /// </summary>
        public string RecorderName { get; set; }
    }
}
