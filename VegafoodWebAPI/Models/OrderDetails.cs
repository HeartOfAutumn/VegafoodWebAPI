using System;
using System.Collections.Generic;

namespace VegafoodWebAPI.Models
{
    public partial class OrderDetails
    {
        public int OrderId { get; set; }
        public int MenuId { get; set; }
        public short? Quantity { get; set; }
        public float? Discount { get; set; }
        public decimal? UnitPrice { get; set; }

        public virtual Menus Menu { get; set; }
        public virtual Orders Order { get; set; }
    }
}
