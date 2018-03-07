using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.DataLayer.Entities
{
    public class ProdAttribute
    {
        public Guid ProdAttributeId { get; set; }
        
        public string Attribute { get; set; }
        public string Value { get; set; }

        public virtual ICollection<ProductProdAttribute> ProductProdAttributes { get; set; }
    }
}
