using BNBCheckInServer.Service.IService;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BNBCheckInServer.Service
{
    public class FileUpload : IFileUpload
    {
        // In order to find the relative path for 'wwwroot'-folder we have to
        // use 'IWebHostEnvironment' with Dependency Injection.
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public FileUpload(IWebHostEnvironment webHostEnvironment, IHttpContextAccessor httpContextAccessor)
        {
            _webHostEnvironment = webHostEnvironment;
            _httpContextAccessor = httpContextAccessor;
        }

        public bool DeleteFile(string fileName)
        {
            try
            {
                var path = $"{_webHostEnvironment.WebRootPath}\\Images\\{fileName}";
                if (File.Exists(path))
                {
                    File.Delete(path);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "The file has not been deleted.");
                throw;
            }
        }

        public async Task<string> UploadFile(IBrowserFile file)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(file.Name);
                var fileName = Guid.NewGuid().ToString() + fileInfo.Extension;
                var folderDirectory = $"{_webHostEnvironment.WebRootPath}\\Images";
                var path = Path.Combine(_webHostEnvironment.WebRootPath, "Images", fileName);

                var memoryStream = new MemoryStream();
                await file.OpenReadStream().CopyToAsync(memoryStream);

                if (!Directory.Exists(folderDirectory))
                {
                    Directory.CreateDirectory(folderDirectory);
                }

                await using (var fs = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    memoryStream.WriteTo(fs);
                }

                var url = $"{_httpContextAccessor.HttpContext.Request.Scheme}://" +
                            $"{_httpContextAccessor.HttpContext.Request.Host.Value}/";
                var fullPath = $"{url}Images/{fileName}";

                return fullPath;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "The new folder and/or file was not created.");
                throw;
            }
        }
    }
}
