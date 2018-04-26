using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public class ProductClient
    {
        public int PointNumber { get; set; }
        public virtual Point Point { get; set; }

        public int TovarNumber { get; set; }
        public virtual Tovar Tovar { get; set; }
    }
}
