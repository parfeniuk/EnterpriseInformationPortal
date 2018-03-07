using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Base2BaseWeb.UI.Areas.Admin.Models.ClientViewModel
{
    public class ClientEditViewModel
    {
        public string ClientId { get; set; }

        [Required(ErrorMessage = "Поле {0} является обязательным")]
        [StringLength(50, ErrorMessage = "{0} не должно превышать {1} символов")]
        [Display(Name = "Наименование клиента")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Поле {0} является обязательным")]
        [Display(Name = "Краткое описание клиента")]
        public string ShortDescription { get; set; }

        [Display(Name = "Описание клиента")]
        public string Description { get; set; }

        [Display(Name = "Ссылка на сайт клиента")]
        public string HttpUrl { get; set; }

        [Display(Name = "Путь к файлу")]
        public string ImagePath { get; set; }

        [Display(Name = "Использовать в галерее изображений")]
        public bool ImageIsPoster { get; set; }

        [Display(Name = "Выбор изображения")]
        public IFormFile ImageUpload { get; set; }
    }
}
