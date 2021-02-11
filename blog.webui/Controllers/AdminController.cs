using blog.business.Abstract;
using blog.entity;
using blog.webui.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace blog.webui.Controllers
{
    public class AdminController : Controller
    {
        private IBlogService _blogService;
        private IBloggerService _bloggerService;
        private ICategoryService _categoryService;
        private ICommentService _commentService;
        public AdminController(IBlogService blogService,IBloggerService bloggerService,ICategoryService categoryService,ICommentService commentService )
        {
            this._blogService = blogService;
            this._bloggerService = bloggerService;
            this._categoryService = categoryService;
            this._commentService = commentService;
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
        public IActionResult Comment()
        {
            return View(_commentService.GetAll());
        }
        //Edit Controller
        [HttpGet]
        public IActionResult BlogEdit(int id)
        {
            
            return View(_blogService.GetById(id));
        }
        [HttpPost]
        public async Task<IActionResult> BlogEdit(Blog blog,IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var entity = _blogService.GetById(blog.Id);
                if (entity!= null)
                {
                    entity.Name = blog.Name;
                    entity.ReadTime = blog.ReadTime;
                    entity.Content = blog.Content;
                    
                    if (file != null)
                    {
                        var extention = Path.GetExtension(file.FileName);
                        var randomName = string.Format($"{Guid.NewGuid()}{extention}");
                        entity.ImageUrl = randomName;
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img\\blog",randomName);
                        using (var stream = new FileStream(path,FileMode.Create))
                        {
                            await file.CopyToAsync(stream);
                        }

                    }
                    else
                    {
                        entity.ImageUrl = blog.ImageUrl;
                    }
                    _blogService.Update(entity);
                    CreateMessage($"{entity.Name} isimli blog başarıyla güncellendi", "info");
                    return RedirectToAction("Blog");
                }
                else
                {
                    CreateMessage("Kayıt bulunamadı", "error");
                    return RedirectToAction("Blog");
                }
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
        public IActionResult CommentEdit(int Id)
        {
            var entity = _commentService.GetById(Id);
            entity.IsApproved = true;
            _commentService.Update(entity);
            CreateMessage($"{entity.Writer} isimli yazarın yorumu onaylandı","success");
            return RedirectToAction("Comment");
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
        public async Task<IActionResult> BlogCreate(Blog blog,int[] categoryId,IFormFile file)
        {
            var blogCategoriesViewModel = new BlogCategoriesViewModel()
            {
                Blog = blog,
                Categories = _categoryService.GetAll()
            };
            if (ModelState.IsValid)
            {
                blog.BloggerId = 1;
                if (file != null)
                {
                    var extention = Path.GetExtension(file.FileName);
                    var randomName = string.Format($"{Guid.NewGuid()}{extention}");
                    blog.ImageUrl = randomName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img\\blog", randomName);
                    using (var stream = new FileStream(path,FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }
                else
                {
                    CreateMessage("Blog resmi yüklenemedi", "error");
                    return View(blogCategoriesViewModel);
                }
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
        public IActionResult CommentDelete(int commentId)
        {
            var entity = _commentService.GetById(commentId);
            if (entity != null)
            {
                 CreateMessage($"{entity.Writer} adlı kişinin yorumu silindi","warning");
                _commentService.Delete(entity);
                return RedirectToAction("Comment");
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
