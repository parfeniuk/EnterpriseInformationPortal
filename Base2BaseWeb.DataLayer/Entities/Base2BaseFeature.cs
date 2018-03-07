using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.DataLayer.Entities
{
    public class Base2BaseFeature
    {
        public Guid Base2BaseFeatureId { get; set; }
        public Guid Base2BaseFeatureCategoryId { get; set; }

        public string Name { get; set; }
        public string FontType { get; set; }
        public string FontIconName { get; set; }
        public string ImagePath { get; set; }

        public virtual Base2BaseFeatureCategory Base2BaseFeatureCategory { get; set; }
    }
}
