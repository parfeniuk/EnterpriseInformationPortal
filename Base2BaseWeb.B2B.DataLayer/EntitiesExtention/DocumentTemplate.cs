using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public class DocumentTemplate
    {
        public int DocumentTemplateId { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int? DocumentTemplateCategoryId { get; set; }
        public virtual DocumentTemplateCategory DocumentTemplateCategory { get; set; }
        public virtual BillSettingsInfo BillSettingsInfo { get; set; }
        public virtual BillOptionsInfo BillOptionsInfo { get; set; }
        public virtual PrintJobInfo PrintJobInfo { get; set; }
    }
}
