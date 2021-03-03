using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.Helpers
{
    public class FileHelper
    {
        public static string Addd(IFormFile file)
        {
            var filePath = Path.GetTempFileName();
            if (file.Length > 0)
            {          
                using (var stream = File.Create(filePath))
                {
                    file.CopyTo(stream);
                }      
            }
            return filePath;
        }

        public static string Add(IFormFile file)
        {
            var sourcepath = Path.GetTempFileName();
            if (file.Length > 0)
            {
                using (var stream = new FileStream(sourcepath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }
            var result = newPath(file);
            File.Move(sourcepath, result);
            return result;
        }

        public static string newPath(IFormFile file)
        {
            FileInfo fi = new FileInfo(file.FileName);
            string fileExtension = fi.Extension;

            string path = Environment.CurrentDirectory + "\\Images";
            var newPath = Guid.NewGuid().ToString() + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Year + fileExtension;

            string result = $@"{path}\{newPath}";
            return result;
        }
    }
}
