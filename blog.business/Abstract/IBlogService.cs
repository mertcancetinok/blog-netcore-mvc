using blog.entity;
using System;
using System.Collections.Generic;
using System.Text;


namespace blog.business.Abstract
{
    public interface IBlogService
    {
        List<Blog> GetAllWithBloggerName(int? id);
        List<Blog> GetAll();
        void Create(Blog T);
        void Update(Blog T);
        void Delete(Blog T);
    }
}
