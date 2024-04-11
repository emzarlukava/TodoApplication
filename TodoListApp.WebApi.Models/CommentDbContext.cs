#pragma warning disable
using Microsoft.EntityFrameworkCore;

namespace TodoListApp.WebApi.Models
{
    public class CommentDbContext : DbContext
    {
        public CommentDbContext(DbContextOptions<CommentDbContext> options)
            : base(options)
        {
        }

        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure relationships if needed
            _ = modelBuilder.Entity<Comment>()
                .HasOne(c => c.Task)
                .WithMany(t => t.Comments)
                .HasForeignKey(c => c.TaskId);

            _ = modelBuilder.Entity<Comment>()
                .HasOne(c => c.User);
        }
    }
}
