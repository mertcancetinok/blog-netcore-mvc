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
    public class EfCoreBlogRepository : EfCoreGenericRepository<Blog>, IBlogRepository
    {
        public EfCoreBlogRepository(BlogContext context):base(context)
        {

        }
        private BlogContext BlogContext
        {
            get { return context as BlogContext; }
        }
        public int GetBlogCount()
        {
           
                return BlogContext.Blogs.Count();
            
        }
        public void Create(Blog T, int[] categoryIds)
        {


                BlogContext.Blogs.Add(T);


                foreach (var categoryId in categoryIds)
                {

                    var category = BlogContext.Categories.Find(categoryId);
                    var BlogCategories = new BlogCategory() { Blog = T, Category = category };
                BlogContext.BlogCategories.Add(BlogCategories);
                }
                BlogContext.SaveChanges();


            
        }

        public void DeleteWithCategories(Blog T)
        {
            
                List<BlogCategory> blogCategories = BlogContext.BlogCategories
                    .Where(bg => bg.BlogId == T.Id)
                    .ToList();
                if (blogCategories != null)
                {
                BlogContext.BlogCategories.RemoveRange(blogCategories);
                BlogContext.Blogs.Remove(T);
                }
                BlogContext.SaveChanges();
            
        }

        public Blog GetBlogDetailsWithCategories(string url)
        {
            
                var entity = BlogContext.Blogs
                            .Where(b => b.Url == url)
                            .Include(bc => bc.BlogCategories)
                            .ThenInclude(bc => bc.Category)
                            .FirstOrDefault();
                entity.ClickCount += 1;
                return entity;
            

        }

        public List<Blog> GetBlogsByCategory(string categoryUrl, int pageSize, int page = 1)
        {
            
                return BlogContext.Blogs
                    .Include(bc => bc.BlogCategories)
                    .ThenInclude(bc => bc.Category)
                    .Where(bc => bc.BlogCategories.Any(c => c.Category.Url == categoryUrl))
                    .Skip((page - 1) * pageSize).Take(pageSize)
                    .ToList();


            
        }
        public int GetBlogsByCategoryCount(string categoryUrl)
        {
            
                return BlogContext.Blogs
                    .Include(bc => bc.BlogCategories)
                    .ThenInclude(bc => bc.Category)
                    .Where(bc => bc.BlogCategories.Any(c => c.Category.Url == categoryUrl))
                    .Count();


            
        }

        public Blog GetByIdWithCategories(int id)
        {
            
                return BlogContext.Blogs
                    .Where(i => i.Id == id)
                    .Include(c => c.BlogCategories)
                    .ThenInclude(c => c.Category)
                    .FirstOrDefault();

            

        }

        public List<Blog> MostPopularBlog()
        {
            
                return BlogContext.Blogs
                    .OrderByDescending(b => b.ClickCount)
                    .Take(5)
                    .Include(bg => bg.BlogCategories)
                    .ThenInclude(bg => bg.Category)
                    .ToList();
            
        }
    }
}