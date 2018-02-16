using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Base2BaseWeb.UI.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required(ErrorMessage = "Поле {0} является обязательным")]
        [EmailAddress(ErrorMessage = "Введенное значение не является действительным адресом электронной почты")]
        [Display(Name = "Эл. почта")]
        public string Email { get; set; }
    }
}
