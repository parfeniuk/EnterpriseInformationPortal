using Base2BaseWeb.B2B.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using RepositoryGeneric;
using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Repository
{
    public class B2BRepositoryContext : RepositoryContextBase
    {
        public B2BRepositoryContext(DbContext context) : base(context) { }
    }
}
