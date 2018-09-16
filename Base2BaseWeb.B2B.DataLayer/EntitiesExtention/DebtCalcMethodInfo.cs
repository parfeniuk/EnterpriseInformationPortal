using System.ComponentModel;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public class DebtCalcMethodInfo
    {
        public int DebtCalcMethodInfoId { get; set; }

        public int? DebtCalcMethodTypeId { get; set; }
        public virtual DebtCalcMethodType DebtCalcMethodTypes { get; set; }

        public int? PointNumber { get; set; }
        public virtual Point Point { get; set; }
    }
}
