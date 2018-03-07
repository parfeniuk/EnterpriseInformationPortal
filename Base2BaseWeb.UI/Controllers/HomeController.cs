using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Base2BaseWeb.DataLayer.Entities;
using Base2BaseWeb.UI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepositoryGeneric;

namespace Base2BaseWeb.UI.Controllers
{
    
    public class HomeController : Controller
    {
        private IRepositoryContextBase _context;

        public HomeController(IRepositoryContextBase context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Company()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult Support()
        {
            return View();
        }

        public IActionResult Updates()
        {
            return View();
        }

        public IActionResult Clients()
        {
            var model = _context.Set<Client>().GetAll().Include(c=>c.ClientImages);
            return View(model);
        }

        public IActionResult Software()
        {
            return View();
        }

        public IActionResult Equipment()
        {
            return View();
        }

        public IActionResult Store()
        {
            return View();
        }

        public IActionResult Supermarket()
        {
            return View();
        }

        public IActionResult Cafe()
        {
            return View();
        }

        public IActionResult Kiosk()
        {
            return View();
        }

        public IActionResult Contacts()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}