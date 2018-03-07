using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Base2BaseWeb.DataLayer.Entities;
using Base2BaseWeb.UI.Areas.Admin.Models.ProductCategoryViewModel;
using Base2BaseWeb.UI.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using RepositoryGeneric;

namespace Base2BaseWeb.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductCategoriesController : Controller
    {
        private IRepositoryContextBase _context;

        public ProductCategoriesController(IRepositoryContextBase context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model = _context.Set<ProductCategory>().GetAll();
            return View(model);
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