using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class Service
    {
        public int ServiceId { get; set; }
        public int? PointId { get; set; }
        public int KassaId { get; set; }
        public DateTime? ServiceDate { get; set; }
        public string Comment { get; set; }

        public Kassa Kassa { get; set; }
        public Point Point { get; set; }
    }
}
