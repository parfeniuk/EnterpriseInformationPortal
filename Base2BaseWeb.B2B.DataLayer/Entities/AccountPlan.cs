using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class AccountPlan
    {
        public int AccountPlanNumber { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public short? AccountType { get; set; }
        public string AccountSphere { get; set; }
    }
}
