using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base2BaseWeb.DataLayer.Entities;
using Base2BaseWeb.DataLayer.Repository;
using Base2BaseWeb.UI.Areas.Admin.Models.ProductCategoryViewModel;
using Base2BaseWeb.UI.Helpers;
using Base2BaseWeb.UI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using RepositoryGeneric;

namespace Base2BaseWeb.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class ProductCategoriesController : Controller
    {
        private IRepositoryWebB2B _context;
        private IHierarchyNavigate _hierarchyNavigate;

        public ProductCategoriesController(IRepositoryWebB2B context,
            IHierarchyNavigate hierarchyNavigate)
        {
            _context = context;
            _hierarchyNavigate = hierarchyNavigate;
        }

        public IActionResult Index()
        {
            var model = _context.Set<ProductCategory>().GetAll();
            return View(model);
        }

        public IActionResult GetAllCategories()
        {
            //string id = "31686563-CA73-4DB7-B8F2-F055D6F46021";
            string id = "E03EEEAB-D95D-4290-837A-DD5D3DD55838";

            List<ProductCategory> list = _hierarchyNavigate.GetAllChildren(id);
            List<string> listCategories = new List<string>();
            foreach (ProductCategory category in list)
            {
                listCategories.Add(category.ProductCategoryName);
            }

            //List<string> childrenList = new List<string>();
            //foreach (ProductCategory category in list)
            //{
            //    if (category.Children.Count()!=0)
            //    {
            //        childrenList.Add(category.Children.FirstOrDefault().ProductCategoryName);
            //    }
            //}

            //StringBuilder sb = new StringBuilder();
            //ProductCategory category = _context.Set<ProductCategory>().Find(new Guid(id));
            //IEnumerable<ProductCategory> categories = _context.Set<ProductCategory>().GetAll();
            //IEnumerable<ProductCategory> list = categories
            //    .Where(c => c.ProductCategoryName.Equals("Subcategory No. 3"))
            //    .Flatten(null, p => p.Children);


            //foreach (ProductCategory category in categories)
            //{
            //    sb.Append("Directory: "+ category.ProductCategoryName);
            //    foreach (ProductCategory child in category.AllChildren())
            //    {
            //        if (category.ProductCategoryName != child.ProductCategoryName)
            //            sb.Append(" - "+ child.ProductCategoryName);
            //    }
            //}

            //foreach (ProductCategory c in category.AllChildren())
            //{
            //    foreach (ProductCategory child in c.AllChildren())
            //    {
            //        sb.Append(child.ProductCategoryName);
            //        sb.Append(";");
            //    }

            //}
            //List<string> subCategories=new List<string>();
            //var productCategories = _context.Set<ProductCategory>()
            //    .GetAll();
            //foreach (var category in productCategories)
            //{
            //    foreach (var child in category.AllChildren())
            //    {
            //        subCategories.Add(child.ProductCategoryName);
            //    }
            //}
            //return Json(listCategories);
            return Json(listCategories);
        }

        public IActionResult Create()
        {
            return View(new ProductCategoryCreateViewModel());
        }

        [HttpPost]
        public IActionResult Create(ProductCategoryCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                ProductCategory productCategory = new ProductCategory
                {
                    ProductCategoryName = model.Name
                };
                _context.Set<ProductCategory>().Add(productCategory);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Edit(string id)
        {
            ProductCategory productCategory = _context.Set<ProductCategory>().Find(new Guid(id));
            if (productCategory!=null)
            {
                ProductCategoryEditViewModel model = new ProductCategoryEditViewModel
                {
                    ProductCategoryId=id,
                    Name = productCategory.ProductCategoryName
                };
                return View(model);
            }
            return NotFound($"Категория продуктов с id: {id} не найдена");
        }

        [HttpPost]
        public IActionResult Edit(ProductCategoryEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                ProductCategory productCategory = _context.Set<ProductCategory>().Find(new Guid(model.ProductCategoryId));
                if (productCategory != null)
                {
                    productCategory.ProductCategoryName = model.Name;
                    _context.Set<ProductCategory>().Update(productCategory, new Guid(model.ProductCategoryId));
                    return RedirectToAction("Index");
                }
                else
                {
                    return NotFound($"Категория продуктов с id: {model.ProductCategoryId} не найдена");
                }
            }
            return View(model);
        }

        public IActionResult Delete(string id)
        {
            ProductCategory productCategory = _context.Set<ProductCategory>().Find(new Guid(id));
            if (productCategory != null)
            {
                _context.Set<ProductCategory>().Delete(productCategory);
                return RedirectToAction("Index");
            }
            return NotFound($"Категория продуктов с id: {id} не найдена");
        }
    }
}