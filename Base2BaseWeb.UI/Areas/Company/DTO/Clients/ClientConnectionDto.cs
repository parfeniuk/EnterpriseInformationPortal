using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Base2BaseWeb.UI.Areas.Company.DTO
{
    public class ClientConnectionDto
    {
        public int ClientConnectionInfoId { get; set; }
        [Display(Name ="Сервер")]
        public string ServerName { get; set; }
        [Display(Name = "База данных")]
        public string DatabaseName { get; set; }
        [Display(Name = "Логин")]
        public string Login { get; set; }
        [Display(Name = "Хэш пароля")]
        public string PasswordHash { get; set; }
    }
}
