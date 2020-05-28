using System;
using Library.Core.Entities;

namespace Library.Core.Repositories
{
    public interface IUserRepository : IRepository<User, Guid>
    {
        User FindByEmail(string email);
    }
}