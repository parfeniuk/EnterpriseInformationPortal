using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public class DocumentTemplate
    {
        public DocumentTemplate()
        {
            BillSettingsInfo = new HashSet<BillSettingsInfo>();
            BillOptionsInfo = new HashSet<BillOptionsInfo>();
            PrintJobInfo = new HashSet<PrintJobInfo>();
        }
        public int DocumentTemplateId { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int? DocumentTemplateCategoryId { get; set; }
        public virtual DocumentTemplateCategory DocumentTemplateCategory { get; set; }

        public virtual ICollection<BillSettingsInfo> BillSettingsInfo { get; set; }
        public virtual ICollection<BillOptionsInfo> BillOptionsInfo { get; set; }
        public virtual ICollection<PrintJobInfo> PrintJobInfo { get; set; }
    }
}
