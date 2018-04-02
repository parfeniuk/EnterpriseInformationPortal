using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class Shop
    {
        public int ShopNumber { get; set; }
        public string Adress { get; set; }
        public string Name { get; set; }
        public int PointId { get; set; }
        public int ManagerId { get; set; }

        public Manager Manager { get; set; }
        public Point Point { get; set; }
    }
}
