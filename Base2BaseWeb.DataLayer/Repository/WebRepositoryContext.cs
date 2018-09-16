using Base2BaseWeb.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using RepositoryGeneric;
using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.DataLayer.Repository
{
    public class WebRepositoryContext:WebRepositoryContextBase
    {
        public WebRepositoryContext(Base2BaseWebContext context) : base(context)
        {
        }
    }
}
