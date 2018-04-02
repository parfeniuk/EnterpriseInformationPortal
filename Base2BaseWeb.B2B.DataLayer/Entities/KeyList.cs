using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class KeyList
    {
        public int KeyListNumber { get; set; }
        public string InitKey { get; set; }
        public string AnswerKey { get; set; }
        public DateTime? RegDate { get; set; }
    }
}
