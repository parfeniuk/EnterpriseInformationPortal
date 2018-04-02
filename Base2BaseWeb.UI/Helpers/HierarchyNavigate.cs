using Base2BaseWeb.DataLayer.Entities;
using Base2BaseWeb.DataLayer.Repository;
using RepositoryGeneric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Base2BaseWeb.UI.Helpers
{
    public class HierarchyNavigate:IHierarchyNavigate
    {
        IRepositoryContextBase _context;
        public HierarchyNavigate(IRepositoryContextBase context)
        {
            _context = context;
        }

        public List<ProductCategory> GetAllChildren(string id)
        {
            List<ProductCategory> list = new List<ProductCategory>();
            ProductCategory parentCategory = _context.Set<ProductCategory>().Find(new Guid(id));
            IEnumerable<ProductCategory> childCategory;
            if (parentCategory != null)
            {
                list.Add(parentCategory);
                List<string> listId = new List<string>();
                listId.Add(id);
                while ((childCategory = FindByParentId(listId)).Count()!=0)
                {
                    list.AddRange(childCategory);
                    listId= childCategory.Select(x=>x.ProductCategoryId.ToString()).ToList();
                }
                return list;
            }
            else return null;
        }

        private IEnumerable<ProductCategory> FindByParentId(string id)
        {
            IEnumerable<ProductCategory> categories = _context.Set<ProductCategory>()
                .FindBy(c => c.ParentId == new Guid(id));
            return categories;
        }

        private IEnumerable<ProductCategory> FindByParentId(IEnumerable<string> listId)
        {
            List<ProductCategory> children=new List<ProductCategory>();
            foreach (string id in listId)
            {
                if (_context.Set<ProductCategory>().FindBy(c => c.ParentId == new Guid(id)).Count() != 0)
                {
                    children.AddRange(_context.Set<ProductCategory>().FindBy(c => c.ParentId == new Guid(id)));
                }
            }
            return children;
        }
    }
}
