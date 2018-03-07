using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.DataLayer.Entities
{
    public class ProductImage
    {
        public Guid ProductImageId { get; set; }
        public Guid ProductId { get; set; }
        public string Path { get; set; }
        public bool IsPoster { get; set; }

        public virtual Product Product { get; set; }

    }
}
