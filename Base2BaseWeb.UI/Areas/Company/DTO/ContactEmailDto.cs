using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Base2BaseWeb.UI.Areas.Company.DTO
{
    public class ContactEmailDto
    {
        public int ContactEmailInfoId { get; set; }
        [Display(Name ="Email")]
        public string Email { get; set; }
        public bool IncludeToMailList { get; set; }
    }
}
