using System.Collections.Generic;

namespace GravatarTest.Models
{
    public class MemoryRepository : IRepository
    {
        public List<User> Users { get; set; }

        public MemoryRepository()
        {
            Users = new List<User>
            {
                new User { Name = "Steve", Age = 22, Email="steve@mail.com" },
                new User { Name = "Elena", Age = 18, Email="elena@mail.com" },
                new User { Name = "Margo", Age = 45, Email="margo@mail.com" }
            };
        }
    }
}
