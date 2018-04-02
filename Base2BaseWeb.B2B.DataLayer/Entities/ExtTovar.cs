using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class ExtTovar
    {
        public int ExtTovarNumber { get; set; }
        public string ExtTovarName { get; set; }
        public int TovarNumber { get; set; }
        public int PointNumber { get; set; }
        public int ExtKatNumber { get; set; }
        public bool PriceOrNakl { get; set; }

        public Point PointNumberNavigation { get; set; }
        public Tovar TovarNumberNavigation { get; set; }
    }
}
