using blog.data.Abstract;
using blog.entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.data.Concrete.EfCore
{
    public class EfCoreBlogRepository : EfCoreGenericRepository<Blog, BlogContext>, IBlogRepository
    {
        //public List<Blog> getCommentByBlog(int blogId)
        //{
        //    using(var context = new BlogContext())
        //    {
        //        return context.Blogs
        //            .Include(i => i.Comments)
        //            .ToList(); 
        //    }
        //}
        public List<Blog> GetAllWithBloggerName(int? id)
        {
            using (var context = new BlogContext())
            {
                return context.Blogs
                    .Where(b => b.BloggerId == id)
                    .Include(b => b.Blogger)
                    .ToList();
            }
        }
    }
}
