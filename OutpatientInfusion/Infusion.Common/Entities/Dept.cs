using System;
using System.Collections.Generic;
using System.Text;

namespace Infusion.Common.Entities
{
   public class Dept :BaseEntity
    {
        public int DeptId { get; set; }

        public string DeptNo { get; set; }

        public string DeptName { get; set; }

        public string SpellCode { get; set; }

        public string WbCode { get; set; }

        public bool IsDel { get; set; }
    }
}
