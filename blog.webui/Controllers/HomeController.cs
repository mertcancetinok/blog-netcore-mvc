using blog.business.Abstract;
using blog.entity;
using blog.webui.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using blog.webui.Extensions;

namespace blog.webui.Controllers
{
    public class HomeController : Controller
    {
        private IBlogService _blogService;
        private ICommentService _commentService;
        public HomeController(IBlogService blogService,ICommentService commentService)
        {
            this._blogService = blogService;
            this._commentService = commentService;
        }
        

        public IActionResult Index(int page=1)
        {
            const int pageSize = 5; 
            var resultGet = _blogService.GetAll(pageSize,page);
            var resultPopular = _blogService.MostPopularBlog();
            if (resultGet.Success && resultPopular.Success)
            {
                var homeModel = new HomeModel()
                {
                    Popular = resultPopular.Data,
                    GetAll = resultGet.Data,
                    PageModel = new PageModel()
                    {
                        TotalItems=_blogService.GetCount().Data,
                        CurrentPage=page,
                        ItemsPerPage=pageSize,
                    }
                };
                return View(homeModel);
            }
            return View();          
        }
        public IActionResult BlogDetails(string url,List<Comment> comments)
        {
            var resultBlog = _blogService.GetBlogDetailsWithCategories(url);
            var resultComment = _commentService.GetCommentByUrl(url);
            Console.WriteLine(Url);
            if(resultComment.Success && resultBlog.Success)
            {
                var blogCommentsViewModel = new BlogCommentsViewModel()
                {
                    Blog = resultBlog.Data,
                    GetCommentByUrl = resultComment.Data

                };
                return View(blogCommentsViewModel);
            }
            return View();
            
            

        }
        [HttpPost]
        public IActionResult BlogDetails(BlogCommentsViewModel blogCommentsViewModel,int blogId,string returnUrl)
        {
            if (ModelState.IsValid)
            {
                blogCommentsViewModel.NewComment.AddedTime = DateTime.Now;
                blogCommentsViewModel.NewComment.BlogId = blogId;
                var result = _commentService.Create(blogCommentsViewModel.NewComment);
                if (result.Success)
                {
                    TempData.SetMessage("message", new AlertMessage() { Message = result.Message, AlertType = "success" });
                    return Redirect("/Blog/" + returnUrl);
                }
                else
                {
                    TempData.SetMessage("message", new AlertMessage() { Message = result.Message, AlertType = "danger" });
                }
                
            }
            return Redirect("/Blog/" + returnUrl);




        }
        public IActionResult BlogList(string Url,int page=1)
        {
            
            const int pageSize = 5;
            
            var result = _blogService.GetBlogsByCategory(Url, pageSize, page);
            if (result.Success)
            {
                var model = new DataPagingModel<Blog>()
                {
                    PageModel = new PageModel()
                    {
                        TotalItems = _blogService.GetBlogsByCategoryCount(Url).Data,
                        CurrentPage = page,
                        ItemsPerPage = pageSize,
                        Category = Url
                    },
                    Data = result.Data
                };
                return View(model);
            }
            return View();
        }
        private void CreateMessage(string message, string alertType)
        {
            var alertMessage = new AlertMessage()
            {
                Message = message,
                AlertType = alertType
            };
            TempData["message"] = JsonConvert.SerializeObject(alertMessage);
        }



    }
}
