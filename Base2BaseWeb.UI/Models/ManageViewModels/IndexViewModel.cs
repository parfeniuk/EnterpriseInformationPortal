using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Base2BaseWeb.UI.Models.ManageViewModels
{
    public class IndexViewModel
    {
        public string Username { get; set; }

        public bool IsEmailConfirmed { get; set; }

        [Required(ErrorMessage = "Поле {0} является обязательным")]
        [EmailAddress(ErrorMessage = "Введенное значение не является действительным адресом электронной почты")]
        [Display(Name = "Эл. почта")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле {0} является обязательным")]
        [Phone(ErrorMessage = "Введенное значение не является действительным номером телефона")]
        [Display(Name = "Телефон")]
        public string PhoneNumber { get; set; }

        public string StatusMessage { get; set; }
    }
}
