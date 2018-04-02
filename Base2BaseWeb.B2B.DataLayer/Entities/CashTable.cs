using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class CashTable
    {
        public int CashNumber { get; set; }
        public int? LngNumber { get; set; }
        public string CashText { get; set; }
        public string FormName { get; set; }
        public string FieldName { get; set; }
    }
}
