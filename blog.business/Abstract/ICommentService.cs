using blog.business.Utilities.Results;
using blog.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.business.Abstract
{
    public interface ICommentService
    {
        IDataResult<List<Comment>> GetAll(int pageSize, int page);
        IDataResult<int> GetCount();
        IDataResult<List<Comment>> GetCommentByUrl(string Url);
        IDataResult<Comment> GetById(int id);
        IDataResult<int> NotApprovedCommentCount();
        IResult Create(Comment T);
        IResult Update(Comment T);
        IResult Delete(Comment T);
    }
}
