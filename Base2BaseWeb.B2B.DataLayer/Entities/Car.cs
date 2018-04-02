using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class Car
    {
        public Car()
        {
            RouteList = new HashSet<RouteList>();
        }

        public int CarNumber { get; set; }
        public string RegNumber { get; set; }
        public string Model { get; set; }
        public double? Tara { get; set; }
        public double? Netto { get; set; }

        public ICollection<RouteList> RouteList { get; set; }
    }
}
