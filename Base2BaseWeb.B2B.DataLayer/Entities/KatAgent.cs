using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class KatAgent
    {
        public int KatAgentNumber { get; set; }
        public int? KatNumber { get; set; }
        public int? PointNumber { get; set; }

        public Kat KatNumberNavigation { get; set; }
    }
}
