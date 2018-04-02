using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class OrderExt
    {
        public int OrderExtNumber { get; set; }
        public DateTime? StartDateSales { get; set; }
        public DateTime? EndDateSales { get; set; }
        public DateTime? StartDatePurchase { get; set; }
        public DateTime? EndDatePurchase { get; set; }
        public int? CalcAlg { get; set; }
        public double? SpareFactor { get; set; }
        public int? RoundCombo { get; set; }
        public bool? OnlyThisSupplier { get; set; }
        public int? SaleAnalasys { get; set; }
        public bool? GoodsTransferInclude { get; set; }

        public Nakl OrderExtNumberNavigation { get; set; }
    }
}
