using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class CliGroup
    {
        public CliGroup()
        {
            Point = new HashSet<Point>();
            InitializeNavigationExtentions();
        }

        public int CliGroupNumber { get; set; }
        public string CliGroupName { get; set; }
        public bool Post { get; set; }

        public ICollection<Point> Point { get; set; }
    }
}
