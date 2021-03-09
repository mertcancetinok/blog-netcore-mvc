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
    public class CommentManager : ICommentService
    {
        private ICommentRepository _commentRepository;
        public CommentManager(ICommentRepository commentRepository)
        {
            this._commentRepository = commentRepository;
        }
        public IResult Create(Comment T)
        {
            if (T == null)
            {
                return new ErrorResult(Messages.CommentNull);
            }

            _commentRepository.Create(T);
            return new SuccessResult(Messages.CommentAdded);
            
        }

        public IResult Delete(Comment T)
        {
            if (T == null)
            {
                return new ErrorResult(Messages.CommentNull);
            }

            _commentRepository.Delete(T);
            return new SuccessResult(Messages.CommentDeleted);
        }

        public IDataResult<List<Comment>> GetAll(int pageSize, int page)
        {

            return new SuccessDataResult<List<Comment>>(_commentRepository.GetAll(pageSize,page));
        }

        public IDataResult<Comment> GetById(int id)
        {
            return new SuccessDataResult<Comment>(_commentRepository.GetById(id));            
        }

        public IDataResult<List<Comment>> GetCommentByUrl(string Url)
        {
            if (string.IsNullOrEmpty(Url))
            {
                return new ErrorDataResult<List<Comment>>(Messages.UrlNull);
            }
            return new SuccessDataResult<List<Comment>>(_commentRepository.GetCommentByUrl(Url));
        }

        public IDataResult<int> GetCount()
        {
            return new SuccessDataResult<int>(_commentRepository.GetCount());
        }

        public IDataResult<int> NotApprovedCommentCount()
        {
            return new SuccessDataResult<int>(_commentRepository.NotApprovedCommentCount());
        }

        public IResult Update(Comment T)
        {
            if (T==null)
            {
                return new ErrorResult(Messages.CommentNull);
            }
            _commentRepository.Update(T);
            return new SuccessResult(Messages.CommentUpdated);
        }
    }
}
