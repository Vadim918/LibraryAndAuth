using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Library.Core.Entities;
using Library.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Library.Infrastructure.Repositories
{
    internal sealed class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(LibraryContext context) : base(context)
        {
        }

        public User FindByEmail(string email)
        {
            email = email.ToUpper();
            return MakeInclusions().SingleOrDefault(x => x.Email.ToUpper() == email);
        }

        public User Find(Guid id) => MakeInclusions().SingleOrDefault(x => x.Id == id);

        public IEnumerable<User> List(Expression<Func<User, bool>> predicate = null)
        {
            var query = MakeInclusions().AsQueryable();
            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            return query.ToList();
        }

        private IQueryable<User> MakeInclusions() => DbSet.Include(x => x.UserRoles).ThenInclude(x => x.Role);
    }
}