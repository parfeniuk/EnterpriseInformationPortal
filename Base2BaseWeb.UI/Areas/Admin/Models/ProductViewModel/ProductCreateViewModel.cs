using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Base2BaseWeb.UI.Areas.Admin.Models.ProductViewModel
{
    public class ProductCreateViewModel
    {
        [Required(ErrorMessage = "Поле {0} является обязательным")]
        [StringLength(50, ErrorMessage = "{0} не должно превышать {1} символов")]
        [Display(Name = "Наименование продукта")]
        public string Name { get; set; }

        [Display(Name = "Предназначение продукта")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Поле {0} является обязательным")]
        [Display(Name = "Краткое описание продукта")]
        public string ShortDescription { get; set; }

        [Display(Name = "Описание продукта")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Поле {0} является обязательным")]
        [Display(Name = "Выбор изображения")]
        public IFormFile ImageUpload { get; set; }
    }
}
