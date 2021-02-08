using blog.entity;
using System;
using System.Collections.Generic;
using System.Text;


namespace blog.business.Abstract
{
    public interface IBlogService:IValidator<Blog>
    {
        
        Blog GetById(int id);
        Blog GetBlogDetailsWithCategories(string url);
        List<Blog> MostPopularBlog();
        List<Blog> GetAll();
        void Create(Blog T);
        bool Create(Blog T, int[] categoryIds);
        void Update(Blog T);
        void Delete(Blog T);
        void DeleteWithCategories(Blog T);
    }
}
