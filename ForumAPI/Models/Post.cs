using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumAPI.Models
{
    public class Post : BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public String Content { get; set; }
        public String Signature { get; set; }
        public int? CreatedBy { get; set; }

        public int TopicID { get; set; }

        public Topic Topic { get; set; }
        public User User { get; set; }
    }
}
