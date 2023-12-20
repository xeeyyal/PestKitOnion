using Microsoft.EntityFrameworkCore;
using PestKitOnionAB104.Domain.Entities;

namespace PestKitOnionAB104.Persistence.Contexts
{
    internal class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<BlogTag> BlogTags { get; set; }
    }
}
