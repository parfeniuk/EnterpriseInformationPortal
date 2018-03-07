using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.DataLayer.Entities
{
    public class ProductCategory
    {
        public ProductCategory()
        {
            ProductSubCategories = new HashSet<ProductSubCategory>();
        }

        public Guid ProductCategoryId { get; set; }
        public string ProductCategoryName { get; set; }

        public virtual ICollection<ProductSubCategory> ProductSubCategories { get; set; }
    }
}
