using blog.business.Abstract;
using blog.entity;
using blog.webui.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
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
        public IActionResult Blogger()
        {
            return View(_bloggerService.GetAll());
        }
        public IActionResult Category()
        {
            return View(_categoryService.GetAll());
        }

        //Edit Controller
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
                entity.ImageUrl = blog.ImageUrl;
                entity.Url = blog.Url;                
                entity.Content = blog.Content;
                CreateMessage($"{entity.Name} isimli blog güncellendi","info");
                _blogService.Update(entity);
                return RedirectToAction("Index");
            }

            return View(blog);
            
            
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
                CreateMessage($"{entity.Name} isimli blogger güncellendi", "info");
                _bloggerService.Update(entity);
                return RedirectToAction("Blogger");

            }
            return View(blogger);
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
                CreateMessage($"{entity.Name} isimli kategori güncellendi", "info");
                _categoryService.Update(entity);
                return RedirectToAction("Category");
            }
            return View(category);
        }

        
        //Create Controller
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
            var blogCategoriesViewModel = new BlogCategoriesViewModel()
            {
                Blog = blog,
                Categories = _categoryService.GetAll()
            };
            if (ModelState.IsValid)
            {
                blog.BloggerId = 5;
                if(_blogService.Create(blog, categoryId))
                {
                    CreateMessage($"{blog.Name} isimli blog başarıyla eklendi", "success");
                    return RedirectToAction("Blog");
                }
                CreateMessage(_blogService.ErrorMessage, "error");
                
                return View(blogCategoriesViewModel);
            }
            return View(blogCategoriesViewModel);

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
                CreateMessage($"{blogger.Name} isimli blogger başarıyla eklendi", "success");
                return RedirectToAction("Index");
            }
            return View();

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
                CreateMessage($"{category.Name} isimli kategori başarıyla eklendi", "success");
                return RedirectToAction("Category");
            }
            return View(category);
        }

        //Delete Controller

        public IActionResult BlogDelete(int blogId)
        {            
            var entity = _blogService.GetById(blogId);
            if (entity!=null)
            {
                CreateMessage($"{entity.Name} isimli blog başarıyla silindi", "warning");
                _blogService.DeleteWithCategories(entity);
                return RedirectToAction("Blog");
            }
            return View();
        }
        public IActionResult BloggerDelete(int bloggerId)
        {
            var entity = _bloggerService.GetById(bloggerId);
            if (entity != null)
            {
                CreateMessage($"{entity.Name} isimli blogger başarıyla silindi", "warning");
                _bloggerService.Delete(entity);                    
                return RedirectToAction("Blogger");
            }

            return View();
            
        }         
        public IActionResult CategoryDelete(int categoryId)
        {
            var entity = _categoryService.GetById(categoryId);
            if (entity != null)
            {
                CreateMessage($"{entity.Name} isimli kategori başarıyla silindi", "warning");
                _categoryService.Delete(entity);
                return RedirectToAction("Category");
            }
            return View();
        }
       
        //Message Function
        private void CreateMessage(string message, string alertType)
        {
            var alertMessage = new AlertMessage()
            {
                Message=message,
                AlertType=alertType
            };
            TempData["message"] = JsonConvert.SerializeObject(alertMessage);
        } 
    }
}
