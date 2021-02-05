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
        
    }
}
