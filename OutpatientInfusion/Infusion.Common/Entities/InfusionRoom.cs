using System;
using System.Collections.Generic;
using System.Text;

namespace Infusion.Common.Entities
{
    /// <summary>
    /// 对应数据库输液室表
    /// </summary>
    public class InfusionRoom  :BaseEntity
    {
        public int RoomId { get; set; }

        public string RoomCode { get; set; }

        public string RoomName { get; set; }

        //public string DrugUsageCode { get; set; }

        public decimal? PrescriptionDays { get; set; }

        //public string PharmacyCode { get; set; }

        public bool? Mode { get; set; }

        public bool IsDel { get; set; }

        /// <summary>
        /// 科室
        /// </summary>
        public ICollection<InfusionDept> InfusionDepts { get; set; }

        /// <summary>
        ///  用法
        /// </summary>
        public ICollection<InfusionUsage> InfusionUsages { get; set; }

        public ICollection<Pharmacy> Pharmacys { get; set; }
    }
}
