using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class MarketingActionRecords
    {
        public int MarketingActionRecordId { get; set; }
        public int? NaklNumber { get; set; }
        public int? MarketingActionId { get; set; }
        public int? MarketingToolId { get; set; }
        public double? PresentedPoints { get; set; }

        public Nakl NaklNumberNavigation { get; set; }
    }
}
