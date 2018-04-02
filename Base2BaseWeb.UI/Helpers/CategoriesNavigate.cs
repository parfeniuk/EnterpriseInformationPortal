using Base2BaseWeb.DataLayer.Entities;
using RepositoryGeneric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Base2BaseWeb.UI.Helpers
{
    public class CategoriesNavigate: ICategoriesNavigate
    {
        IRepositoryContextBase _context;
        public CategoriesNavigate(IRepositoryContextBase context)
        {
            _context = context;
        }

        public ICollection<ProductCategory> GetAllChildren(Guid id)
        {
            List<ProductCategory> categoriesList = new List<ProductCategory>();
            GetAllChildren(id, categoriesList);
            return categoriesList;
        }

        private void GetAllChildren(Guid id,ICollection<ProductCategory> categoriesList)
        {
            ProductCategory category = _context.Set<ProductCategory>().Find(id);
            categoriesList.Add(category);

            foreach (ProductCategory child in category.AllChildren())
            {
                GetAllChildren(id, categoriesList);
            }

        }
    }
}
