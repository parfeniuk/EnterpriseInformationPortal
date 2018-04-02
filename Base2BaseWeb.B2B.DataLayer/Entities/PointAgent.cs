using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class PointAgent
    {
        public int PointAgentNumber { get; set; }
        public int? AgentNumber { get; set; }
        public int? PointNumber { get; set; }

        public Point AgentNumberNavigation { get; set; }
    }
}
