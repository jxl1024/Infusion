using System;
using System.Collections.Generic;
using System.Text;

namespace Infusion.Common.Entities
{
    public class InfusionPrintSet:BaseEntity
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 打印机Code
        /// </summary>
        public string PrintSetCode { get; set; }

        /// <summary>
        /// 打印机名称
        /// </summary>
        public string PrintSetName { get; set; }

        /// <summary>
        /// 是否有效 0有效 1无效
        /// </summary>
        public bool IsDel { get; set; }
    }
}
