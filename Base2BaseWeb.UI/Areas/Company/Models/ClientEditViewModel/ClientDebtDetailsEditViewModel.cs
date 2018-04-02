using Base2BaseWeb.UI.Areas.Company.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Base2BaseWeb.UI.Areas.Company.Models.ClientEditViewModel
{
    public class ClientDebtDetailsEditViewModel
    {
        public ClientDebtDetailsEditViewModel()
        {
            DocumentTemplates = new HashSet<DocumentTemplateDto>();
            ServicePlaceholders = new HashSet<ServicePlaceholderDto>();
            PrintJobsView = new HashSet<PrintJobDto>();
            BillSettingsOptionsView = new HashSet<BillSettingsOptionsDto>();
        }
        private int _printJobsCapacity = 2;
        
        public int PrintJobsCapacity
        {
            get
            {
                return _printJobsCapacity;
            }
            private set
            {
                _printJobsCapacity = value;
            }
        }

        private int _billSettingsOptionsCapacity= 2;

        public int BillSettingsOptionsCapacity
        {
            get
            {
                return _billSettingsOptionsCapacity;
            }
            private set
            {
                _billSettingsOptionsCapacity = value;
            }
        }
        // Debt Calculation properties
        [Display(Name ="Отсрочка задолженности")]
        public bool GracePeriodLabel { get; set; }
        [Display(Name = "Ограничение задолженности клиента")]
        public bool SetLimitLabel { get; set; }
        [Display(Name = "Оповещение клиента")]
        public string NotificationLabel { get; set; }

        public DebtControlDto DebtControl { get; set; }
        public DebtCalcMethodDto DebtCalcMethod { get; set; }
        public BillSettingsDto BillSettings { get; set; }
        public FranchisingDto Franchising { get; set; }
        // PrintJob View Properties
        [Display(Name="Назначение задания печати")]
        public bool AssignPrintJob { get; set; }
        [Display(Name ="Счет")]
        public bool IsBill { get; set; }
        [Display(Name = "Акт")]
        public bool IsAct { get; set; }
        public ICollection<PrintJobDto> PrintJobsView { get; set; }
        // Documents Collections
        public ICollection<ServicePlaceholderDto> ServicePlaceholders { get; set; }

        public ICollection<DocumentTemplateDto> DocumentTemplates { get; set; }

        [Display(Name ="Шаблон счета")]
        public string BillTemplatesLabel { get { return string.Empty; } }
        [Display(Name = "Шаблон акта")]
        public string ActTemplatesLabel { get { return string.Empty; } }

        [Display(Name = "Дополнительные параметры актов:")]
        public string ActOptionsLabel { get { return string.Empty; } }
        [Display(Name = "")]
        public bool IsActiveActOption { get; set; }
        public ICollection<BillSettingsOptionsDto> BillSettingsOptionsView { get; set; }

        // Client Connection Properties
        public ClientConnectionDto ClientConnection { get; set; }
    }
}
