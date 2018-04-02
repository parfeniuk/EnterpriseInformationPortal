using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class DiscountRules
    {
        public int DiscountRulesNumber { get; set; }
        public int? PointNumber { get; set; }
        public double? SalesSum { get; set; }
        public double? DiscountPercent { get; set; }
        public int? SalesPeriod { get; set; }
        public double? FactSaleSum { get; set; }
        public double? FactSaleSumDol { get; set; }

        public Point PointNumberNavigation { get; set; }
    }
}
