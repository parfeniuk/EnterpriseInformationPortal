using Microsoft.EntityFrameworkCore;
using RepositoryGeneric;
using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.DataLayer.Repository
{
    public class WebRepositoryContextBase:RepositoryContextBase, IRepositoryWebB2B
    {
        public WebRepositoryContextBase(DbContext context) : base(context)
        {
        }
    }
}
