using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.DataLayer.Entities
{
    public class ClientSegmentFeature
    {
        public Guid ClientSegmentFeatureId { get; set; }
        public Guid ClientSegmentId { get; set; }
        public string Name { get; set; }
        public string FontType { get; set; }
        public string FontIconName { get; set; }
        public string ImagePath { get; set; }

        public virtual ClientSegment ClientSegment { get; set; }
    }
}
