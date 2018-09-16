using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Base2BaseWeb.UI.Areas.Company.DTO
{
    public class PrintJobDto
    {
        public int PrintJobInfoId { get; set; }
        [Display(Name="кол-во копий")]
        public int DocumentToPrintCopies { get; set; }
        public int? DocumentTemplateId { get; set; }
        public bool Active { get; set; }
    }
}
