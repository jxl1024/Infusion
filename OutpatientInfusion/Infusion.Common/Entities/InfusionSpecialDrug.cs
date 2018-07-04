using System;
using System.Collections.Generic;
using System.Text;

namespace Infusion.Common.Entities
{
    public class InfusionSpecialDrug :BaseEntity
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int IsdId { get; set; }

        /// <summary>
        /// 产地
        /// </summary>
        public string OriginPlace { get; set; }

        /// <summary>
        /// 药品代码
        /// </summary>
        public string DrugCode { get; set; }

        /// <summary>
        /// 药品名称
        /// </summary>
        public string DrugName { get; set; }

        /// <summary>
        /// 药品规格
        /// </summary>
        public string DrugSpec { get; set; }

        /// <summary>
        /// 设置显示颜色值
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// 是否有效
        /// </summary>
        public bool IsDel { get; set; }
    }
}
