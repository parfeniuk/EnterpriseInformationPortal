using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.DataLayer.Entities
{
    public class ProductProdAttribute
    {
        public Guid ProdAttributeId { get; set; }
        public Guid ProductId { get; set; }

        public virtual ProdAttribute ProdAttribute { get; set; }
        public virtual Product Product { get; set; }
    }
}
