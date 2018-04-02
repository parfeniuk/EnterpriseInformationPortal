using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class User
    {
        public int UserNumber { get; set; }
        public string UserName { get; set; }
        public string UserFullname { get; set; }
        public string UserPasswd { get; set; }
        public bool Sprav { get; set; }
        public bool Admin { get; set; }
        public bool CliZad { get; set; }
        public bool TovarSprav { get; set; }
        public bool CliSprav { get; set; }
        public bool ArticlSprav { get; set; }
        public bool RouteSprav { get; set; }
        public bool ChangeDate { get; set; }
        public int? DaysBackward { get; set; }
        public int? DaysForward { get; set; }
        public bool NegativeRests { get; set; }
        public double? MaxDiscount { get; set; }
        public bool SaleMorePurchase { get; set; }
        public bool CashReportAccess { get; set; }
        public bool RLView { get; set; }
        public bool RLEdit { get; set; }
        public bool RLApprove { get; set; }
        public bool RLRollback { get; set; }
        public bool RLDelete { get; set; }
        public bool? SettlementsAccess { get; set; }
        public bool? PointSprav { get; set; }
        public bool? AllowSalesKurs { get; set; }
        public bool? AllowPurchaseKurs { get; set; }
        public bool? Closed { get; set; }
        public bool? ReportAccess { get; set; }
    }
}
