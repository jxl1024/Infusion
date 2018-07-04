using System;
using System.Collections.Generic;
using System.Text;

namespace Infusion.Common.Entities
{
    public class Pharmacy:BaseEntity
    {
        public int Id { get; set; }

        public int RoomId { get; set; }

        public string PharmacyCode { get; set; }

        public string PharmacyName { get; set; }

        public bool Isdel { get; set; }

        public InfusionRoom InfusionRoom { get; set; }
    }
}
