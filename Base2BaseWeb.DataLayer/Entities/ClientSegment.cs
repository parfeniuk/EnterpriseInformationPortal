using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.DataLayer.Entities
{
    public class ClientSegment
    {
        public Guid ClientSegmentId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ClientSegmentImage> ClientSegmentImages { get; set; }
        public virtual ICollection<ClientSegmentFeature> ClientSegmentFeatures { get; set; }
    }
}
