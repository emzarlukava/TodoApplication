namespace TodoListApp.WebApi.Models
{
    public class TodoList
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public int OwnerId { get; set; }

        public User? Owner { get; set; } // Owner of the TodoList

        public ICollection<Task>? Tasks { get; } // Tasks associated with this TodoList
    }
}
