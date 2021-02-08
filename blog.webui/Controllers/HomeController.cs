using blog.business.Abstract;
using blog.webui.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace blog.webui.Controllers
{
    public class HomeController : Controller
    {
        private IBlogService _blogService;
        public HomeController(IBlogService blogService)
        {
            this._blogService = blogService;
        }
        

        public IActionResult Index()
        {
            var homeModel = new HomeModel()
            {
                Popular = _blogService.MostPopularBlog(),
                GetAll = _blogService.GetAll()
            };
            
            
            return View(homeModel);
        }
        public IActionResult BlogDetails(string Url)
        {

            return View(_blogService.GetBlogDetailsWithCategories(Url));
        }



    }
}
