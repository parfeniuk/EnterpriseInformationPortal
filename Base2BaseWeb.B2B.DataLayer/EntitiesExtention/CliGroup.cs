using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class CliGroup
    {
        protected void InitializeNavigationExtentions()
        {
            GroupClients = new HashSet<GroupClient>();
        }
        public int? PointNumber { get; set; }

        public virtual ICollection<GroupClient> GroupClients { get; set; }
    }
}
