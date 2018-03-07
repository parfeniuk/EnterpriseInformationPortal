using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.DataLayer.Entities
{
    public class ProductSubCategoryImage
    {
        public Guid ProductSubCategoryImageId { get; set; }
        public Guid ProductSubCategoryId { get; set; }
        public string Path { get; set; }
        public bool IsPoster { get; set; }

        public virtual ProductSubCategory ProductSubCategory { get; set; }
    }
}
