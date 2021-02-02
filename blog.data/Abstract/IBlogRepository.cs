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
        List<Blog> GetAllWithBloggerName(int? id);
    }
}
