using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class LocationList
    {
        public int LocationListNumber { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public int? AgentNumber { get; set; }
        public DateTime? DeviceTime { get; set; }
        public DateTime? ServerTime { get; set; }
        public string Provider { get; set; }
        public double? Accuracy { get; set; }
        public string CorrectionService { get; set; }
        public double? NearAddressLongitude { get; set; }
        public double? NearAddressLatitude { get; set; }
        public string NearAddress { get; set; }
        public DateTime? LastModified { get; set; }
    }
}
