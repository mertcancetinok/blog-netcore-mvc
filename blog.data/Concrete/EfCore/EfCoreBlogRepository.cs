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
        public int GetBlogCount()
        {
            using (var context = new BlogContext())
            {
                return context.Blogs.Count();
            }
        }
        public void Create(Blog T, int[] categoryIds)
        {
            using (var context = new BlogContext())
            {
                
                context.Blogs.Add(T);
                

                foreach (var categoryId in categoryIds)
                {
                    
                    var category = context.Categories.Find(categoryId);
                    var BlogCategories = new BlogCategory() { Blog = T, Category = category };
                    context.BlogCategories.Add(BlogCategories);
                }
                context.SaveChanges();
                
          
            }
        }

        public void DeleteWithCategories(Blog T)
        {
            using (var context = new BlogContext())
            {
                List<BlogCategory> blogCategories = context.BlogCategories
                    .Where(bg => bg.BlogId == T.Id)
                    .ToList();
                if (blogCategories != null)
                {
                    context.BlogCategories.RemoveRange(blogCategories);
                    context.Blogs.Remove(T);
                }
                context.SaveChanges();
            }
        }

        public Blog GetBlogDetailsWithCategories(string url)
        {
            using (var context = new BlogContext())
            {
                var entity = context.Blogs
                            .Where(b => b.Url == url)
                            .Include(bc => bc.BlogCategories)
                            .ThenInclude(bc => bc.Category)
                            .FirstOrDefault();
                entity.ClickCount += 1;                              
                context.SaveChanges();
                return entity;
            }

        }

        public List<Blog> GetBlogsByCategory(string categoryUrl, int pageSize, int page = 1)
        {
            using(var context = new BlogContext())
            {
                return context.Blogs
                    .Include(bc => bc.BlogCategories)
                    .ThenInclude(bc => bc.Category)
                    .Where(bc => bc.BlogCategories.Any(c => c.Category.Url == categoryUrl))
                    .Skip((page - 1) * pageSize).Take(pageSize)
                    .ToList();
                
                    
            }
        }
        public int GetBlogsByCategoryCount(string categoryUrl)
        {
            using (var context = new BlogContext())
            {
                return context.Blogs
                    .Include(bc => bc.BlogCategories)
                    .ThenInclude(bc => bc.Category)
                    .Where(bc => bc.BlogCategories.Any(c => c.Category.Url == categoryUrl))
                    .Count();


            }
        }

        public Blog GetByIdWithCategories(int id)
        {
            using (var context = new BlogContext())
            {
                return context.Blogs
                    .Where(i => i.Id == id)
                    .Include(c => c.BlogCategories)
                    .ThenInclude(c => c.Category)
                    .FirstOrDefault();
                    
            }
            
        }

        public List<Blog> MostPopularBlog()
        {
            using (var context = new BlogContext())
            {
                return context.Blogs                    
                    .OrderByDescending(b => b.ClickCount)
                    .Take(5)
                    .Include(bg => bg.BlogCategories)
                    .ThenInclude(bg => bg.Category)
                    .ToList();
            }
        }
    }
}
