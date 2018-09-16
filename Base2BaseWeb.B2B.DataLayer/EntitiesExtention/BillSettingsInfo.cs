using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public class BillSettingsInfo
    {
        public int BillSettingsInfoId { get; set; }
        public bool AutomaticBilling { get; set; }
        public bool SendByEmail { get; set; }

        public int? ServicePlaceholderTypeId { get; set; }
        public virtual ServicePlaceholderType ServicePlaceholderType { get;set;}

        public int? DocumentTemplateId { get; set; }
        public virtual DocumentTemplate DocumentTemplate { get; set; }

        public int? PointNumber { get; set; }
        public virtual Point Point { get; set; }
    }
}
