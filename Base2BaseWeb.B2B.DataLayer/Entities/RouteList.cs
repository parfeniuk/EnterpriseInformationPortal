using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class RouteList
    {
        public RouteList()
        {
            RouteNaklList = new HashSet<RouteNaklList>();
        }

        public int RouteListNumber { get; set; }
        public int? RouteNumber { get; set; }
        public int? CarNumber { get; set; }
        public int? ExpeditorNumber { get; set; }
        public double? Weight { get; set; }
        public double? Volume { get; set; }
        public double? Distance { get; set; }
        public string Osn { get; set; }
        public bool Utv { get; set; }
        public DateTime? DateUtv { get; set; }
        public double? SumRozn { get; set; }
        public double? SumDol { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public Car CarNumberNavigation { get; set; }
        public Point ExpeditorNumberNavigation { get; set; }
        public Route RouteNumberNavigation { get; set; }
        public ICollection<RouteNaklList> RouteNaklList { get; set; }
    }
}
