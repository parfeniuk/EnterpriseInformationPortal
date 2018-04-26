using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class Tovar
    {
        protected void InitializeNavigationExtentions()
        {
            ProductClients = new HashSet<ProductClient>();
        }
        public virtual ICollection<ProductClient> ProductClients { get; set; }
    }
}
