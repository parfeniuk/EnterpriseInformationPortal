using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class Articl
    {
        public Articl()
        {
            AccTransChema = new HashSet<AccTransChema>();
        }

        public int ArticlNumber { get; set; }
        public string ArticlName { get; set; }
        public bool ActPass { get; set; }
        public bool Closed { get; set; }

        public ICollection<AccTransChema> AccTransChema { get; set; }
    }
}
