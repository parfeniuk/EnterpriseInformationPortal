using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class PriceImportJrn
    {
        public int PriceImportJrnNumber { get; set; }
        public int ExtTovarNumber { get; set; }
        public string ExtTovarName { get; set; }
        public int TovarNumber { get; set; }
        public bool TovarAppend { get; set; }
        public double CenaPrice1 { get; set; }
        public double CenaPrice2 { get; set; }
        public double CenaPrice3 { get; set; }
        public double CenaPrice4 { get; set; }
        public double CenaPrice5 { get; set; }
        public double CenaPrice1Dol { get; set; }
        public double CenaPrice2Dol { get; set; }
        public double CenaPrice3Dol { get; set; }
        public double CenaPrice4Dol { get; set; }
        public double CenaPrice5Dol { get; set; }
        public string TovarPresent { get; set; }
        public DateTime TovarUpdateDate { get; set; }
        public int PointNumber { get; set; }
        public string TovarDescrip { get; set; }
        public int KatNumber { get; set; }
        public int IzmerNumber { get; set; }
    }
}
