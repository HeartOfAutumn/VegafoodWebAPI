using System;
using System.Collections.Generic;

namespace VegafoodWebAPI.Models
{
    public partial class Menus
    {
        public Menus()
        {
            MenuDetails = new HashSet<MenuDetails>();
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsOnOrder { get; set; }
        public bool? Discontinued { get; set; }
        public string MenuDescription { get; set; }
        public string Images { get; set; }

        public virtual ICollection<MenuDetails> MenuDetails { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
