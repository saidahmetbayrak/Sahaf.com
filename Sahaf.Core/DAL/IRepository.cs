using Sahaf.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sahaf.Core.DAL
{
    public interface IRepository<TEntity>
        where TEntity : BaseEntity
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
        TEntity Get(Expression<Func<TEntity, bool>> filter);
        
        ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);

    }
}
