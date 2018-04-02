using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class AccTransChema
    {
        public int AccTransChemaNumber { get; set; }
        public int? ArticlNumber { get; set; }
        public int? Account1Number { get; set; }
        public int? Account2Number { get; set; }
        public double? Percent { get; set; }
        public string Comment { get; set; }

        public Articl ArticlNumberNavigation { get; set; }
    }
}
