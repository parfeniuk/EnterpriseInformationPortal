using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class InOutJrn
    {
        public int InOutJrnNumber { get; set; }
        public string TableName { get; set; }
        public int? KeyNumber { get; set; }
        public string KeyField { get; set; }
        public DateTime? IoDate { get; set; }
        public int? PointNumber { get; set; }
        public int? ArticlNumber { get; set; }
        public DateTime? DateUtv { get; set; }
    }
}
