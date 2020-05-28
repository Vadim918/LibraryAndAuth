using Library.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library.Infrastructure.Repositories
{
    internal abstract class Repository<TEntity> where TEntity : Entity
    {
        protected readonly LibraryContext Context;
        protected readonly DbSet<TEntity> DbSet;

        protected Repository(LibraryContext context)
        {
            Context = context;
            DbSet = Context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            DbSet.Add(entity);
        }

        public void Remove(TEntity entity)
        {
            DbSet.Remove(entity);
        }
    }
}