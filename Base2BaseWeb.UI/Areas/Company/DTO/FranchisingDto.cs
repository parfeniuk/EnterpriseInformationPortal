using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Base2BaseWeb.UI.Areas.Company.DTO
{
    public class FranchisingDto
    {
        public int FranchisingInfoId { get; set; }
        [Display(Name ="Использовать франчайзинг")]
        public bool UseFranchising { get; set; }
        [Display(Name = "Франчайзер (держатель франшизы)")]
        public bool IsFranchisor { get; set; }
        [Display(Name = "Франчайзи (пользователь франшизы)")]
        public bool IsFranchisee { get; set; }
    }
}
