using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class Manager
    {
        public Manager()
        {
            Shop = new HashSet<Shop>();
        }

        public int ManagerNumber { get; set; }
        public string ManagerName { get; set; }
        public string ManagerTelephone { get; set; }
        public int? PointId { get; set; }

        public Point Point { get; set; }
        public ICollection<Shop> Shop { get; set; }
    }
}
