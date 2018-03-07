using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Base2BaseWeb.UI.Areas.Admin.Models.ProductCategoryViewModel
{
    public class ProductCategoryCreateViewModel
    {
        [Required(ErrorMessage = "Поле {0} является обязательным")]
        [StringLength(100, ErrorMessage = "{0} не должно превышать {1} символов")]
        [Display(Name = "Категория продуктов")]
        public string Name { get; set; }

    }
}
