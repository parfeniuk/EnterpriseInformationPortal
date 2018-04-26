using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public class BillOptionsInfo
    {
        public int BillOptionsInfoId { get; set; }
        public double Limit { get; set; }

        public int? PointNumber { get; set; }
        public virtual Point Point { get; set; }

        public int? DocumentTemplateId { get; set; }
        public virtual DocumentTemplate DocumentTemplate { get; set; }
    }
}
