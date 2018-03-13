using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.DataLayer.Entities
{
    public static class Base2BaseWebContextInitializer
    {
        public static void Initialize(Base2BaseWebContext context)
        {
            context.Database.Migrate();
        }
    }
}
