using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public class DebtCalcMethodType
    {
        public int DebtCalcMethodTypeId { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<DebtCalcMethodInfo> DebtCalcMethodInfo { get; set; }
    }
}
