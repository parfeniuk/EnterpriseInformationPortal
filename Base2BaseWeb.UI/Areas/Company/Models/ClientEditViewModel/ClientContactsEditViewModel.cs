using Base2BaseWeb.B2B.DataLayer.Entities;
using Base2BaseWeb.UI.Areas.Company.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Base2BaseWeb.UI.Areas.Company.Models.ClientEditViewModel
{
    public class ClientContactsEditViewModel
    {
        public ClientContactsEditViewModel()
        {
            ContactPhonesAll = new List<ContactPhoneDto>();
            ContactEmailsAll = new List<ContactEmailDto>();

            ContactPhonesView= new List<ContactPhoneDto>(_contactPhonesCapacity);
            ContactEmailsView = new List<ContactEmailDto>(_contactEmailsCapacity);
        }
        private int _contactPhonesCapacity=2;
        private int _contactEmailsCapacity=4;

        public int ContactPhonesCapacity
        {
            get
            {
                return _contactPhonesCapacity;
            }
            private set
            {
                _contactPhonesCapacity = value;
            }
        }
        public int ContactEmailsCapacity
        {
            get
            {
                return _contactEmailsCapacity;
            }
            private set
            {
                _contactEmailsCapacity = value;
            }
        }

        public int Id { get; set; }
        // Contact's data properties
        [Display(Name ="Юридический адрес")]
        public string LegalAddress { get; set; }
        [Display(Name = "Фактический адрес")]
        public string ActualAddress { get; set; }
        [Display(Name = "Почтовый адрес")]
        public string MailAddress { get; set; }
        [Display(Name = "Первая подпись")]
        public string FirstSignatory { get; set; }
        [Display(Name = "Вторая подпись")]
        public string SecondSignatory { get; set; }
        [Display(Name ="Телефон")]
        public string PhoneNumber1 { get; set; }
        [Display(Name = "")]
        public string ContactFullName1 { get; set; }
        [Display(Name = "Адрес e-mail")]
        public string Email1 { get; set; }
        [Display(Name = "автоматическая рассылка")]
        public bool IncludeToMailList { get; set; }

        public List<ContactPhoneDto> ContactPhonesView { get; set; }
        [Display(Name = "Адрес e-mail")]
        public List<ContactEmailDto> ContactEmailsView { get; set; }

        public List<ContactPhoneDto> ContactPhonesAll { get; set; }
        public List<ContactEmailDto> ContactEmailsAll { get; set; }
    }
}
