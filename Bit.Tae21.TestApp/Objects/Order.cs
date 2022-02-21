using System;
using System.Collections.Generic;

namespace Bit.Tae21.TestApp.Objects
{
    public class Order
    {
        public int Id { get; set; }

        public decimal SummaryAmount { get; set; }

        public DateTime CreatedAt { get; set; }

        public List<OrderPosition> Positions { get; set; } = new List<OrderPosition>();
    }
}
