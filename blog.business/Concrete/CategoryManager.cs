using blog.business.Abstract;
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

        public string ErrorMessage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
        public void Create(Category T)
        {
            T.Url=UrlTranslator(T);
            _categoryRepository.Create(T);
            
        }

        public void Delete(Category T)
        {
            _categoryRepository.Delete(T);
        }

        public List<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public void Update(Category T)
        {
            T.Url = UrlTranslator(T);
            _categoryRepository.Update(T);
            
        }

        public bool Validation(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
