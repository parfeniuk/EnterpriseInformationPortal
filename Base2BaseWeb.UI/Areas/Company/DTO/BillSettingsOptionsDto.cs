using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Base2BaseWeb.UI.Areas.Company.DTO
{
    public class BillSettingsOptionsDto
    {
        public int BillSettingsOptionsInfoId { get; set; }
        [Display(Name = "Сумма >")]
        public double Limit { get; set; }
    }
}
