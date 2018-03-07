using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.DataLayer.Entities
{
    public class ClientImage
    {
        public Guid ClientImageId { get; set; }
        public Guid ClientId { get; set; }
        public string Path { get; set; }
        public bool IsPoster { get; set; }

        public virtual Client Client { get; set; }
    }
}
