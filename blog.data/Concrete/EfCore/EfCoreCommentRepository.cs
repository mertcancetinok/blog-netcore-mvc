using blog.data.Abstract;
using blog.entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.data.Concrete.EfCore
{
    public class EfCoreCommentRepository : EfCoreGenericRepository<Comment>, ICommentRepository
    {
        public EfCoreCommentRepository(BlogContext context):base(context)
        {

        }
        private BlogContext BlogContext
        {
            get
            {
                return context as BlogContext;
            }
        }
        public int NotApprovedCommentCount()
        {
            
                return BlogContext.Comments
                    .Where(c => c.IsApproved == false)
                    .Count();
            
        }

        List<Comment> ICommentRepository.GetCommentByUrl(string url)
        {
            
                return BlogContext.Comments
                    .Include(bc => bc.Blog)
                    .Where(bc => bc.Blog.Url == url)
                    .ToList();
                   
            
        }
    }
}
