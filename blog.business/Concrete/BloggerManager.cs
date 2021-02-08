using blog.business.Abstract;
using blog.data.Abstract;
using blog.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.business.Concrete
{
    public class BloggerManager : IBloggerService
    {
        private IBloggerRepository _bloggerRepository;
        public BloggerManager(IBloggerRepository bloggerRepository)
        {
            _bloggerRepository = bloggerRepository;
        }

        public string ErrorMessage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Create(Blogger T)
        {
            _bloggerRepository.Create(T);
        }

        public void Delete(Blogger T)
        {

            _bloggerRepository.Delete(T);
            
        }

        public List<Blogger> GetAll()
        {
            return _bloggerRepository.GetAll();
        }

        public Blogger GetById(int id)
        {
            return _bloggerRepository.GetById(id);
        }

        public void Update(Blogger T)
        {
            _bloggerRepository.Update(T);
        }

        public bool Validation(Blogger entity)
        {
            throw new NotImplementedException();
        }
    }
}
