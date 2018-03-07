using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.DataLayer.Entities
{
    public class ProductSubCategoryFeature
    {
        public Guid ProductSubCategoryFeatureId { get; set; }
        public Guid ProductSubCategoryId { get; set; }
        public string Name { get; set; }
        public string FontType { get; set; }
        public string FontIconName { get; set; }
        public string ImagePath { get; set; }
    }
}
