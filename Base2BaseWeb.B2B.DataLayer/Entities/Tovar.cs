using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class Tovar
    {
        public Tovar()
        {
            ExtTovar = new HashSet<ExtTovar>();
            KassaTovar = new HashSet<KassaTovar>();
            List = new HashSet<List>();
            OrdersRedirection = new HashSet<OrdersRedirection>();
            PriceShields = new HashSet<PriceShields>();
            Recipe = new HashSet<Recipe>();
            Reestr = new HashSet<Reestr>();
            TovarCode = new HashSet<TovarCode>();

            InitializeNavigationExtentions();
        }

        public int TovarNumber { get; set; }
        public string TovarName { get; set; }
        public string TovarKod { get; set; }
        public int? IzmerNumber { get; set; }
        public int? KatNumber { get; set; }
        public bool Tara { get; set; }
        public string Comment { get; set; }
        public double? KolMin1 { get; set; }
        public double? KolMin2 { get; set; }
        public double? PercSkid1 { get; set; }
        public double? PercSkid2 { get; set; }
        public double? CenaRoznSprav { get; set; }
        public double? CenaRozn2 { get; set; }
        public double? CenaRozn3 { get; set; }
        public double? CenaRoznSpravDol { get; set; }
        public double? CenaRozn2Dol { get; set; }
        public double? CenaRozn3Dol { get; set; }
        public double? Balls { get; set; }
        public bool TovClosed { get; set; }
        public string TovPicture { get; set; }
        public string UniNumber { get; set; }
        public double? KolInPak { get; set; }
        public double? StDost { get; set; }
        public double? StDostDol { get; set; }
        public bool StDostAlg { get; set; }
        public double? KolDefault { get; set; }
        public string TovarFontName { get; set; }
        public bool TovarFontBold { get; set; }
        public bool TovarFontItalic { get; set; }
        public int? TovarFontSize { get; set; }
        public int? TovarForecolor { get; set; }
        public int? TovarBackcolor { get; set; }
        public double? Ves { get; set; }
        public double? Objem { get; set; }
        public int? Tara1Number { get; set; }
        public double? KolOsn1 { get; set; }
        public double? KolLinked1 { get; set; }
        public int? Tara2Number { get; set; }
        public double? KolOsn2 { get; set; }
        public double? KolLinked2 { get; set; }
        public bool Tare1Check { get; set; }
        public bool Tare2Check { get; set; }
        public double? CenaRozn4 { get; set; }
        public double? CenaRozn4Dol { get; set; }
        public double? CenaRozn5 { get; set; }
        public double? CenaRozn5Dol { get; set; }
        public bool Product { get; set; }
        public string Articul { get; set; }
        public bool SerialNumberCheck { get; set; }
        public bool AllKol { get; set; }
        public int? TovarType { get; set; }
        public string Certificate { get; set; }
        public DateTime? CertEndDate { get; set; }
        public bool? UseCert { get; set; }
        public string ProducedBy { get; set; }
        public double? DiscountPercent2 { get; set; }
        public bool? DiscountCalcOn2 { get; set; }
        public bool? DiscountCalcOn3 { get; set; }
        public bool? DiscountCalcOn4 { get; set; }
        public bool? DiscountCalcOn5 { get; set; }
        public double? DiscountPercent3 { get; set; }
        public double? DiscountPercent4 { get; set; }
        public double? DiscountPercent5 { get; set; }
        public int? RoundTo2 { get; set; }
        public int? RoundTo3 { get; set; }
        public int? RoundTo4 { get; set; }
        public int? RoundTo5 { get; set; }
        public double? SpareFactor { get; set; }
        public int? PurchasePeriod { get; set; }
        public bool? DiscountCalcOn1 { get; set; }
        public double? DiscountPercent1 { get; set; }
        public int? RoundTo1 { get; set; }
        public bool? DiscountMarkup { get; set; }
        public byte[] Image1 { get; set; }
        public byte[] Image1Cash { get; set; }
        public int? FranchTopId { get; set; }
        public int? FiscalGroupNumber { get; set; }
        public string UktzedCode { get; set; }
        public double? LastCenaOpt { get; set; }
        public double? LastCenaOptDol { get; set; }
        public DateTime? LastEditDate { get; set; }
        public double? DiscountLimitation { get; set; }
        public bool? Tara1Round { get; set; }
        public bool? Tara2Round { get; set; }
        public string TovDescription { get; set; }
        public string VideoHyperlink { get; set; }
        public int? Warranty { get; set; }
        public string AnalyticCode { get; set; }

        public Izmer IzmerNumberNavigation { get; set; }
        public Kat KatNumberNavigation { get; set; }
        public ICollection<ExtTovar> ExtTovar { get; set; }
        public ICollection<KassaTovar> KassaTovar { get; set; }
        public ICollection<List> List { get; set; }
        public ICollection<OrdersRedirection> OrdersRedirection { get; set; }
        public ICollection<PriceShields> PriceShields { get; set; }
        public ICollection<Recipe> Recipe { get; set; }
        public ICollection<Reestr> Reestr { get; set; }
        public ICollection<TovarCode> TovarCode { get; set; }
    }
}
