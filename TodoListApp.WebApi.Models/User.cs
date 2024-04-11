namespace TodoListApp.WebApi.Models
{
    public class User
    {
        public int Id { get; }

        public string? Username { get; }

        public string? Email { get; }

        public string? PasswordHash { get; }

        public ICollection<Task>? Tasks { get; } // Tasks assigned to this user

        public ICollection<TodoList>? OwnedTodoLists { get; } // TodoLists owned by this user

        public object? Comments { get; }
    }
}
