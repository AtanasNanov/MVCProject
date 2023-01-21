using EntityFrameworkMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkMVC.Context
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions options) :base(options)
        {

        }
        public DbSet<Blog> Blogs { get; set; }
    }
}
