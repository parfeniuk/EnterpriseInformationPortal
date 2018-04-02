using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class RoutePoint
    {
        public int RoutePointNumber { get; set; }
        public int? RouteNumber { get; set; }
        public int? DelivePointNumber { get; set; }
        public double? UpPointDistance { get; set; }
        public double? ReturnDistance { get; set; }
        public int? SortNumber { get; set; }

        public DelivePoint DelivePointNumberNavigation { get; set; }
        public Route RouteNumberNavigation { get; set; }
    }
}
