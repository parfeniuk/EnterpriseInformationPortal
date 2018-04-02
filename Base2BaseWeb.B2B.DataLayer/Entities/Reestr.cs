using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class Reestr
    {
        public Reestr()
        {
            Jrn = new HashSet<Jrn>();
        }

        public int ReestrNumber { get; set; }
        public int? PointNumber { get; set; }
        public int? TovarNumber { get; set; }
        public double? Kol { get; set; }
        public double? CenaRozn { get; set; }
        public double? CenaDol { get; set; }
        public int? PostNumber { get; set; }
        public string Rezerv1 { get; set; }
        public string Rezerv2 { get; set; }
        public string Rezerv3 { get; set; }
        public string Rezerv4 { get; set; }
        public string Rezerv5 { get; set; }
        public string Rezerv6 { get; set; }
        public string Rezerv7 { get; set; }
        public string Rezerv8 { get; set; }
        public string Comment { get; set; }
        public double? KolMin { get; set; }
        public double? KolRezerv { get; set; }
        public DateTime? LastEditDate { get; set; }

        public Point PointNumberNavigation { get; set; }
        public Tovar TovarNumberNavigation { get; set; }
        public ICollection<Jrn> Jrn { get; set; }
    }
}
