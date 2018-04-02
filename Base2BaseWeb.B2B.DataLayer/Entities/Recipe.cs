using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class Recipe
    {
        public int RecipeNumber { get; set; }
        public int? TovarNumber { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool Closed { get; set; }
        public string Description { get; set; }
        public double? Size { get; set; }
        public double? ExitProd { get; set; }
        public bool Active { get; set; }
        public double? SelfCost { get; set; }
        public double? SelfCostDol { get; set; }

        public Tovar TovarNumberNavigation { get; set; }
    }
}
