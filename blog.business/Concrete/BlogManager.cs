using blog.business.Abstract;
using blog.business.Constants;
using blog.business.Utilities.Results;
using blog.data.Abstract;
using blog.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace blog.business.Concrete
{
    public class BlogManager : IBlogService
    {
        private IBlogRepository _blogRepository;

        public BlogManager(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }
        public IResult Create(Blog T)
        {
            if (T == null)
            {
                return new ErrorResult(Messages.BlogNull);
            }

            _blogRepository.Create(T);
            return new SuccessResult(Messages.BlogAdded);
            
        }

        public IResult Delete(Blog T)
        {
            if (T == null)
            {
                return new ErrorResult(Messages.BlogNull);
            }

            _blogRepository.Delete(T);
            return new SuccessResult(Messages.BlogDeleted);
            
        }

        public IDataResult<List<Blog>> GetAll(int page, int pageSize)
        {

            return new SuccessDataResult<List<Blog>>(_blogRepository.GetAll(page, pageSize),Messages.BlogList);
        }
        

        public IDataResult<Blog> GetById(int id)
        {
            return new SuccessDataResult<Blog>(_blogRepository.GetById(id));
        }

        public IResult Update(Blog T)
        {
            if (T == null)
            {
                return new ErrorResult(Messages.BlogNull);
            }

            T.Url = UrlTranslate.AdresDuzenle(T.Name);
            _blogRepository.Update(T);
            return new ErrorResult(Messages.BlogUpdated);
        }

        public IResult Create(Blog T, int[] categoryIds)
        {
            if (T==null)
            {
                return new ErrorResult(Messages.BlogNull);
            }
            if (categoryIds.Length == 0)
            {
                return new ErrorResult(Messages.CategorNull);
            }


            T.Url = UrlTranslate.AdresDuzenle(T.Name);
            _blogRepository.Create(T, categoryIds);
            return new SuccessResult(Messages.BlogAdded);
             
        }

        public IResult DeleteWithCategories(Blog T)
        {
            if (T == null)
            {
                return new ErrorResult(Messages.BlogNull);
            }
            _blogRepository.DeleteWithCategories(T);
            return new SuccessResult(Messages.BlogDeleted);
        }

        public IDataResult<Blog> GetBlogDetailsWithCategories(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                return new ErrorDataResult<Blog>(Messages.UrlNull);
            }

            return new SuccessDataResult<Blog>(_blogRepository.GetBlogDetailsWithCategories(url));
        }

        public IDataResult<List<Blog>> MostPopularBlog()
        {
            return new SuccessDataResult<List<Blog>>(_blogRepository.MostPopularBlog());
        }

        public IDataResult<List<Blog>> GetBlogsByCategory(string categoryUrl, int page, int pageSize)
        {
            if (string.IsNullOrEmpty(categoryUrl))
            {
                return new ErrorDataResult<List<Blog>>(Messages.UrlNull);
            }
            return new SuccessDataResult<List<Blog>>(_blogRepository.GetBlogsByCategory(categoryUrl,page,pageSize));
        }

        public IDataResult<int> GetCount()
        {
            return new SuccessDataResult<int>(_blogRepository.GetBlogCount());
        }

        public IDataResult<int> GetBlogsByCategoryCount(string categoryUrl)
        {
            return new SuccessDataResult<int>(_blogRepository.GetBlogsByCategoryCount(categoryUrl));
        }
    }
}
