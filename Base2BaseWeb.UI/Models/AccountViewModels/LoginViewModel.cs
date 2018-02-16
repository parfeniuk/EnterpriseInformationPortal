using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Base2BaseWeb.UI.Models.AccountViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Поле {0} является обязательным")]
        [EmailAddress(ErrorMessage = "Введенное значение не является действительным адресом электронной почты")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле {0} является обязательным")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}
