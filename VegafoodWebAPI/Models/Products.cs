using System;
using System.Collections.Generic;

namespace VegafoodWebAPI.Models
{
    public partial class Products
    {
        public Products()
        {
            MenuDetails = new HashSet<MenuDetails>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int? CategoryId { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsOnOrder { get; set; }
        public bool? Discontinued { get; set; }
        public int? Calories { get; set; }
        public float? Protein { get; set; }
        public float? Carb { get; set; }
        public float? Fat { get; set; }
        public string ProductDescription { get; set; }
        public string Images { get; set; }

        public virtual Categories Category { get; set; }
        public virtual ICollection<MenuDetails> MenuDetails { get; set; }
    }
}
