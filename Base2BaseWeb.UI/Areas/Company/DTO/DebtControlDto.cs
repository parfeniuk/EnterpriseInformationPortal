using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Base2BaseWeb.UI.Areas.Company.DTO
{
    public class DebtControlDto
    {
        public int DebtControlInfoId { get; set; }
        [Display(Name = "Период отсрочки")]
        public int GracePeriod { get; set; }
        [Display(Name = "Максимально допустимая")]
        public double DebtLimit { get; set; }
        [Display(Name = "Периодичность")]
        public int NotificationFrequency { get; set; }
        [Display(Name = "email")]
        public bool NotifyByEmail { get; set; }
        [Display(Name = "SMS")]
        public bool NotifyBySms { get; set; }
        [Display(Name = "Viber")]
        public bool NotifyByViber { get; set; }
    }
}
