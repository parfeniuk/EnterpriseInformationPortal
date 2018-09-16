using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base2BaseWeb.DataLayer.Entities;
using Base2BaseWeb.DataLayer.Repository;
using Base2BaseWeb.UI.Areas.Admin.Models.ClientViewModel;
using Base2BaseWeb.UI.Helpers;
using Base2BaseWeb.UI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using RepositoryGeneric;

namespace Base2BaseWeb.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ClientsController : Controller
    {
        private IRepositoryWebB2B _context;
        private IHostingEnvironment _environment;
        private IOptions<ImageSettings> _optionsAccessor;
        private IFilesHelper _filesHelper;

        public ClientsController(IRepositoryWebB2B context,IHostingEnvironment environment, 
            IOptions<ImageSettings> optionsAccessor,IFilesHelper filesHelper)
        {
            _context = context;
            _environment = environment;
            _optionsAccessor = optionsAccessor;
            _filesHelper = filesHelper;
        }

        public IActionResult Index()
        {
            var model = _context.Set<Client>().GetAll().Include(c=>c.ClientImages);
            return View(model);
        }

        public IActionResult Create()
        {
            return View(new ClientCreateViewModel());
        }

        [HttpPost]
        public IActionResult Create(ClientCreateViewModel model)
        {
            string[] validImageTypes = new string[]
            {
                "image/gif",
                "image/jpeg",
                "image/pjpeg",
                "image/png"
            };
            // Check on null or zero length file
            if (model.ImageUpload == null || model.ImageUpload.Length == 0)
                ModelState.AddModelError("ImageUpload", "Изображение не может быть пустым");
            // Check on image file
            else if (!validImageTypes.Contains(model.ImageUpload.ContentType))
                ModelState.AddModelError("ImageUpload", "Изображение должно быть в формате JPG, GIF или PNG");
            // Create new Client
            if (ModelState.IsValid)
            {
                // Add new Client
                Client client = new Client
                {
                    Name = model.Name,
                    ShortDescription = model.ShortDescription,
                    Description = model.Description,
                    HttpUrl = model.HttpUrl
                };
                // Add Client's Image
                
                // Copy File To Server
                string pathDir = _optionsAccessor.Value.ClientImages;
                string pathFileName = Guid.NewGuid().ToString();
                string pathFileExt = Path.GetExtension(model.ImageUpload.FileName);

                _filesHelper.Copy(pathDir, pathFileName + pathFileExt, model.ImageUpload);

                // Add related record - reference on file, in Database
                ClientImage clientImage = new ClientImage { IsPoster = true, Path = @"\"+ pathDir + pathFileName + pathFileExt };
                client.ClientImages.Add(clientImage);
                _context.Set<Client>().Add(client);
                return RedirectToAction("Index");
            }
            // If Model is not valid
            return View(model);
        }

        public IActionResult Edit(string id)
        {
            //Client client = _context.Set<Client>().Find(new Guid(id));
            Client client = _context.Set<Client>()
                .FindBy(c => c.ClientId == new Guid(id))
                .Include(cl => cl.ClientImages)
                .FirstOrDefault();

            if (client == null) return NotFound($"Клиент с id: {id} не найден");

            ClientEditViewModel clientEdited = new ClientEditViewModel();
            clientEdited.ClientId = id;
            clientEdited.Name = client.Name;
            clientEdited.ShortDescription = client.ShortDescription;
            clientEdited.Description = client.Description;
            clientEdited.HttpUrl = client.HttpUrl;
            if (client.ClientImages.FirstOrDefault() != null)
            {
                clientEdited.ImagePath = client.ClientImages.FirstOrDefault().Path;
                clientEdited.ImageIsPoster = client.ClientImages.FirstOrDefault().IsPoster;
            }
            else
            {
                clientEdited.ImagePath = "";
                clientEdited.ImageIsPoster = false;
            }
            return View(clientEdited);
        }

        [HttpPost]
        public IActionResult Edit(ClientEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                string[] validImageTypes = new string[]
                {
                "image/gif",
                "image/jpeg",
                "image/pjpeg",
                "image/png"
                };
                // Find existed Client by Id
                Client client = _context.Set<Client>()
                    .FindBy(c => c.ClientId == new Guid(model.ClientId))
                    .Include(cl => cl.ClientImages)
                    .FirstOrDefault();
                if (client != null)
                {
                    // Update Client's Properties
                    client.Name = model.Name;
                    client.ShortDescription = model.ShortDescription;
                    client.Description = model.Description;
                    client.HttpUrl = model.HttpUrl;
                }
                else
                {
                    return NotFound($"Клиент с id: {model.ClientId} не найден");
                }
                //// Check on null or zero length file
                if (model.ImageUpload != null && model.ImageUpload.Length > 0)
                {
                    if (validImageTypes.Contains(model.ImageUpload.ContentType))
                    {
                        // Remove existed File from Server
                        string pathDir = _optionsAccessor.Value.ClientImages;
                        string pathExistedFile = client.ClientImages.FirstOrDefault()?.Path.Substring(1);
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
                        ClientImage clientNewImage = new ClientImage
                        {
                            IsPoster = true,
                            Path = @"\" + pathDir + pathNewFileName + pathNewFileExt
                        };

                        // Find existed image
                        ClientImage clientExistedImage = client.ClientImages.FirstOrDefault();

                        // Remove previous image
                        if (clientExistedImage != null)
                        {
                            client.ClientImages.Remove(clientExistedImage);
                        }
                        client.ClientImages.Add(clientNewImage);
                    }
                    //// Update DB
                    _context.Set<Client>().Update(client, new Guid(model.ClientId));
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("ImageUpload", "Файл пустой или не в формате JPG, GIF или PNG");
                }
            }
            // If Model has errors
            return View(model);
        }

        public IActionResult Delete(string id)
        {
            Client client = _context.Set<Client>()
                .FindBy(c=>c.ClientId== new Guid(id))
                .Include(cl=>cl.ClientImages)
                .FirstOrDefault();
            
            if (client != null)
            {
                // Delete related Image files from Server
                string pathExistedFile = client.ClientImages.FirstOrDefault().Path.Substring(1);
                _filesHelper.Delete(pathExistedFile);

                // Delete related record from Database
                _context.Set<Client>().Delete(client);
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