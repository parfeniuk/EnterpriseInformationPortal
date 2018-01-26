using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Base2BaseWeb.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Company()
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
    }
}