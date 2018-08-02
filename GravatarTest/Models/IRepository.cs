using System.Collections.Generic;

namespace GravatarTest.Models
{
    public interface IRepository
    {
        List<User> Users { get; set; }
    }
}
