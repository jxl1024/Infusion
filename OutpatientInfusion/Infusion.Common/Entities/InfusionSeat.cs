using System;
using System.Collections.Generic;
using System.Text;

namespace Infusion.Common.Entities
{
    public class InfusionSeat:BaseEntity
    {
        public int SeatId { get; set; }

        public int? InfusionId { get; set; }

        public int? RoomId { get; set; }

        public bool? Plus { get; set; }

        public bool? Used { get; set; }

        public bool? Valid { get; set; }

        public bool? Child { get; set; }

        public bool? Special { get; set; }

        public bool IsDel { get; set; }
    }
}
