using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class AccTransJrn
    {
        public int AccTransJrnNumber { get; set; }
        public int? ArticlNumber { get; set; }
        public int? AccTransChemaNumber { get; set; }
        public int? Account1Number { get; set; }
        public int? Account2Number { get; set; }
        public double? Summa { get; set; }
        public string Comment { get; set; }
        public int? BundleNaklNumber { get; set; }
        public DateTime? DateUtv { get; set; }
        public bool Utv { get; set; }
        public int? UserNumber { get; set; }
    }
}
