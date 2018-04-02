using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class JrnOpl
    {
        public int JrnOplNumber { get; set; }
        public int? Nakl1Number { get; set; }
        public int? Nakl2Number { get; set; }
        public double? SumOpl { get; set; }
        public double? SumOplDol { get; set; }
        public DateTime? DateOpl { get; set; }
        public int? NaklType { get; set; }

        public Nakl Nakl1NumberNavigation { get; set; }
        public Nakl Nakl2NumberNavigation { get; set; }
    }
}
