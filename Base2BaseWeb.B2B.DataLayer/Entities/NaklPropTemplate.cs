using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class NaklPropTemplate
    {
        public int NaklPropTemplateNumber { get; set; }
        public string TemplateName { get; set; }
        public bool DefaultTemplate { get; set; }
        public int? NaklType { get; set; }
    }
}
