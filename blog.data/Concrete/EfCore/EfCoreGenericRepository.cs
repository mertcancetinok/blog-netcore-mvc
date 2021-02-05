using blog.data.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.data.Concrete.EfCore
{
    public class EfCoreGenericRepository<TEntity, TContext> : IRepository<TEntity>
        where TEntity:class
        where TContext:DbContext,new()

    {
        public void Create(TEntity T)
        {
            using(var context = new TContext())
            {
                context.Set<TEntity>().Add(T);
                context.SaveChanges();
            }
        }

        public void Delete(TEntity T)
        {
            using(var context = new TContext())
            {
                context.Set<TEntity>().Remove(T);
                context.SaveChanges();
            }
        }

        public List<TEntity> GetAll()
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().ToList();

            }
            
        }

        

        public TEntity GetById(int id)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().Find(id);
                    
            }
        }

        public void Update(TEntity T)
        {
            using (var context = new TContext())
            {
                context.Set<TEntity>().Update(T);
                context.SaveChanges();

            }
        }
    }
}
