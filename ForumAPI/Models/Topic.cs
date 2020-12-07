using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumAPI.Models
{
    public enum TopicType
    {
        Topic, Announcement
    }
    public class Topic : BaseEntity
    {

        

        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public String Title { get; set; }
        public int PostCount { get; set; }
        public int ViewCount { get; set; }
        public TopicType TopicType { get; set; }

        public int CategoryID { get; set; }
        public int CreatedBy { get; set; }
        public User User { get; set; }
        public Category Category { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
