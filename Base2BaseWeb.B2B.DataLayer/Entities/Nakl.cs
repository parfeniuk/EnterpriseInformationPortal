using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class Nakl
    {
        public Nakl()
        {
            JrnOplNakl1NumberNavigation = new HashSet<JrnOpl>();
            JrnOplNakl2NumberNavigation = new HashSet<JrnOpl>();
            List = new HashSet<List>();
            MarketingActionRecords = new HashSet<MarketingActionRecords>();
            NaklProp = new HashSet<NaklProp>();
            PriceShields = new HashSet<PriceShields>();
            RouteNaklList = new HashSet<RouteNaklList>();
        }

        public int NaklNumber { get; set; }
        public string DocNumber { get; set; }
        public string PostNumber { get; set; }
        public int? Point1Number { get; set; }
        public int? Point2Number { get; set; }
        public DateTime? DateUtv { get; set; }
        public DateTime? DateNakl { get; set; }
        public string Osn { get; set; }
        public string Prim { get; set; }
        public int? NaklType { get; set; }
        public bool RashPrih { get; set; }
        public bool Utv { get; set; }
        public int? ArticlNumber { get; set; }
        public double? Kurs { get; set; }
        public double? SysKurs { get; set; }
        public double? NaklRash { get; set; }
        public double? NaklRashDol { get; set; }
        public double? NaklRashMe { get; set; }
        public double? NaklRashMeDol { get; set; }
        public string VidPlat { get; set; }
        public string DovNumber { get; set; }
        public int? CenaRoznSelect { get; set; }
        public double? SumOpt { get; set; }
        public double? SumOptDol { get; set; }
        public double? SumRozn { get; set; }
        public double? SumDol { get; set; }
        public double? SumTara { get; set; }
        public double? SumTaraDol { get; set; }
        public int? BundleNaklNumber { get; set; }
        public short? Flag { get; set; }
        public bool RDol { get; set; }
        public double? SumVzr { get; set; }
        public double? SumVzrDol { get; set; }
        public bool Return { get; set; }
        public int? NaklPropTemplateNumber { get; set; }
        public bool ViewAddProp { get; set; }
        public int? DelivePointNumber { get; set; }
        public double? SumWeight { get; set; }
        public double? SumVolume { get; set; }
        public int? RouteNumber { get; set; }
        public int? UserNumber { get; set; }
        public string FiscalNumber { get; set; }
        public double? PercSkid { get; set; }
        public string DeliveryCondition { get; set; }
        public int? RecipeNumber { get; set; }
        public bool FiscalDocument { get; set; }
        public int? RouteListNumber { get; set; }
        public short? CheckPoint { get; set; }
        public int? AgentNumber { get; set; }
        public double? SumOpl { get; set; }
        public double? SumOplDol { get; set; }
        public bool? OrderRezerved { get; set; }
        public double? ClientDiscount { get; set; }
        public bool? AutoPayment { get; set; }
        public DateTime? PrintDate { get; set; }
        public int? SourceNumber { get; set; }
        public Guid? DocumentGuid { get; set; }
        public Guid? TopDocumentGuid { get; set; }
        public DateTime? DateFranchUpload { get; set; }
        public int? DocStanId { get; set; }
        public string ModeOfShipment { get; set; }
        public string SupplierRef { get; set; }
        public string Rfq { get; set; }
        public string MaterialReq { get; set; }
        public string SoAndProject { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public double? BonusPaid { get; set; }

        public DocStan DocStan { get; set; }
        public Point Point1NumberNavigation { get; set; }
        public Point Point2NumberNavigation { get; set; }
        public OrderExt OrderExt { get; set; }
        public ICollection<JrnOpl> JrnOplNakl1NumberNavigation { get; set; }
        public ICollection<JrnOpl> JrnOplNakl2NumberNavigation { get; set; }
        public ICollection<List> List { get; set; }
        public ICollection<MarketingActionRecords> MarketingActionRecords { get; set; }
        public ICollection<NaklProp> NaklProp { get; set; }
        public ICollection<PriceShields> PriceShields { get; set; }
        public ICollection<RouteNaklList> RouteNaklList { get; set; }
    }
}
