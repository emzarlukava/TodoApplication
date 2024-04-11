namespace TodoListApp.WebApi.Models
{
    public class User
    {
        public int Id { get; set; }

        public string? Username { get; set; }

        public string? Email { get; set; }

        public string? PasswordHash { get; set; }

        public ICollection<Task>? Tasks { get; set; } // Tasks assigned to this user

        public ICollection<TodoList>? OwnedTodoLists { get; set; } // TodoLists owned by this user

        public object? Comments { get; internal set; }
    }
}
