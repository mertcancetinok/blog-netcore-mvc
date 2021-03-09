using blog.business.Abstract;
using blog.business.Constants;
using blog.business.Utilities.Results;
using blog.data.Abstract;
using blog.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryRepository _categoryRepository;

        public CategoryManager(ICategoryRepository categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }
        public IResult Create(Category T)
        {
            if (T == null)
            {
                return new ErrorResult(Messages.CategorNull);
            }
            T.Url = UrlTranslate.AdresDuzenle(T.Name);
            _categoryRepository.Create(T);
            return new SuccessResult(Messages.CategoryAdded);
            
        }

        public IResult Delete(Category T)
        {
            if (T == null)
            {
                return new ErrorResult(Messages.CategorNull);
            }
            _categoryRepository.Delete(T);
            return new SuccessResult(Messages.CategoryDeleted);
        }
        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryRepository.GetAll());
        }
        public IDataResult<List<Category>>  GetAll(int pageSize, int page)
        {
            return new SuccessDataResult<List<Category>>(_categoryRepository.GetAll(pageSize,page));
        }

        public IDataResult<Category> GetById(int id)
        {            
            return new SuccessDataResult<Category>(_categoryRepository.GetById(id));
            
        }

        public IResult Update(Category T)
        {
            if (T == null)
            {
                return new ErrorResult(Messages.CategorNull);
            }
            T.Url = UrlTranslate.AdresDuzenle(T.Name);
            _categoryRepository.Update(T);
            return new SuccessResult(Messages.CategoryUpdated);
        }

        public IDataResult<int> GetCount()
        {
            return new SuccessDataResult<int>(_categoryRepository.GetCount());
        }
    }
}
