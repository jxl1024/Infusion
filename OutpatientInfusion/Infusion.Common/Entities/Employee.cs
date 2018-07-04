using System;
using System.Collections.Generic;
using System.Text;

namespace Infusion.Common.Entities
{
    public class Employee :BaseEntity
    {
        public int EmpId { get; set; }

        public string EmpNo { get; set; }

        public string EmpName { get; set; }
        public string Password { get; set; }

        public string Sex { get; set; }
        public string IdNo { get; set; }
        public DateTime? Birthday { get; set; }

        public string EmpType { get; set; }

        public string SpellCode { get; set; }

        public string WbCode { get; set; }

        public bool IsDel { get; set; }
    }
}
