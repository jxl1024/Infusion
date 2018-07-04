using System;
using System.Collections.Generic;
using System.Text;

namespace Infusion.Common.Entities
{
    /// <summary>
    /// 输液病人表
    /// </summary>
    public class InfusionPatient:BaseEntity
    {
        public int InfusionId { get; set; }

        public int? RoomId { get; set; }

        public int? SeatId { get; set; }


        public string QueueNo { get; set; }


        //public string PatientId { get; set; }


        public string ChartNo { get; set; }

        public string VisitNo { get; set; }


        public string PtName { get; set; }


        public string Sex { get; set; }


        public int Age { get; set; }

        public DateTime? BirthDay { get; set; }

        public string CardNo { get; set; }

        public DateTime? CheckInTime { get; set; }

        public string Checkiner { get; set; }

        public string Auditor { get; set; }

        public DateTime? AuditTime { get; set; }

        public DateTime? ConfigTime { get; set; }

        public string Configer { get; set; }

        public DateTime? StartTime { get; set; }

        public string Starter { get; set; }

        public DateTime? EndTime { get; set; }

        public string Ender { get; set; }

        public bool? Status { get; set; }

        public DateTime? CancelTime { get; set; }

        public string Canceler { get; set; }

        public string DeptNo { get; set; }

        public bool? Child { get; set; }

        public bool? Emg { get; set; }

        public string PrescriptionNo { get; set; }

        public bool? SpecialDrug { get; set; }

        public bool? DischargeMedication { get; set; }

        public string MedUsageNo { get; set; }

        public string Receipt { get; set; }
    }
}
