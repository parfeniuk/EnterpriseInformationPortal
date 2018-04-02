using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class TovarCode
    {
        public int TovarCodeNumber { get; set; }
        public int? TovarNumber { get; set; }
        public string TovarBarCode { get; set; }
        public bool Closed { get; set; }
        public bool ChkDisable { get; set; }

        public Tovar TovarNumberNavigation { get; set; }
    }
}
