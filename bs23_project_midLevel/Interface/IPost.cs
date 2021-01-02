using bs23_project_midLevel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bs23_project_midLevel.Interface
{
    public interface IPost
    {
        Post GetById(int id);
        IEnumerable<Post> GetAll();
        void Add(Post post);
    }
}
