using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.DataLayer.Entities
{
    public class Client
    {
        public Client()
        {
            ClientImages = new HashSet<ClientImage>();
        }

        public Guid ClientId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string HttpUrl { get; set; }

        public virtual ICollection<ClientImage> ClientImages { get; set; }
    }
}
