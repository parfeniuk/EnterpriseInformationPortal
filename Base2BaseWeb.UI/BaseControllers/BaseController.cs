using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using RepositoryGeneric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Base2BaseWeb.UI.BaseControllers
{
    public abstract class BaseController:Controller
    {
        protected IRepositoryContextBase _context;
        public BaseController(IRepositoryContextBase context)
        {
            _context = context;
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
            base.Dispose(disposing);
        }
    }
}
