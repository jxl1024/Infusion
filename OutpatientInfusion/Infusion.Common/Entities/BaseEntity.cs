using System;
using System.Collections.Generic;
using System.Text;

namespace Infusion.Common.Entities                                                                                                                                                                       
{
    public class BaseEntity 
    {
        /// <summary>
        /// 更新人
        /// </summary>
        public string UpdateUser { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Memo { get; set; }
    }
}
