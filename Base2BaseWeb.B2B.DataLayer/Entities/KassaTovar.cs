using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class KassaTovar
    {
        public int KassaId { get; set; }
        public int TovarId { get; set; }

        public Kassa Kassa { get; set; }
        public Tovar Tovar { get; set; }
    }
}
