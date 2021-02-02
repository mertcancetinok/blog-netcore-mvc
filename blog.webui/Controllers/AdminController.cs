using blog.business.Abstract;
using blog.entity;
using blog.webui.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.webui.Controllers
{
    public class AdminController : Controller
    {
        private IBlogService _blogService;
        private IBloggerService _bloggerService;
        public AdminController(IBlogService blogService,IBloggerService bloggerService )
        {
            this._blogService = blogService;
            this._bloggerService = bloggerService;
        }
        public IActionResult Index()
        {
            
            return View();
           
        }
        [HttpGet]
        public IActionResult Blog(int? id)
        {
          
            return View(_blogService.GetAll());
        }
        
        
        public IActionResult BlogCreate()
        {
            
            return View();
                
         }
        [HttpPost]
        public IActionResult BlogCreate(Blog blog)
        {
            if (ModelState.IsValid)
            {
                blog.BloggerId = 1;
                _blogService.Create(blog);
                return RedirectToAction("Index");
            }
            return View();

        }
        public IActionResult BloggerCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult BloggerCreate(Blogger blogger)
        {
            if (ModelState.IsValid)
            {
                
                _bloggerService.Create(blogger);
                return RedirectToAction("Index");
            }
            return View();

        }

    }
}
