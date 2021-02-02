using blog.business.Abstract;
using blog.data.Abstract;
using blog.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace blog.business.Concrete
{
    public class BlogManager : IBlogService
    {
        private IBlogRepository _blogRepository;
        public BlogManager(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }
        public void Create(Blog T)
        {
            T.Url = T.Name;
            T.Url = T.Url.Trim();
            T.Url = T.Url.ToLower();
            T.Url = T.Url.Replace("ş", "s");
            T.Url = T.Url.Replace("Ş", "s");
            T.Url = T.Url.Replace("İ", "i");
            T.Url = T.Url.Replace("I", "i");
            T.Url = T.Url.Replace("ı", "i");
            T.Url = T.Url.Replace("ö", "o");
            T.Url = T.Url.Replace("Ö", "o");
            T.Url = T.Url.Replace("ü", "u");
            T.Url = T.Url.Replace("Ü", "u");
            T.Url = T.Url.Replace("Ç", "c");
            T.Url = T.Url.Replace("ç", "c");
            T.Url = T.Url.Replace("ğ", "g");
            T.Url = T.Url.Replace("Ğ", "g");
            T.Url = T.Url.Replace(" ", "-");
            T.AddedTime = DateTime.Now;
            _blogRepository.Create(T);
       
            
        }

        public void Delete(Blog T)
        {
            _blogRepository.Delete(T);
            
        }

        public List<Blog> GetAll()
        {
            return _blogRepository.GetAll();
            
        }

        public List<Blog> GetAllWithBloggerName(int? id)
        {
            return _blogRepository.GetAllWithBloggerName(id);
        }

        public void Update(Blog T)
        {
            _blogRepository.Update(T);
        }
    }
}
