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
        public void Create(Blogger T)
        {
            _bloggerRepository.Create(T);
        }

        public void Delete(Blogger T)
        {
            
        }

        public List<Blogger> GetAll()
        {
            return _bloggerRepository.GetAll();
        }

        public void Update(Blogger T)
        {
            throw new NotImplementedException();
        }
    }
}
