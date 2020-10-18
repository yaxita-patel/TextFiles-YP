using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LabYaxita.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace LabYaxita.Controllers
{
    public class FileController : Controller
    {
        private readonly IWebHostEnvironment _env;

        public FileController(IWebHostEnvironment env){
            _env = env;
        }
        public IActionResult Index()
        {
            string[] files = Directory.GetFiles("TextFiles");
            return View(files);
        }
        public IActionResult Content()
        {  
            string contentRootPath = _env.ContentRootPath;
            string webRootPath = _env.WebRootPath;
            //string filePath = Path.Combine(_env.WebRootPath, "TextFiles");
            string url = Request.Path.ToUriComponent();           
            string subFilename = url.Substring(26);
                
            string contentData = System.IO.File.ReadAllText( "TextFiles/" + subFilename);

            return Content(contentData );
        }

    }
}
