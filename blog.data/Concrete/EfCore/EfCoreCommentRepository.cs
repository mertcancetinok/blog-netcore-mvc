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
    public class EfCoreCommentRepository : EfCoreGenericRepository<Comment, BlogContext>, ICommentRepository
    {
        public int NotApprovedCommentCount()
        {
            using (var context = new BlogContext())
            {
                return context.Comments
                    .Where(c => c.IsApproved == false)
                    .Count();
            }
        }

        List<Comment> ICommentRepository.GetCommentByUrl(string url)
        {
            using (var context = new BlogContext())
            {
                return context.Comments
                    .Include(bc => bc.Blog)
                    .Where(bc => bc.Blog.Url == url)
                    .ToList();
                    
            }
        }
    }
}
