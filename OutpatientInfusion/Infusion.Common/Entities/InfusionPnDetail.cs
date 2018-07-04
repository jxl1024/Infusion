using System;
using System.Collections.Generic;
using System.Text;

namespace Infusion.Common.Entities
{
    public class InfusionPnDetail :BaseEntity
    {
        public int IpdId { get; set; }

        public int? InfusionId { get; set; }

        public string PrescriptionNo { get; set; }

        public string SeqNo { get; set; }

        public string DrugCode { get; set; }

        public string DrugName { get; set; }

        public string DrugStandard { get; set; }

        public string DrugDepartmentName { get; set; }

        public bool DrugNum { get; set; }

        public bool DrugDose { get; set; }

        public string DrugDoseUnit { get; set; }

        public bool GroupId { get; set; }

        public bool RecordStatus { get; set; }

        public string DoctorNo { get; set; }

        public DateTime? PrescriptionDate { get; set; }

        public string FrequencyNo { get; set; }

        public string UsageNo { get; set; }

        public DateTime? KeepTime { get; set; }

        public bool? TotQty { get; set; }

        public bool? ExecQty { get; set; }

        public bool? TotComposeQty { get; set; }

        public string Advise { get; set; }

        public bool? IsCharge { get; set; }

        public int? ChargeNo { get; set; }

        public bool? IsSkinTest { get; set; }
        public string SkinTestResult { get; set; }
    }
}
