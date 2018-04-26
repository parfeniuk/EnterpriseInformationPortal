using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class CliGroup
    {
        protected void InitializeNavigationExtentions()
        {
            GroupClients = new HashSet<GroupClient>();
        }
        public virtual ICollection<GroupClient> GroupClients { get; set; }
    }
}
