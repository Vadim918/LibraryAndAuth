using System;

namespace Library.Core.Entities
{
    public class UserRole
    {
        public Guid UserId { get; set; }
        public int RoleId { get; set; }

        public Role Role { get; set; }
    }
}