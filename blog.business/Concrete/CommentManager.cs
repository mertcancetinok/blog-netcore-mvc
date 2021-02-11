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
    public class CommentManager : ICommentService
    {
        private ICommentRepository _commentRepository;
        public CommentManager(ICommentRepository commentRepository)
        {
            this._commentRepository = commentRepository;
        }
        public string ErrorMessage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Create(Comment T)
        {
            _commentRepository.Create(T);
        }

        public void Delete(Comment T)
        {
            _commentRepository.Delete(T);            
        }

        public List<Comment> GetAll()
        {
            return _commentRepository.GetAll();
        }

        public Comment GetById(int id)
        {
            return _commentRepository.GetById(id);
        }

        public List<Comment> GetCommentByUrl(string Url)
        {
            return _commentRepository.GetCommentByUrl(Url);
        }

        public void Update(Comment T)
        {
            _commentRepository.Update(T);
        }

        public bool Validation(Comment entity)
        {
            throw new NotImplementedException();
        }
    }
}
