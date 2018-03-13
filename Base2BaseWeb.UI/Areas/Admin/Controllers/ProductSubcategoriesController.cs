using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Base2BaseWeb.DataLayer.Entities;
using Base2BaseWeb.UI.Areas.Admin.Models.ProductSubcategoryViewModel;
using Base2BaseWeb.UI.Areas.Admin.Models.ProductViewModel;
using Base2BaseWeb.UI.Helpers;
using Base2BaseWeb.UI.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using RepositoryGeneric;

namespace Base2BaseWeb.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductSubCategoriesController : Controller
    {
        private IRepositoryContextBase _context;
        private IOptions<ImageSettings> _optionsAccessor;
        private IFilesHelper _filesHelper;

        public ProductSubCategoriesController(IRepositoryContextBase context, 
            IOptions<ImageSettings> optionsAccessor, IFilesHelper filesHelper)
        {
            _context = context;
            _optionsAccessor = optionsAccessor;
            _filesHelper = filesHelper;
        }

        public IActionResult Index()
        {
            var model = _context.Set<ProductCategory>().GetAll();
            return View(model);
        }

        public IActionResult ProductCatalog(string id)
        {
            var model = _context.Set<ProductSubCategory>()
                .FindBy(p=>p.ProductCategoryId.ToString()==id)
                .Include(p => p.ProductSubCategoryImages);
            return View(model);
        }

        public IActionResult Create(string id)
        {
            return View(new ProductSubcategoryCreateViewModel() {ProductCategoryId=id});
        }

        [HttpPost]
        public IActionResult Create(ProductSubcategoryCreateViewModel model)
        {
            string[] validImageTypes = new string[]
            {
                "image/gif",
                "image/jpeg",
                "image/pjpeg",
                "image/png",
                "image/x-icon"
            };
            // Check on null or zero length file
            if (model.ImageUpload == null || model.ImageUpload.Length == 0)
                ModelState.AddModelError("ImageUpload", "Изображение не может быть пустым");
            // Check on image file
            else if (!validImageTypes.Contains(model.ImageUpload.ContentType))
                ModelState.AddModelError("ImageUpload", "Изображение должно быть в формате JPG, GIF, PNG или ICO");
            // Create new Client
            if (ModelState.IsValid)
            {
                // Add new Client
                ProductSubCategory productSubCategory = new ProductSubCategory
                {
                    ProductCategoryId = new Guid(model.ProductCategoryId),
                    Name = model.Name,
                    Title=model.Title,
                    ShortDescription = model.ShortDescription,
                };
                // Add Client's Image

                // Copy File To Server
                string pathDir = _optionsAccessor.Value.ProductSubCategoryImages;
                string pathFileName = Guid.NewGuid().ToString();
                string pathFileExt = Path.GetExtension(model.ImageUpload.FileName);

                _filesHelper.Copy(pathDir, pathFileName + pathFileExt, model.ImageUpload);

                // Add related record - reference on file, in Database
                ProductSubCategoryImage productSubCategoryImage = new ProductSubCategoryImage
                {
                    IsPoster = true,
                    Path = @"\" + pathDir + pathFileName + pathFileExt
                };
                productSubCategory.ProductSubCategoryImages.Add(productSubCategoryImage);
                _context.Set<ProductSubCategory>().Add(productSubCategory);
                return RedirectToAction("Index");
            }
            // If Model is not valid
            return View(model);
        }
        public IActionResult Edit(string id)
        {
            //Client client = _context.Set<Client>().Find(new Guid(id));
            ProductSubCategory productSubCategory = _context.Set<ProductSubCategory>()
                .FindBy(p => p.ProductSubCategoryId == new Guid(id))
                .Include(p => p.ProductSubCategoryImages)
                .FirstOrDefault();

            if (productSubCategory == null) return NotFound($"Продукт с id: {id} не найден");

            ProductSubcategoryEditViewModel model = new ProductSubcategoryEditViewModel();
            model.ProductSubcategoryId = id;
            model.Name = productSubCategory.Name;
            model.Title = productSubCategory.Title;
            model.ShortDescription = productSubCategory.ShortDescription;
            if (productSubCategory.ProductSubCategoryImages.FirstOrDefault() != null)
            {
                model.ImagePath = productSubCategory.ProductSubCategoryImages.FirstOrDefault().Path;
                model.ImageIsPoster = productSubCategory.ProductSubCategoryImages.FirstOrDefault().IsPoster;
            }
            else
            {
                model.ImagePath = "";
                model.ImageIsPoster = false;
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(ProductSubcategoryEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                string[] validImageTypes = new string[]
                {
                    "image/gif",
                    "image/jpeg",
                    "image/pjpeg",
                    "image/png",
                    "image/x-icon"
                };
                // Find existed Client by Id
                ProductSubCategory productSubCategory = _context.Set<ProductSubCategory>()
                    .FindBy(p => p.ProductSubCategoryId == new Guid(model.ProductSubcategoryId))
                    .Include(p => p.ProductSubCategoryImages)
                    .FirstOrDefault();
                if (productSubCategory != null)
                {
                    // Update Client's Properties
                    productSubCategory.Name = model.Name;
                    productSubCategory.Title = model.Title;
                    productSubCategory.ShortDescription = model.ShortDescription;
                }
                else
                {
                    return NotFound($"Продукт с id: {model.ProductSubcategoryId} не найден");
                }
                //// Check on null or zero length file
                if (model.ImageUpload != null && model.ImageUpload.Length > 0)
                {
                    if (validImageTypes.Contains(model.ImageUpload.ContentType))
                    {
                        // Remove existed File from Server
                        string pathDir = _optionsAccessor.Value.ProductSubCategoryImages;
                        string pathExistedFile = productSubCategory.ProductSubCategoryImages
                            .FirstOrDefault()?.Path.Substring(1);
                        if (!string.IsNullOrEmpty(pathExistedFile))
                        {
                            _filesHelper.Delete(pathExistedFile);
                        }
                        // Copy New File to Server
                        string pathNewFileName = Guid.NewGuid().ToString();
                        string pathNewFileExt = Path.GetExtension(model.ImageUpload.FileName);
                        string pathNewFile = pathDir + pathNewFileName + pathNewFileExt;

                        _filesHelper.Copy(pathDir, pathNewFileName + pathNewFileExt, model.ImageUpload);

                        // SYNC changes to Database
                        ProductSubCategoryImage productSubCategoryNewImage = new ProductSubCategoryImage
                        {
                            IsPoster = true,
                            Path = @"\" + pathDir + pathNewFileName + pathNewFileExt
                        };

                        // Find existed image
                        ProductSubCategoryImage productSubCategoryExistedImage = 
                            productSubCategory.ProductSubCategoryImages.FirstOrDefault();

                        // Remove previous image
                        if (productSubCategoryExistedImage != null)
                        {
                            productSubCategory.ProductSubCategoryImages.Remove(productSubCategoryExistedImage);
                        }
                        productSubCategory.ProductSubCategoryImages.Add(productSubCategoryNewImage);
                    }
                    //// Update DB
                    _context.Set<ProductSubCategory>().Update(productSubCategory, new Guid(model.ProductSubcategoryId));
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("ImageUpload", "Файл пустой или не в формате JPG, GIF, PNG или ICO");
                }
            }
            // If Model has errors
            return View(model);
        }

        public IActionResult Delete(string id)
        {
             ProductSubCategory productSubCategory = _context.Set<ProductSubCategory>()
                .FindBy(c => c.ProductSubCategoryId == new Guid(id))
                .Include(cl => cl.ProductSubCategoryImages)
                .FirstOrDefault();

            if (productSubCategory != null)
            {
                // Delete related Image files from Server
                string pathExistedFile = productSubCategory.ProductSubCategoryImages.FirstOrDefault().Path.Substring(1);
                _filesHelper.Delete(pathExistedFile);
                // Delete related record from Database
                _context.Set<ProductSubCategory>().Delete(productSubCategory);
                return RedirectToAction("Index");
            }
            else
            {
                return NotFound($"Клиент с id: {id} не найден");
            }
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
            base.Dispose(disposing);
        }
    }
}