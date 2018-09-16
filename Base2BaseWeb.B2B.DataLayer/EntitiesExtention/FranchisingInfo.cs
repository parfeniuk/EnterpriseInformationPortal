using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public class FranchisingInfo
    {
        public int FranchisingInfoId { get; set; }

        public int? FranchisingTypeId { get; set; }
        public virtual FranchisingType FranchisingType { get; set; }

        public int? PointNumber { get; set; }
        public virtual Point Point { get; set; }
    }
}
