using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.DataLayer.Entities
{
    public class Company
    {
        public Company()
        {
            CompanyImages = new HashSet<CompanyImage>();
        }

        public Guid CompanyId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }

        public virtual ICollection<CompanyImage> CompanyImages { get; set; }
    }
}
