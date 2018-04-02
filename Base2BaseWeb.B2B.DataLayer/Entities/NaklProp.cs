using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class NaklProp
    {
        public int NaklPropNumber { get; set; }
        public int? NaklNumber { get; set; }
        public string PropertyName { get; set; }
        public string PropertyValue { get; set; }

        public Nakl NaklNumberNavigation { get; set; }
    }
}
