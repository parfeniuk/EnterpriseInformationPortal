using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public class FranchisingInfo
    {
        public int FranchisingInfoId { get; set; }
        public bool UseFranchising { get; set; }
        public bool IsFranchisor { get; set; }
        public bool IsFranchisee { get; set; }

        public int PointNumber { get; set; }
        public virtual Point Point { get; set; }
    }
}
