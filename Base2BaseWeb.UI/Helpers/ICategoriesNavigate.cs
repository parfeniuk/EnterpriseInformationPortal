using Base2BaseWeb.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Base2BaseWeb.UI.Helpers
{
    public interface ICategoriesNavigate
    {
       ICollection<ProductCategory> GetAllChildren(Guid key);
    }
}
