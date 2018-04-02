using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class Izmer
    {
        public Izmer()
        {
            Tovar = new HashSet<Tovar>();
        }

        public int IzmerNumber { get; set; }
        public string IzmerName { get; set; }
        public bool? DefaultIzmer { get; set; }

        public ICollection<Tovar> Tovar { get; set; }
    }
}
