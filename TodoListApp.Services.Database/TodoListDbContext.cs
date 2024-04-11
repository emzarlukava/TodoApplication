#pragma warning disable
using Microsoft.EntityFrameworkCore;
using TodoListApp.WebApi.Models;
using Task = System.Threading.Tasks.Task;

namespace TodoListApp.Services.Database
{
    public class TodoListDbContext : DbContext
    {
        public TodoListDbContext(DbContextOptions<TodoListDbContext> options) : base(options)
        {
        }

        // DbSet properties for each entity
        public DbSet<TodoList> TodoLists { get; set; }

        public DbSet<Task> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure relationships, indexes, etc.
        }
    }
}
