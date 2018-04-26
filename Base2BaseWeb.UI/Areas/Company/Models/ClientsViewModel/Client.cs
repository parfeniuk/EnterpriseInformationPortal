using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Base2BaseWeb.UI.Areas.Company.Models.ClientsViewModel
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string GroupName { get; set; }
        public string ContactName { get; set; }
        public string PhoneNumber { get; set; }
        [DataType(DataType.Currency)]
        public double? Balance { get; set; }
        public DateTime? ContractStartDate { get; set; }
        public DateTime? ContractEndDate { get; set; }
    }
}
