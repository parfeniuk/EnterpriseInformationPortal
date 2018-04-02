using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class RecipeList
    {
        public int RecipeListNumber { get; set; }
        public int? RecipeNumber { get; set; }
        public int? TovarNumber { get; set; }
        public double? Kol { get; set; }
        public string Description { get; set; }
        public double? SelfCostPercent { get; set; }
    }
}
