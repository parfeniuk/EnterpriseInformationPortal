using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class List
    {
        public List()
        {
            Jrn = new HashSet<Jrn>();
            JrnRezervListNumberNavigation = new HashSet<JrnRezerv>();
            JrnRezervListRezervNumberNavigation = new HashSet<JrnRezerv>();
        }

        public int ListNumber { get; set; }
        public int? NaklNumber { get; set; }
        public int? TovarNumber { get; set; }
        public int? ReestrNumber { get; set; }
        public double? Kol { get; set; }
        public double? KolCurrent { get; set; }
        public double? CenaOpt { get; set; }
        public double? CenaRozn { get; set; }
        public bool Tara { get; set; }
        public int? Reestr2Number { get; set; }
        public double? CenaDol { get; set; }
        public double? CenaOptDol { get; set; }
        public string Comment { get; set; }
        public int? ZakazlistNumber { get; set; }
        public double? PercSkid { get; set; }
        public double? SumSkid { get; set; }
        public double? SumSkidDol { get; set; }
        public double? NewRest { get; set; }
        public string RezList1 { get; set; }
        public string RezList2 { get; set; }
        public string RezList3 { get; set; }
        public string RezList4 { get; set; }
        public string RezList5 { get; set; }
        public string RezList6 { get; set; }
        public string RezList7 { get; set; }
        public string RezList8 { get; set; }
        public double? KolInPak { get; set; }
        public double? KolPak { get; set; }
        public double? KolAdd { get; set; }
        public double? KolAfter { get; set; }
        public double? CenaOptAfter { get; set; }
        public double? CenaOptDolAfter { get; set; }
        public double? CenaRoznAfter { get; set; }
        public double? CenaDolAfter { get; set; }
        public int? ListPrihNumber { get; set; }
        public double? CenaZak { get; set; }
        public double? CenaZakDol { get; set; }
        public double? Weight { get; set; }
        public double? Volume { get; set; }
        public int? TovarCodeNumber { get; set; }
        public int? ListZakazNumber { get; set; }
        public string SerialNumber { get; set; }
        public bool? Product { get; set; }
        public int? RecipeNumber { get; set; }
        public string CustDeclNumber { get; set; }

        public Nakl NaklNumberNavigation { get; set; }
        public Tovar TovarNumberNavigation { get; set; }
        public ICollection<Jrn> Jrn { get; set; }
        public ICollection<JrnRezerv> JrnRezervListNumberNavigation { get; set; }
        public ICollection<JrnRezerv> JrnRezervListRezervNumberNavigation { get; set; }
    }
}
