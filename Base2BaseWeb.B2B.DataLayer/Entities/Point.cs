using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class Point
    {
        public Point()
        {
            DelivePoint = new HashSet<DelivePoint>();
            DiscountRules = new HashSet<DiscountRules>();
            ExtPoint = new HashSet<ExtPoint>();
            ExtShablon = new HashSet<ExtShablon>();
            ExtTovar = new HashSet<ExtTovar>();
            Manager = new HashSet<Manager>();
            NaklPoint1NumberNavigation = new HashSet<Nakl>();
            NaklPoint2NumberNavigation = new HashSet<Nakl>();
            OrdersRedirectionPointNumberNavigation = new HashSet<OrdersRedirection>();
            OrdersRedirectionRestaurantNumberNavigation = new HashSet<OrdersRedirection>();
            PointAgent = new HashSet<PointAgent>();
            Reestr = new HashSet<Reestr>();
            RouteList = new HashSet<RouteList>();
            Service = new HashSet<Service>();
            Shop = new HashSet<Shop>();

            InitializeNavigationExtentions();
        }

        public int PointNumber { get; set; }
        public string NamePoint { get; set; }
        public int? CliGroupNumber { get; set; }
        public string IndNum { get; set; }
        public string SvidNum { get; set; }
        public string Address { get; set; }
        public string Telefon { get; set; }
        public string Fax { get; set; }
        public string NameCeoPerson { get; set; }
        public string ContactPerson { get; set; }
        public bool Post { get; set; }
        public double? TransportPr { get; set; }
        public double? Arenda { get; set; }
        public bool Realis { get; set; }
        public bool Closed { get; set; }
        public string Mfo { get; set; }
        public string BankAccount { get; set; }
        public string Okpo { get; set; }
        public string BankName { get; set; }
        public double? ClientKurs { get; set; }
        public string PointComment { get; set; }
        public double? Saldo { get; set; }
        public double? SaldoDol { get; set; }
        public string Email { get; set; }
        public bool BankFromParam { get; set; }
        public bool NameFirmFromParam { get; set; }
        public double? DateCliZad { get; set; }
        public bool ZadActivate { get; set; }
        public double? Nds { get; set; }
        public double? Kredit { get; set; }
        public double? KreditDol { get; set; }
        public int? DayZad { get; set; }
        public bool DayZadOn { get; set; }
        public bool KreditOn { get; set; }
        public bool Driver { get; set; }
        public bool NameFirmFromParamFiscal { get; set; }
        public string LicenceNumber { get; set; }
        public string NameFirm { get; set; }
        public string NameFirmFiscal { get; set; }
        public string AddressFiscal { get; set; }
        public string TelefonFiscal { get; set; }
        public string Prof1Person { get; set; }
        public string Prof1PersonFiscal { get; set; }
        public string Name1Person { get; set; }
        public string Name1PersonFiscal { get; set; }
        public string Prof2Person { get; set; }
        public string Prof2PersonFiscal { get; set; }
        public string Name2Person { get; set; }
        public string Name2PersonFiscal { get; set; }
        public string MaOtvPerson { get; set; }
        public string MaOtvPersonFiscal { get; set; }
        public string PathToMobileSynchro { get; set; }
        public bool? CommAgent { get; set; }
        public string CardNumber { get; set; }
        public bool? CardActivated { get; set; }
        public double? DiscountCardPercent { get; set; }
        public DateTime? LicenceEndDate { get; set; }
        public string ContractNumber { get; set; }
        public DateTime? ContractStartDate { get; set; }
        public DateTime? ContractEndDate { get; set; }
        public int? PointType { get; set; }
        public double? AgentMaxDiscount { get; set; }
        public bool? Waiter { get; set; }
        public string Kpp { get; set; }
        public string CorrAccount { get; set; }
        public bool? AgentSiAllow { get; set; }
        public bool? AgentOrderAllow { get; set; }
        public bool? AgentCashAllow { get; set; }
        public bool? AgentUseRoutes { get; set; }
        public int? SiArticlNumber { get; set; }
        public int? PisArticlNumber { get; set; }
        public int? CoArticlNumber { get; set; }
        public int? CashPointNumber { get; set; }
        public bool? NdsPayer { get; set; }
        public int? DiscountType { get; set; }
        public int? PriceColumnNumber { get; set; }
        public DateTime? LastEditDate { get; set; }
        public string Name1PersonFiscalTaxId { get; set; }
        public string Name2PersonFiscalTaxId { get; set; }
        public bool? ExportDocumentToFranchiseService { get; set; }
        public bool? RoutesByDates { get; set; }
        public bool? AgentOnlySelectedCategories { get; set; }
        public string Iban { get; set; }
        public string Swiftcode { get; set; }
        public string BankClearingNumber { get; set; }
        public string Postconto { get; set; }

        //public CliGroup CliGroupNumberNavigation { get; set; }
        public ICollection<DelivePoint> DelivePoint { get; set; }
        public ICollection<DiscountRules> DiscountRules { get; set; }
        public ICollection<ExtPoint> ExtPoint { get; set; }
        public ICollection<ExtShablon> ExtShablon { get; set; }
        public ICollection<ExtTovar> ExtTovar { get; set; }
        public ICollection<Manager> Manager { get; set; }
        public ICollection<Nakl> NaklPoint1NumberNavigation { get; set; }
        public ICollection<Nakl> NaklPoint2NumberNavigation { get; set; }
        public ICollection<OrdersRedirection> OrdersRedirectionPointNumberNavigation { get; set; }
        public ICollection<OrdersRedirection> OrdersRedirectionRestaurantNumberNavigation { get; set; }
        public ICollection<PointAgent> PointAgent { get; set; }
        public ICollection<Reestr> Reestr { get; set; }
        public ICollection<RouteList> RouteList { get; set; }
        public ICollection<Service> Service { get; set; }
        public ICollection<Shop> Shop { get; set; }
    }
}
