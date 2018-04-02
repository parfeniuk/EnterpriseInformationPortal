using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public class BillSettingsInfo
    {
        public BillSettingsInfo()
        {
            PrintJobInfo = new HashSet<PrintJobInfo>();
            BillSettingsOptionsInfo = new HashSet<BillSettingsOptionsInfo>();
        }

        public int BillSettingsInfoId { get; set; }
        public bool AutomaticBilling { get; set; }
        public bool SendByEmail { get; set; }
        public bool ReplaceServiceList { get; set; }

        public int DocumentTemplateId { get; set; }
        public virtual DocumentTemplate DocumentTemplate { get; set; }
        public virtual ICollection<PrintJobInfo> PrintJobInfo { get; set; }
        public virtual ICollection<BillSettingsOptionsInfo> BillSettingsOptionsInfo { get; set; }

        public int PointNumber { get; set; }
        public virtual Point Point { get; set; }
    }
}
