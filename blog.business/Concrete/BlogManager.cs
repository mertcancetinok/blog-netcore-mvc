﻿using blog.business.Abstract;
using blog.data.Abstract;
using blog.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace blog.business.Concrete
{
    public class BlogManager : IBlogService
    {
        private static string UrlTranslator(Blog translator)
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
            translator.AddedTime = DateTime.Now;
            return translator.Url;
        }
        private IBlogRepository _blogRepository;

        public string ErrorMessage { get; set; }

        public BlogManager(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }
        public void Create(Blog T)
        {
            T.Url = UrlTranslator(T);
            _blogRepository.Create(T);
       
            
        }

        public void Delete(Blog T)
        {
            _blogRepository.Delete(T);
            
        }

        public List<Blog> GetAll()
        {
            return _blogRepository.GetAll();
            
        }

        
        public Blog GetById(int id)
        {
            return _blogRepository.GetById(id);
        }

        public void Update(Blog T)
        {
             T.Url = UrlTranslator(T);
            _blogRepository.Update(T);
        }

        public bool Create(Blog T, int[] categoryIds)
        {
            if (Validation(T))
            {
                if (categoryIds.Length == 0)
                {
                    ErrorMessage += "Lütfen en az bir kategori seçiniz";
                    return false;
                }
                T.Url = UrlTranslator(T);
                _blogRepository.Create(T, categoryIds);
                return true;
            }
            return false;
             
        }

        public void DeleteWithCategories(Blog T)
        {
            _blogRepository.DeleteWithCategories(T);
        }

        public bool Validation(Blog entity)
        {
            bool isValid = true;
            if(string.IsNullOrEmpty(entity.Name) || string.IsNullOrEmpty(entity.Content) || entity.ReadTime==0)
            {
                isValid = false;
                ErrorMessage += "Lütfen boş alanları kontrol ediniz";
            }

            return isValid;
        }

        public Blog GetBlogDetailsWithCategories(string url)
        {
            return _blogRepository.GetBlogDetailsWithCategories(url);
        }

        public List<Blog> MostPopularBlog()
        {
            return _blogRepository.MostPopularBlog();
        }
    }
}
