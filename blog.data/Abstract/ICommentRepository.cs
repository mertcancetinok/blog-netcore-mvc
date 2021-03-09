using blog.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.data.Abstract
{
    public interface ICommentRepository:IRepository<Comment>
    {
        List<Comment> GetCommentByUrl(string url);
        int NotApprovedCommentCount();
    }
}
