using Base2BaseWeb.UI.Areas.Company.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Base2BaseWeb.UI.Areas.Company.Models.ClientEditViewModel
{
    public class ClientProductsEditViewModel
    {
        public ClientProductsEditViewModel()
        {
            ProductsAll = new List<ProductDto>();
            ProductsClient = new List<ProductDto>();
        }
        
        public int Id { get; set; }
        public List<ProductDto> ProductsAll { get; set; }
        public List<ProductDto> ProductsClient { get; set; }
    }
}
