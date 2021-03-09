using blog.business.Utilities.Results;
using blog.entity;
using System;
using System.Collections.Generic;
using System.Text;


namespace blog.business.Abstract
{
    public interface IBlogService
    {
        IDataResult<List<Blog>> GetBlogsByCategory(string categoryUrl,int pageSize, int page);
        IDataResult<Blog> GetById(int id);
        IDataResult<Blog> GetBlogDetailsWithCategories(string url);
        IDataResult<List<Blog>> MostPopularBlog();
        IDataResult<List<Blog>> GetAll(int pageSize,int page);
        IDataResult<int> GetCount();
        IDataResult<int> GetBlogsByCategoryCount(string categoryUrl);
        IResult Create(Blog T);
        IResult Create(Blog T, int[] categoryIds);
        IResult Update(Blog T);
        IResult Delete(Blog T);
        IResult DeleteWithCategories(Blog T);
    }
}
