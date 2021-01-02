using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bs23_project_midLevel.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedTime { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual Post Post { get; set; }
        public int Like { get; set; }
        public int DisLike { get; set; }
    }
}
