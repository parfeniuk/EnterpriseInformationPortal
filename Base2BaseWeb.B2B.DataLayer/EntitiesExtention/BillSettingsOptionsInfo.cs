using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public class BillSettingsOptionsInfo
    {
        public int BillSettingsOptionsInfoId { get; set; }
        public double Limit { get; set; }

        public int BillSettingsInfoId { get; set; }
        public BillSettingsInfo BillSettingsInfo { get; set; }

        public int DocumentTemplateId { get; set; }
        public virtual DocumentTemplate DocumentTemplate { get; set; }
    }
}
