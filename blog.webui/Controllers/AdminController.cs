using blog.business.Abstract;
using blog.entity;
using blog.webui.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        private ICategoryService _categoryService;
        public AdminController(IBlogService blogService,IBloggerService bloggerService,ICategoryService categoryService )
        {
            this._blogService = blogService;
            this._bloggerService = bloggerService;
            this._categoryService = categoryService;
        }
        public IActionResult Index()
        {
            
            return View();
           
        }
        [HttpGet]
        public IActionResult Blog()
        {
          
            return View(_blogService.GetAll());
        }
        [HttpGet]
        public IActionResult BlogEdit(int id)
        {
            var blogCategoriesViewModel = new BlogCategoriesViewModel()
            {
                Blog = _blogService.GetById(id),
                Categories = _categoryService.GetAll()
            };
            return View(blogCategoriesViewModel);
        }
        [HttpPost]
        public IActionResult BlogEdit(Blog blog)
        {
            if (ModelState.IsValid)
            {
                var entity = _blogService.GetById(blog.Id);
                if (entity == null)
                {
                    return NotFound();
                }
                entity.Name = blog.Name;
                entity.ReadTime = blog.ReadTime;
                entity.Url = blog.Url;
                entity.Content = blog.Content;
                _blogService.Update(entity);
                return RedirectToAction("Blog");
            }

            return View(blog);
            
            
        }

        public IActionResult BlogCreate()
        {
            var blogCategoriesViewModel = new BlogCategoriesViewModel()
            {
                Blog = null,
                Categories = _categoryService.GetAll()
            };
            return View(blogCategoriesViewModel);   
                
        }
        [HttpPost]
        public IActionResult BlogCreate(Blog blog,int[] categoryId)
        {



            if (ModelState.IsValid)
            {
                blog.BloggerId = 2;
                _blogService.Create(blog,categoryId);              
                return RedirectToAction("Index");
                
            }
            return View();

        }
        public IActionResult Blogger()
        {
            return View(_bloggerService.GetAll());
        }
        public IActionResult BloggerEdit(int id)
        {
            return View(_bloggerService.GetById(id));
        }
        [HttpPost]
        public IActionResult BloggerEdit(Blogger blogger)
        {
            if (ModelState.IsValid)
            {
                var entity = _bloggerService.GetById(blogger.Id);
                if (entity == null)
                {
                    return NotFound();
                }
                entity.Name = blogger.Name;
                entity.Surname = blogger.Surname;
                entity.JobTitle = blogger.JobTitle;
                _bloggerService.Update(entity);
                return RedirectToAction("Blogger");

            }
            return View(blogger);
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
        public IActionResult BloggerDelete(int bloggerId)
        {
            var entity = _bloggerService.GetById(bloggerId);
            if (entity != null)
            {
                _bloggerService.Delete(entity);
                return RedirectToAction("Blogger");
            }
            return View();
            
        }
        

        public IActionResult Category()
        {
            return View(_categoryService.GetAll());
        }
        [HttpGet]
        public IActionResult CategoryEdit(int id)
        {
            return View(_categoryService.GetById(id));
        }
        [HttpPost]
        public IActionResult CategoryEdit(Category category)
        {
            if (ModelState.IsValid)
            {
                var entity = _categoryService.GetById(category.Id);
                if (entity == null)
                {
                    return NotFound();
                }
                entity.Name = category.Name;
                entity.Url = category.Url;
                entity.IconClass = category.IconClass;
                _categoryService.Update(entity);
                return RedirectToAction("Category");
            }
            return View(category);
        }
        [HttpGet]
        public IActionResult CategoryCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CategoryCreate(Category category)
        {
            if (ModelState.IsValid)
            {
                _categoryService.Create(category);
                return RedirectToAction("Category");
            }
            return View(category);
        }
        public IActionResult CategoryDelete(int categoryId)
        {
            var entity = _categoryService.GetById(categoryId);
            if (entity != null)
            {
                _categoryService.Delete(entity);
                return RedirectToAction("Category");
            }
            return View();
        }
    }
}
