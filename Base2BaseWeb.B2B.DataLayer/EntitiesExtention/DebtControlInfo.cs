using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public class DebtControlInfo
    {
        public int DebtControlInfoId { get; set; }
        public int GracePeriod { get; set; }
        public double DebtLimit { get; set; }
        public int NotificationFrequency { get; set; }
        public bool NotifyByEmail { get; set; }
        public bool NotifyBySms { get; set; }
        public bool NotifyByViber { get; set; }

        public int? PointNumber { get; set; }
        public virtual Point Point { get; set; }
    }
}
