using blog.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.data.Abstract
{
    public interface IBlogRepository:IRepository<Blog>
    {
        List<Blog> MostPopularBlog();
        List<Blog> GetBlogsByCategory(string categoryUrl);
        Blog GetByIdWithCategories(int id);
        Blog GetBlogDetailsWithCategories(string url);
        void Create(Blog T, int[] categoryIds);
        void DeleteWithCategories(Blog T);

    }
}
