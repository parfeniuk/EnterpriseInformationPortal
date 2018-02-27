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

        //public bool IsEmailConfirmed { get; set; }

        [Required(ErrorMessage = "Поле {0} является обязательным")]
        [StringLength(50, ErrorMessage = "{0} не должно превышать {1} символов")]
        [Display(Name = "Имя")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Поле {0} является обязательным")]
        [StringLength(50, ErrorMessage = "{0} не должно превышать {1} символов")]
        [Display(Name = "Отчество")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Поле {0} является обязательным")]
        [StringLength(50, ErrorMessage = "{0} не должно превышать {1} символов")]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }

        [Display(Name ="Дата рождения")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [DataType(DataType.DateTime)]
        public DateTime DateBirth { get; set; }

        //[Required(ErrorMessage = "Поле {0} является обязательным")]
        //[StringLength(100, ErrorMessage = "{0} не должно превышать {1} символов")]
        //[Display(Name = "Организация")]
        //public string CompanyName { get; set; }

        //[Required(ErrorMessage = "Поле {0} является обязательным")]
        //[EmailAddress(ErrorMessage = "Введенное значение не является действительным адресом электронной почты")]
        //[Display(Name = "Эл. почта")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле {0} является обязательным")]
        [Phone(ErrorMessage = "Введенное значение не является действительным номером телефона")]
        [Display(Name = "Телефон")]
        public string PhoneNumber { get; set; }

        public string StatusMessage { get; set; }
    }
}
