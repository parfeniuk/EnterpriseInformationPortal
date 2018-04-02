using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class Point
    {
        protected void InitializeNavigationExtentions()
        {
            ContactPhoneInfo = new HashSet<ContactPhoneInfo>();
            ContactEmailInfo = new HashSet<ContactEmailInfo>();
        }

        public virtual CliGroup CliGroup { get; set; }

        public virtual BillSettingsInfo BillSettingsInfo { get; set; }
        public virtual ClientConnectionInfo ClientConnectionInfo { get; set; }
        public virtual DebtControlInfo DebtControlInfo { get; set; }
        public virtual DebtCalcMethodInfo DebtCalcMethodInfo { get; set; }
        public virtual FranchisingInfo FranchisingInfo { get; set; }

        public virtual ICollection<ContactPhoneInfo> ContactPhoneInfo { get; set; }
        public virtual ICollection<ContactEmailInfo> ContactEmailInfo { get; set; }
    }
}
