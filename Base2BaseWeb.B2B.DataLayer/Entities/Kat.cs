using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class Kat
    {
        public Kat()
        {
            KatAgent = new HashSet<KatAgent>();
            Tovar = new HashSet<Tovar>();
        }

        public int KatNumber { get; set; }
        public string KatName { get; set; }
        public int? TopKat { get; set; }
        public string ExtKatName { get; set; }
        public byte[] KatImage { get; set; }
        public double? PointsGeneratePercent { get; set; }
        public string MacroGroupId { get; set; }

        public ICollection<KatAgent> KatAgent { get; set; }
        public ICollection<Tovar> Tovar { get; set; }
    }
}
