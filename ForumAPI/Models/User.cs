using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumAPI.Models
{
    public class User : BaseEntity
    {

     

        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public String Username { get; set; }
        public String Password { get; set; }
        public String Name { get; set; }
        public char Sex { get; set; }
        public int Age { get; set; }
        public String Address { get; set; }
        public int PostCount { get; set; }
        public String Signature { get; set; }

        public ICollection<Post> Posts { get; set; }
        public ICollection<Topic> Topics { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }
    }
}
