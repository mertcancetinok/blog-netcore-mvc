using blog.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.business.Abstract
{
    public interface ICommentService:IValidator<Comment>
    {
        List<Comment> GetAll();
        List<Comment> GetCommentByUrl(string Url);
        Comment GetById(int id);

        void Create(Comment T);
        void Update(Comment T);
        void Delete(Comment T);
    }
}
