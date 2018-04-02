using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class NaklImportJrn
    {
        public int NaklImportJrnNumber { get; set; }
        public int ExtTovarNumber { get; set; }
        public string ExtTovarName { get; set; }
        public int TovarNumber { get; set; }
        public double TovarKolNakl { get; set; }
        public double CenaNakl { get; set; }
        public double CenaNaklDol { get; set; }
        public double KursNakl { get; set; }
        public int ExtPoint1Number { get; set; }
        public string ExtPoint1Name { get; set; }
        public int Point1Number { get; set; }
        public int ExtPoint2Number { get; set; }
        public string ExtPoint2Name { get; set; }
        public int Point2Number { get; set; }
        public int NaklNumber { get; set; }
        public int ListNumber { get; set; }
        public DateTime RecordUpdateDate { get; set; }
    }
}
