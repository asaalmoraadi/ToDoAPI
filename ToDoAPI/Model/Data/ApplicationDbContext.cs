using Microsoft.EntityFrameworkCore;
using ToDoAPI.Model.Entity;
namespace ToDoAPI.Model.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>().HasQueryFilter(p => !p.IsDeleted);
        }
    }
}
