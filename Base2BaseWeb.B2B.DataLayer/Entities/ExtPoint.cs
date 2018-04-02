using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class ExtPoint
    {
        public int ExtPointNumber { get; set; }
        public string ExtPointName { get; set; }
        public int PointNumber { get; set; }

        public Point PointNumberNavigation { get; set; }
    }
}
