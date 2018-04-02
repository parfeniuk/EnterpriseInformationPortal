using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class PriceShields
    {
        public int PriceShieldsId { get; set; }
        public int? TovarNumber { get; set; }
        public int? NaklNumber { get; set; }
        public double? CenaRozn { get; set; }
        public double? CenaDol { get; set; }

        public Nakl NaklNumberNavigation { get; set; }
        public Tovar TovarNumberNavigation { get; set; }
    }
}
