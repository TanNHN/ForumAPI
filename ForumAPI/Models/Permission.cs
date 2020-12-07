using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumAPI.Models
{
    public class Permission : BaseEntity
    {
        public Permission()
        {
            this.Roles = new HashSet<Role>();
        }

        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public String Name { get; set; }

        public ICollection<Role> Roles { get; set; }
    }
}
