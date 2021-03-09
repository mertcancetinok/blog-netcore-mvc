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


        private static string UrlTranslator(Category translator)
        {
            translator.Url = translator.Name;
            translator.Url = translator.Url.Trim();
            translator.Url = translator.Url.ToLower();
            translator.Url = translator.Url.Replace("ş", "s");
            translator.Url = translator.Url.Replace("Ş", "s");
            translator.Url = translator.Url.Replace("İ", "i");
            translator.Url = translator.Url.Replace("I", "i");
            translator.Url = translator.Url.Replace("ı", "i");
            translator.Url = translator.Url.Replace("ö", "o");
            translator.Url = translator.Url.Replace("Ö", "o");
            translator.Url = translator.Url.Replace("ü", "u");
            translator.Url = translator.Url.Replace("Ü", "u");
            translator.Url = translator.Url.Replace("Ç", "c");
            translator.Url = translator.Url.Replace("ç", "c");
            translator.Url = translator.Url.Replace("ğ", "g");
            translator.Url = translator.Url.Replace("Ğ", "g");
            translator.Url = translator.Url.Replace(" ", "-");
            
            return translator.Url;
        }
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
            T.Url=UrlTranslator(T);
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
            T.Url = UrlTranslator(T);
            _categoryRepository.Update(T);
            return new SuccessResult(Messages.CategoryUpdated);
        }

        public IDataResult<int> GetCount()
        {
            return new SuccessDataResult<int>(_categoryRepository.GetCount());
        }
    }
}
