using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Base2BaseWeb.UI.Areas.Company.DTO
{
    public class ProductDto
    {
        public bool Active { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
