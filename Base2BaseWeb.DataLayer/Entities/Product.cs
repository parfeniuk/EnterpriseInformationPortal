using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.DataLayer.Entities
{
    public class Product
    {
        public Product()
        {
            ProductImages = new HashSet<ProductImage>();
            ProductFeatures = new HashSet<ProductFeature>();
            ProductProdAttributes = new HashSet<ProductProdAttribute>();
        }

        public Guid ProductId { get; set; }
        public Guid ProductCategoryId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ProductImage> ProductImages { get; set; }
        public virtual ICollection<ProductFeature> ProductFeatures { get; set; }
        public virtual ICollection<ProductProdAttribute> ProductProdAttributes { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
    }
}
