using bs23_project_midLevel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bs23_project_midLevel.ViewModel
{
    public class PostIndexViewModel
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public DateTime Created { get; set; }
        public string PostContent { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
    }
}
