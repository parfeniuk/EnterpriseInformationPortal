using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Base2BaseWeb.UI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Base2BaseWeb.UI.Controllers
{
    
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //[Route("Company")]
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
            return View();
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