using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.DataLayer.Entities
{
    public class ClientSegmentImage
    {
        public Guid ClientSegmentImageId { get; set; }
        public Guid ClientSegmentId { get; set; }
        public string Path { get; set; }

        public virtual ClientSegment ClientSegment { get; set; }
    }
}
