using blog.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.business.Abstract
{
    public interface IBloggerService
    {
        List<Blogger> GetAll();
        void Create(Blogger T);
        void Update(Blogger T);
        void Delete(Blogger T);
    }
}
