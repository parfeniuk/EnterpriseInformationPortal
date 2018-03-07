using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.DataLayer.Entities
{
    public class ProductSubCategory
    {
        public ProductSubCategory()
        {
            Products = new HashSet<Product>();
            ProductSubCategoryImages = new HashSet<ProductSubCategoryImage>();
            ProductSubCategoryFeatures = new HashSet<ProductSubCategoryFeature>();
        }

        public Guid ProductSubCategoryId { get; set; }
        public Guid ProductCategoryId { get; set; }

        public string Name { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<ProductSubCategoryImage> ProductSubCategoryImages { get; set; }
        public virtual ICollection<ProductSubCategoryFeature> ProductSubCategoryFeatures { get; set; }
    }
}