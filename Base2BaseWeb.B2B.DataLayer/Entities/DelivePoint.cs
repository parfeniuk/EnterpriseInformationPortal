using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class DelivePoint
    {
        public DelivePoint()
        {
            RoutePoint = new HashSet<RoutePoint>();
        }

        public int DelivePointNumber { get; set; }
        public int? PointNumber { get; set; }
        public string DeliveAddress { get; set; }
        public string District { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public string DelivePointName { get; set; }

        public Point PointNumberNavigation { get; set; }
        public ICollection<RoutePoint> RoutePoint { get; set; }
    }
}
