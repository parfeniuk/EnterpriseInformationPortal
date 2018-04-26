using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Base2BaseWeb.UI.Areas.Company.DTO
{
    public class BillOptionsDto
    {
        public int BillOptionsInfoId { get; set; }
        [Display(Name = "Сумма >")]
        public double Limit { get; set; }
        public int? DocumentTemplateId { get; set; }
        public bool Active { get; set; }
    }
}
