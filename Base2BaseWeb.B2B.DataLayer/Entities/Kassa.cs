using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class Kassa
    {
        public Kassa()
        {
            KassaTovar = new HashSet<KassaTovar>();
            Service = new HashSet<Service>();
        }

        public int KassaId { get; set; }
        public string KassaName { get; set; }
        public string TeamViewer { get; set; }
        public int? ShopId { get; set; }

        public ICollection<KassaTovar> KassaTovar { get; set; }
        public ICollection<Service> Service { get; set; }
    }
}
