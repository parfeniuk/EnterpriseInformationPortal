﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public class PrintJobInfo
    {
        public int PrintJobInfoId { get; set; }
        public int DocumentToPrintCopies { get; set; }

        public int? DocumentTemplateId { get; set; }
        public DocumentTemplate DocumentTemplate { get; set; }

        public int? PointNumber { get; set; }
        public virtual Point Point { get; set; }
    }
}
