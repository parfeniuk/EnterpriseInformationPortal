using Base2BaseWeb.B2B.DataLayer.Entities;
using Base2BaseWeb.UI.Areas.Company.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Base2BaseWeb.UI.Areas.Company.Models.ClientEditViewModel
{
    public class ClientEditViewModel
    {
        public int Id { get; set; }
        [Display(Name ="Наименование клиента")]
        public string Name { get; set; }
        public int CliGroupNumber { get; set; }
        [Display(Name = "Группа клиентов")]
        public ICollection<CliGroup> CliGroups { get; set; }

        // Products' Attributes
        public ICollection<Product> Products { get; set; }
    }
}
