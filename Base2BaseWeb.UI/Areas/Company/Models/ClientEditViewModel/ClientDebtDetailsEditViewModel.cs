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
            DocumentTemplatesAll = new List<DocumentTemplateDto>();
            ServicePlaceholdersAll = new List<ServicePlaceholderDto>();
            PrintJobsAll = new List<PrintJobDto>();
            BillOptionsAll = new List<BillOptionsDto>();
            DebtCalcMethodsAll = new List<DebtCalcMethodTypeDto>();
            FranchisingTypesAll = new List<FranchisingTypeDto>();
            FranchisingClients = new List<FranchisingClientDto>();
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

        private int _billOptionsCapacity = 2;

        public int BillOptionsCapacity
        {
            get
            {
                return _billOptionsCapacity;
            }
            private set
            {
                _billOptionsCapacity = value;
            }
        }

        public int Id { get; set; }
        // LABELS and CAPTIONS
            // Debt Control & Debt Calc Labels
        public string DebtControlCaption { get { return "Контроль задолженности"; } }
        [Display(Name ="Отсрочка задолженности")]
        public bool GracePeriodLabel { get; set; }
        [Display(Name = "Ограничение задолженности клиента")]
        public bool SetLimitLabel { get; set; }
        public string ClientNotificationCaption { get { return "Оповещение клиента:"; } }
        public string GracePeriodUnits { get { return "дней"; } }
        public string DebtLimitUnits { get { return "грн."; } }
        public string NotificationUnits { get { return "дней"; } }
        public string DebtCalcMethodCaption { get { return "Метод расчета"; } }
            // Franchising Labels
        public string FranchisingCaption { get { return "Франчайзинг"; } }
        [Display(Name = "Использовать франчайзинг")]
        public bool UseFranchisingLabel { get; set; }
            // Documents (Bills and Acts) Settings
        public string BillTemplatesCaption { get { return "Формирование документов"; } }
        [Display(Name = "Шаблон счета")]
        public string BillTemplatesLabel { get { return "Шаблон счета"; } }
        [Display(Name = "Шаблон акта")]
        public string ActTemplatesLabel { get { return string.Empty; } }
            // Bill(Act) Options Labels
        [Display(Name = "Дополнительные параметры актов:")]
        public string BillOptionsLabel { get { return string.Empty; } }
        [Display(Name = "")]
        public bool IsActiveActOption { get; set; }
            // PrintJobs Settings Labels
        [Display(Name = "Назначение задания печати")]
        public bool AssignPrintJobLabel { get; set; }
        [Display(Name = "Счет")]
        public bool IsBill { get; set; }
        [Display(Name = "Акт")]
        public bool IsAct { get; set; }

        [Display(Name = "Заменять список услуг в документах на:")]
        public bool ReplaceServiceList { get; set; }

        // Connection Labels
        public string ConnectionCaption { get { return "Источник данных для расчета"; } }

        // DTO Properties
        public int DebtCalcMethodTypeId { get; set; }
        public int FranchisingTypeId { get; set; }
        public int FranchisingClientId { get; set; }

        public DebtControlDto DebtControl { get; set; }
        public BillSettingsDto BillSettings { get; set; }
        public ClientConnectionDto ClientConnection { get; set; }
        //public PrintJobDto PrintJob { get; set; }
        //public FranchisingDto Franchising { get; set; }

        // Collections for SelectLists
        public List<DocumentTemplateDto> DocumentTemplatesAll { get; set; }
        public List<ServicePlaceholderDto> ServicePlaceholdersAll { get; set; }
        public List<FranchisingClientDto> FranchisingClients { get; set; }
        
        // Collections for Checklists
        //     One-to-one relation with Point
        public List<DebtCalcMethodTypeDto> DebtCalcMethodsAll { get; set; }
        public List<FranchisingTypeDto> FranchisingTypesAll { get; set; }
        //     One-to-many relation with Point
        public List<BillOptionsDto> BillOptionsAll { get; set; }
        public List<PrintJobDto> PrintJobsAll { get; set; }
    }
}