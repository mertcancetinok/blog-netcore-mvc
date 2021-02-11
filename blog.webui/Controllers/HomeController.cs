using blog.business.Abstract;
using blog.entity;
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
        private ICommentService _commentService;
        public HomeController(IBlogService blogService,ICommentService commentService)
        {
            this._blogService = blogService;
            this._commentService = commentService;
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
        public IActionResult BlogDetails(string Url,List<Comment> comments)
        {
            
            var blogCommentsViewModel = new BlogCommentsViewModel()
            {
                blog = _blogService.GetBlogDetailsWithCategories(Url),
                GetCommentByUrl = _commentService.GetCommentByUrl(Url), 
            };
            return View(blogCommentsViewModel);

        }
        [HttpPost]
        public IActionResult BlogDetails(BlogCommentsViewModel blogCommentsViewModel,int blogId)
        {
            
            
            blogCommentsViewModel.NewComment.AddedTime = DateTime.Now;
            blogCommentsViewModel.NewComment.BlogId = blogId;
            _commentService.Create(blogCommentsViewModel.NewComment);
            return RedirectToAction("Index");
        }
        public IActionResult BlogList(string Url)
        {
            return View(_blogService.GetBlogsByCategory(Url));
        }



    }
}
