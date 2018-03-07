using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Base2BaseWeb.UI.Helpers
{
    public interface IFilesHelper
    {
        void Delete(string pathToFile);
        void Copy(string directoryName, string fileName, IFormFile imageUpload);
    }
}
