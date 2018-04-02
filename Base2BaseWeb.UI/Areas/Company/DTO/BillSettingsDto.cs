using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Base2BaseWeb.UI.Areas.Company.DTO
{
    public class BillSettingsDto
    {
        public int BillSettingsInfoId { get; set; }
        [Display(Name ="Автоматическое выставление счетов")]
        public bool AutomaticBilling { get; set; }
        [Display(Name = "Отправка на email")]
        public bool SendByEmail { get; set; }
        [Display(Name = "Заменять список услуг в документах на:")]
        public bool ReplaceServiceList { get; set; }

        public virtual DocumentTemplateDto DocumentTemplate { get; set; }
        public virtual ICollection<PrintJobDto> PrintJobInfo { get; set; }
        public virtual ICollection<BillSettingsOptionsDto> BillSettingsOptionsInfo { get; set; }
    }
}
