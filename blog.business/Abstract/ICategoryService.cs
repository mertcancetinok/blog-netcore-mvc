using blog.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.business.Abstract
{
    public interface ICategoryService: IValidator<Category>
    {
        Category GetById(int id);
        List<Category> GetAll();
        void Create(Category T);
        void Update(Category T);
        void Delete(Category T);
    }
}
