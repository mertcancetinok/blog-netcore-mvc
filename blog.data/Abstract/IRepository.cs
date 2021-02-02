using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.data.Abstract
{
    public interface IRepository<TEntity>
    {
        List<TEntity> GetAll();
        void Create(TEntity T);
        void Update(TEntity T);
        void Delete(TEntity T);
        
    }
}
