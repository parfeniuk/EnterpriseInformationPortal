using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class OrdersRedirection
    {
        public int OrdersRedirectionNumber { get; set; }
        public int? RestaurantNumber { get; set; }
        public int? PointNumber { get; set; }
        public int? TovarNumber { get; set; }

        public Point PointNumberNavigation { get; set; }
        public Point RestaurantNumberNavigation { get; set; }
        public Tovar TovarNumberNavigation { get; set; }
    }
}
