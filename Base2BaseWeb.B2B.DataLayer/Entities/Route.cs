using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class Route
    {
        public Route()
        {
            RouteAgent = new HashSet<RouteAgent>();
            RouteList = new HashSet<RouteList>();
            RoutePoint = new HashSet<RoutePoint>();
        }

        public int RouteNumber { get; set; }
        public double? Distance { get; set; }
        public string Comment { get; set; }

        public ICollection<RouteAgent> RouteAgent { get; set; }
        public ICollection<RouteList> RouteList { get; set; }
        public ICollection<RoutePoint> RoutePoint { get; set; }
    }
}
