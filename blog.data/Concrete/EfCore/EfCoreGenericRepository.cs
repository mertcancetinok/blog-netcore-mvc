using blog.data.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.data.Concrete.EfCore
{
    public class EfCoreGenericRepository<TEntity> : IRepository<TEntity>
        where TEntity:class        
    {
        protected readonly DbContext context;
        public EfCoreGenericRepository(DbContext ctx)
        {
            context = ctx;
        }
        public void Create(TEntity T)
        {
            
                context.Set<TEntity>().Add(T);
                context.SaveChanges();
            
        }

        public void Delete(TEntity T)
        {
            
                context.Set<TEntity>().Remove(T);
                context.SaveChanges();
            
        }
        public List<TEntity> GetAll()
        {
            
                return context.Set<TEntity>().ToList();

            
        }
        public List<TEntity> GetAll(int pageSize,int page=1)
        {
            
                return context.Set<TEntity>().Skip((page-1)*pageSize).Take(pageSize).ToList();

            
            
        }

        

        public TEntity GetById(int id)
        {
            
                return context.Set<TEntity>().Find(id);
                    
            
        }

        public int GetCount()
        {
            
                return context.Set<TEntity>().Count();
            
        }

        public void Update(TEntity T)
        {
            
                context.Set<TEntity>().Update(T);
                context.SaveChanges();

            
        }
    }
}
