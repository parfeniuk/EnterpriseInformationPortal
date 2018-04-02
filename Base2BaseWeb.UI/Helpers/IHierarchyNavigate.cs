using Base2BaseWeb.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Base2BaseWeb.UI.Helpers
{
    public interface IHierarchyNavigate
    {
        List<ProductCategory> GetAllChildren(string id);
    }
}
