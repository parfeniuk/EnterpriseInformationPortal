using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public class DebtCalcMethodInfo
    {
        public int DebtCalcMethodInfoId { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public bool Active { get; set; }

        public int PointNumber { get; set; }
        public virtual Point Point { get; set; }
    }
}
