using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ASPFinal.Helpers
{
    public class FileManager
    {
        public static string UploadPath = HttpContext.Current.Server.MapPath("~/Uploads");
        public static string Upload(HttpPostedFileBase file, string allowedTypes = "image/png|image/jpeg|image/gif", int maxSize = 2048)
        {
            if (file == null)
            {
                string fileName = "download.png";
                return fileName;
            }
            if (file.ContentLength / 2048 > maxSize)
            {
                throw new Exception("File size max be 2048kb");
            }
            if (!allowedTypes.Split('|').Contains(file.ContentType))
            {
                throw new Exception("File type is not acceptable");
            }
            string filename = CreatePath() + "/" + Guid.NewGuid().ToString() + "-" + file.FileName;
            file.SaveAs(Path.Combine(UploadPath, filename));

            return filename;
        }
        public static void Delete(string filename)
        {
            if (string.IsNullOrEmpty(filename))
            {
                throw new NullReferenceException("Filename cannot be null");
            }


            if (!File.Exists(Path.Combine(UploadPath, filename)))
            {
                throw new Exception("File doesnt exists");
            }


            File.Delete(Path.Combine(UploadPath, filename));
        }
        private static string CreatePath()
        {
            DateTime now = DateTime.Now;

            if (!Directory.Exists(Path.Combine(UploadPath, now.Year.ToString())))
            {
                Directory.CreateDirectory(Path.Combine(UploadPath, now.Year.ToString()));
            }

            if (!Directory.Exists(Path.Combine(UploadPath, now.Year.ToString(), now.Month.ToString())))
            {
                Directory.CreateDirectory(Path.Combine(UploadPath, now.Year.ToString(), now.Month.ToString()));
            }

            return now.Year.ToString() + "/" + now.Month.ToString();
        }
    }
}