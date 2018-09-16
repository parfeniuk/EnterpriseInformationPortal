using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Base2BaseWeb.UI.Areas.Company.DTO.Tickets
{
    public class TicketCreateDto
    {
        public TicketCreateDto()
        {
            TicketSubjectFirstChildrenId = new List<int>();
            TicketSubjectLastChildrenId = new List<int>();
        }
        // Properties
        [Display(Name = "Группа")]
        public int GroupId { get; set; }
        [Display(Name = "Клиент")]
        public int ClientId { get; set; }
        [Display(Name = "Точка")]
        public int BranchId { get; set; }
        [Display(Name = "Канал")]
        public int PointCommunicationTypeId { get; set; }
        
        //public int PointContactPersonPositionTypeId { get; set; }
        [Display(Name = "Должность")]
        public string PointContactPersonPositionType { get; set; }

        //public int PointContactPersonId { get; set; }
        [Display(Name = "ФИО")]
        public string PointContactPersonName { get; set; }

        [Display(Name = "Телефон")]
        public int PointContactPhoneId { get; set; }
        [Display(Name = "Тема заявки")]
        public int TicketSubjectParentId { get; set; }
        [Display(Name = "Подтема")]
        public List<int> TicketSubjectFirstChildrenId { get; set; }
        [Display(Name = "Варианты решения")]
        public List<int> TicketSubjectLastChildrenId { get; set; }
        [Display(Name = "Время создания")]
        public DateTime? DateCreated { get; set; }
    }
}
