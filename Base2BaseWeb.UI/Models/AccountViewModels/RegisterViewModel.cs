using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Base2BaseWeb.UI.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Поле {0} является обязательным")]
        [StringLength(50, ErrorMessage = "{0} не должно превышать {1} символов")]
        [Display(Name = "Имя")]
        public string UserName { get; set; }

        //[Required(ErrorMessage = "Поле {0} является обязательным")]
        //[StringLength(50, ErrorMessage = "{0} не должно превышать {1} символов")]
        //[Display(Name = "Отчество")]
        //public string MiddleName { get; set; }

        //[Required(ErrorMessage = "Поле {0} является обязательным")]
        //[StringLength(50, ErrorMessage = "{0} не должно превышать {1} символов")]
        //[Display(Name = "Фамилия")]
        //public string LastName { get; set; }

        [Required(ErrorMessage = "Поле {0} является обязательным")]
        [StringLength(100, ErrorMessage = "{0} не должно превышать {1} символов")]
        [Display(Name = "Организация")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "Поле {0} является обязательным")]
        [EmailAddress(ErrorMessage = "Введенное значение не является действительным адресом электронной почты")]
        [Display(Name = "Эл. почта")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле {0} является обязательным")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Введенное значение не является действительным номером телефона")]
        [Phone(ErrorMessage = "Введенное значение не является действительным номером телефона")]
        [Display(Name = "Телефон")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Поле {0} является обязательным")]
        [StringLength(100, ErrorMessage = "{0} должен быть не менее {2} и не более {1} символов.", MinimumLength = 8)]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Подтверждение пароля")]
        [Compare("Password", ErrorMessage = "Пароль и подтверждение пароля не совпадают.")]
        public string ConfirmPassword { get; set; }
    }
}
