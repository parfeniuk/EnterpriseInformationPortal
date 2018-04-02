using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Base2BaseWeb.UI.Areas.Company.DTO
{
    public class DebtCalcMethodDto
    {
        public int DebtCalcMethodInfoId { get; set; }
        [Display(Name ="Метод расчета")]
        public string Name { get; set; }
        [Display(Name = "Метод расчета используется")]
        public bool Active { get; set; }
    }
}
