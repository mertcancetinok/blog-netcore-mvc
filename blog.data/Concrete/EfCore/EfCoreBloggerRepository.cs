using blog.data.Abstract;
using blog.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.data.Concrete.EfCore
{
    public class EfCoreBloggerRepository:EfCoreGenericRepository<Blogger,BlogContext>,IBloggerRepository
    {

    }
}
