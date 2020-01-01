using Sahaf.Core.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sahaf.Core.DAL
{
    public class EFRepositoryBase<TEntity, TContext> : IRepository<TEntity>
          where TEntity : BaseEntity, new()
          where TContext : DbContext, new() // olayı kalıtım alma ozelliği vermeyi sağlıyor
    {
        TContext db = EFSingletionContext<TContext>.Instance;

        public void Add(TEntity entity)
        {
            db.Entry(entity).State = EntityState.Added;
            db.SaveChanges();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            return db.Set<TEntity>().Where(filter).SingleOrDefault();
        }


        public ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            if (filter == null)
            {
                return db.Set<TEntity>().ToList();
            }
            else
            {
                return db.Set<TEntity>().Where(filter).ToList();
            }
        }



        public void Remove(TEntity entity)
        {
            db.Entry(entity).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }

    }
}
