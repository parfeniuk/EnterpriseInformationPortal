using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.DataLayer.Entities
{
    public class ProductCategory
    {
        public ProductCategory()
        {
            Children = new HashSet<ProductCategory>();
            Products = new HashSet<Product>();
        }

        public Guid ProductCategoryId { get; set; }
        public string ProductCategoryName { get; set; }
        public Guid? ParentId { get; set; }

        public virtual ProductCategory Parent { get; set; }
        public virtual ICollection<ProductCategory> Children { get; set; }
        public virtual ICollection<Product> Products { get; set; }

        public IEnumerable<ProductCategory> AllChildren()
        {
            yield return this;
            foreach (var directChild in Children)
                foreach (var child in directChild.AllChildren())
                {
                    yield return child;
                }
        }
    }
}
