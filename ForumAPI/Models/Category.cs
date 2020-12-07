using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumAPI.Models
{
    public class Category : BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }


        public String Name { get; set; }
        public String ImageURL { get; set; }
        public String Description { get; set; }
        public int TopicCount { get; set; }
        public int PostCount { get; set; }
        public DateTime LastPost { get; set; }
        public int GroupCategoryID { get; set; }

        public CategoryGroup CategoryGroup { get; set; }
        public ICollection<Topic> Topics { get; set; }

    }
}
