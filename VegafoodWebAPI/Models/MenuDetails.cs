using System;
using System.Collections.Generic;

namespace VegafoodWebAPI.Models
{
    public partial class MenuDetails
    {
        public int ProductId { get; set; }
        public int MenuId { get; set; }
        public short? Quantity { get; set; }

        public virtual Menus Menu { get; set; }
        public virtual Products Product { get; set; }
    }
}
