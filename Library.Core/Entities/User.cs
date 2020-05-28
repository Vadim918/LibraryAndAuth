using System;
using System.Collections.Generic;

namespace Library.Core.Entities
{
    public sealed class User : Entity<Guid>
    {
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }

        public User() => UserRoles = new HashSet<UserRole>();
    }
}