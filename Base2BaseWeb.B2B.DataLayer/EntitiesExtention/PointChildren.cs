using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public class PointChildren
    {
        public int PointChildrenId { get; set; }

        public int PointNumber { get; set; }
        public virtual Point Point { get; set; }

        public int ChildId { get; set; }
        public string ChildName { get; set; }
    }
}
