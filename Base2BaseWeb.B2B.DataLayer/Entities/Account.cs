using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class Account
    {
        public int AccountNumber { get; set; }
        public string AccountName { get; set; }
        public int? TopAccountNumber { get; set; }
        public string Comment { get; set; }
        public double? Rest { get; set; }
        public short? AccType { get; set; }
    }
}
