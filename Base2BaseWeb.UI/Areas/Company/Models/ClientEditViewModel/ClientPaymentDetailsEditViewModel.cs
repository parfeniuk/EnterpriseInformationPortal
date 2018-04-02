using Base2BaseWeb.UI.Areas.Company.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Base2BaseWeb.UI.Areas.Company.Models.ClientEditViewModel
{
    public class ClientPaymentDetailsEditViewModel
    {
        public ClientPaymentDetailsEditViewModel()
        {
            Contractors = new HashSet<ContractorDto>();
        }

        // Bank's data properties
        [Display(Name = "Банк")]
        public string BankName { get; set; }
        [Display(Name = "Расчетный счет")]
        public string BankAccount { get; set; }
        [Display(Name = "МФО")]
        public string Mfo { get; set; }
        [Display(Name = "ОКПО")]
        public string Okpo { get; set; }
        [Display(Name = "Налоговый номер")]
        public string FiscalNumber { get; set; }
        [Display(Name = "Свидетельство")]
        public string Certificate { get; set; }
        // Agreement's data properties
        [Display(Name = "Договор номер")]
        public string ContractNumber { get; set; }
        [Display(Name ="Дата подписания")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [DataType(DataType.DateTime)]
        public DateTime? ContractStartDate { get; set; }
        [Display(Name = "Дата окончания")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [DataType(DataType.DateTime)]
        public DateTime? ContractEndDate { get; set; }
        public ICollection<ContractorDto> Contractors { get; set; }
    }
}
