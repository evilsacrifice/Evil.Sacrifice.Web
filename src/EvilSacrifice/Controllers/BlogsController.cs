using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EvilSacrifice.Models.Blogs;
using Microsoft.AspNetCore.Hosting;
// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace EvilSacrifice.Controllers
{
    public class BlogsController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        public BlogsController(IHostingEnvironment hostingEnv)
        {
            _hostingEnvironment = hostingEnv;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = new BlogsModel();
            return View();
        }

        public IActionResult Read(string pageName)
        {
            var webRootPath = _hostingEnvironment.WebRootPath;
            var pagePath = System.IO.Path.Combine(webRootPath, $"html\\{pageName}.htm");
            var model = new BlogPageModel() { PagePath = pagePath };
            return View(model);
        }
    }
}
