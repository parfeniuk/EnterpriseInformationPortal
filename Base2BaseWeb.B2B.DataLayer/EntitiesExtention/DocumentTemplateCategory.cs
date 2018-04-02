using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public class DocumentTemplateCategory
    {
        public DocumentTemplateCategory()
        {
            DocumentTemplates = new HashSet<DocumentTemplate>();
        }

        public int DocumentTemplateCategoryId { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public virtual ICollection<DocumentTemplate> DocumentTemplates { get; set; }
    }
}
