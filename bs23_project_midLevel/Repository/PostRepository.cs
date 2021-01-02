using bs23_project_midLevel.Interface;
using bs23_project_midLevel.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bs23_project_midLevel.Repository
{
    public class PostRepository : IPost
    {
        private readonly ApplicationDbContext _context;
        public PostRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Post post)
        {
            _context.Add(post);
            _context.SaveChanges();
        }

        public IEnumerable<Post> GetAll()
        {
            return _context.Posts
                           .Include(post => post.User)
                           .Include(post => post.Comments).ThenInclude(Comment => Comment.User);
        }

        public Post GetById(int id)
        {
             return _context.Posts.Where(post => post.Id == id)
                            .Include(post => post.User)
                            .Include(post => post.Comments).ThenInclude(Comment => Comment.User)
                            .First();
        }
    }
}
