using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class RouteNaklList
    {
        public int RouteNaklListNumber { get; set; }
        public int? RouteListNumber { get; set; }
        public int? NaklNumber { get; set; }

        public Nakl NaklNumberNavigation { get; set; }
        public RouteList RouteListNumberNavigation { get; set; }
    }
}
