using blog.entity;
using System;
using System.Collections.Generic;
using System.Text;


namespace blog.business.Abstract
{
    public interface IBlogService
    {
        
        Blog GetById(int id);
        List<Blog> GetAll();
        void Create(Blog T);
        void Create(Blog T, int[] categoryIds);
        void Update(Blog T);
        void Delete(Blog T);
    }
}
