using blog.business.Utilities.Results;
using blog.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<Category> GetById(int id);
        IDataResult<List<Category>> GetAll();
        IDataResult<List<Category>> GetAll(int pageSize, int page);
        IDataResult<int> GetCount();
        IResult Create(Category T);
        IResult Update(Category T);
        IResult Delete(Category T);
    }
}
