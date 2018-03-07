using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.DataLayer.Entities
{
    public class Base2BaseFeatureCategory
    {
        public Base2BaseFeatureCategory()
        {
            Base2BaseFeatures = new HashSet<Base2BaseFeature>();
        }

        public Guid Base2BaseFeatureCategoryId { get; set; }
        public string Base2BaseFeatureCategoryName { get; set; }

        public virtual ICollection<Base2BaseFeature> Base2BaseFeatures { get; set; }
    }
}
