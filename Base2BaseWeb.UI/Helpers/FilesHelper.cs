using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Base2BaseWeb.UI.Helpers
{
    public class FilesHelper:IFilesHelper
    {
        private static IHostingEnvironment _environment;
        public FilesHelper(IHostingEnvironment environment)
        {
            _environment = environment;
        }

        public void Delete(string pathToFile)
        {
            if (!string.IsNullOrEmpty(pathToFile))
            {
                // Remove File if exists
                string pathExistedServerFile = Path.Combine(_environment.WebRootPath, pathToFile);
                if (System.IO.File.Exists(pathExistedServerFile))
                {
                    System.IO.File.Delete(pathExistedServerFile);
                }
                else
                {
                    throw new FileNotFoundException("Файл не найден", pathToFile);
                }
            }
        }

        public void Copy(string directoryName,string fileName, IFormFile imageUpload)
        {
            string pathToFile = directoryName + fileName;

            string pathServerDir = Path.Combine(_environment.WebRootPath, directoryName);
            string pathServerFile = Path.Combine(_environment.WebRootPath, pathToFile);

            Directory.CreateDirectory(pathServerDir);
            using (var fileStream = new FileStream(pathServerFile, FileMode.Create))
            {
                imageUpload.CopyTo(fileStream);
            }
        }
    }
}
