using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class Jrn
    {
        public int JrnNumber { get; set; }
        public int? NaklNumber { get; set; }
        public int? ReestrNumber { get; set; }
        public int? ListNumber { get; set; }
        public int? NaklPrihNumber { get; set; }
        public int? ListPrihNumber { get; set; }
        public int? Reestr2Number { get; set; }
        public DateTime? DateMove { get; set; }
        public double? Kol { get; set; }
        public double? CenaOpt { get; set; }
        public double? CenaRozn { get; set; }
        public double? CenaDol { get; set; }
        public double? CenaOptDol { get; set; }
        public bool RashPrih { get; set; }
        public int? NaklType { get; set; }
        public double? Kurs { get; set; }
        public bool FiscalDocument { get; set; }
        public string SerialNumber { get; set; }

        public List ListNumberNavigation { get; set; }
        public Reestr ReestrNumberNavigation { get; set; }
    }
}
