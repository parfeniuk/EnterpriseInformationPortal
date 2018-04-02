using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class JrnRezerv
    {
        public int JrnRezervNumber { get; set; }
        public int? ListNumber { get; set; }
        public int? ListRezervNumber { get; set; }
        public double? KolRezerv { get; set; }

        public List ListNumberNavigation { get; set; }
        public List ListRezervNumberNavigation { get; set; }
    }
}
