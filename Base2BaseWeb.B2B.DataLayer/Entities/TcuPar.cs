using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class TcuPar
    {
        public string ParamName { get; set; }
        public short? ParamType { get; set; }
        public string TextValue { get; set; }
        public bool BoolValue { get; set; }
        public int? LongValue { get; set; }
        public double? DoubleValue { get; set; }
    }
}
