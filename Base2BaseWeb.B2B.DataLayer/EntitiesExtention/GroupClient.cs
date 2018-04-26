using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public class GroupClient
    {
        public int PointNumber { get; set; }
        public virtual Point Point { get; set; }

        public int CliGroupNumber { get; set; }
        public virtual CliGroup CliGroup { get; set; }
    }
}
