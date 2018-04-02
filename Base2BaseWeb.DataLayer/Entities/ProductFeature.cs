using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.DataLayer.Entities
{
    public class ProductFeature
    {
        public Guid ProductFeatureId { get; set; }
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public string FontType { get; set; }
        public string FontIconName { get; set; }
        public string ImagePath { get; set; }

        public virtual Product Product { get; set; }
    }
}
