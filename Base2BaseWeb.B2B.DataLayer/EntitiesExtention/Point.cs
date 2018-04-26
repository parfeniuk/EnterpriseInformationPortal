using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class Point
    {
        protected void InitializeNavigationExtentions()
        {
            BillOptionsInfo = new HashSet<BillOptionsInfo>();
            PrintJobInfo = new HashSet<PrintJobInfo>();
            ContactPhoneInfo = new HashSet<ContactPhoneInfo>();
            ContactEmailInfo = new HashSet<ContactEmailInfo>();
            Tickets = new HashSet<Ticket>();
            ProductClients = new HashSet<ProductClient>();
            GroupClients = new HashSet<GroupClient>();
            PointChildren = new HashSet<PointChildren>();
        }

        public virtual CliGroup CliGroup { get; set; }

        public virtual BillSettingsInfo BillSettingsInfo { get; set; }
        public virtual ClientConnectionInfo ClientConnectionInfo { get; set; }
        public virtual DebtControlInfo DebtControlInfo { get; set; }
        public virtual DebtCalcMethodInfo DebtCalcMethodInfo { get; set; }
        public virtual FranchisingInfo FranchisingInfo { get; set; }

        public virtual ICollection<BillOptionsInfo> BillOptionsInfo { get; set; }
        public virtual ICollection<PrintJobInfo> PrintJobInfo { get; set; }
        public virtual ICollection<ContactPhoneInfo> ContactPhoneInfo { get; set; }
        public virtual ICollection<ContactEmailInfo> ContactEmailInfo { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
        public virtual ICollection<ProductClient> ProductClients { get; set; }
        public virtual ICollection<GroupClient> GroupClients { get; set; }
        public virtual ICollection<PointChildren> PointChildren { get; set; }
    }
}
