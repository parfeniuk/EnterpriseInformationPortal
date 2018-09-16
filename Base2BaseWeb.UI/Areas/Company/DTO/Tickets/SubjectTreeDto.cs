using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Base2BaseWeb.UI.Areas.Company.DTO.Tickets
{
    public class SubjectTreeDto
    {
        public int? ParentId { get; set; }
        public string Text { get; set; }
        public List<SubjectTreeDto> nodes { get; set; }

        public SubjectTreeDto()
        {
            nodes = new List<SubjectTreeDto>();
        }
    }
}
