using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class DocStan
    {
        public DocStan()
        {
            Nakl = new HashSet<Nakl>();
        }

        public int DocStanId { get; set; }
        public string NameStan { get; set; }

        public ICollection<Nakl> Nakl { get; set; }
    }
}
