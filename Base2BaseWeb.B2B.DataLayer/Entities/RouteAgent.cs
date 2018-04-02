using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class RouteAgent
    {
        public int RouteAgentNumber { get; set; }
        public int? RouteNumber { get; set; }
        public int? PointNumber { get; set; }
        public int? DayOfRoute { get; set; }
        public DateTime? DateOfRoute { get; set; }

        public Route RouteNumberNavigation { get; set; }
    }
}
