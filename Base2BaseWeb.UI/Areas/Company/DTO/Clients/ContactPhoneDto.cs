using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Base2BaseWeb.UI.Areas.Company.DTO
{
    public class ContactPhoneDto
    {
        public int ContactPhoneInfoId { get; set; }
        [Display(Name = "")]
        public string ContactFullName { get; set; }
        [Display(Name = "Телефон")]
        public string PhoneNumber { get; set; }
    }
}
