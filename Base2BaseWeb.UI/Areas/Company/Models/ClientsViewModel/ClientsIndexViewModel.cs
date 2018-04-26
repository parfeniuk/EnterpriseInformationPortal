using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Base2BaseWeb.UI.Areas.Company.Models.ClientsViewModel
{
    public class ClientsIndexViewModel
    {
        public ClientsIndexViewModel()
        {
            Clients = new HashSet<Client>();
        }
        public IEnumerable<Client> Clients { get; set; }
        public string SearchString { get; set; }
    }
}
