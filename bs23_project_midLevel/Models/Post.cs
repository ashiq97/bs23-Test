using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bs23_project_midLevel.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int TotalComments { get; set; }
        public string PostUserName { get; set; }
        public virtual IEnumerable<Comment> Comments { get; set; }

    }
}
