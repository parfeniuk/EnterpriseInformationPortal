using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.DataLayer.Entities
{
    public class CompanyImage
    {
        public Guid CompanyImageId { get; set; }
        public Guid CompanyId { get; set; }
        public string Path { get; set; }
        public bool IsPoster { get; set; }

        public virtual Company Company { get; set; }
    }
}
