namespace TodoListApp.WebApi.Models
{
    public class Task
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public DateTime DueDate { get; set; }

        public string? Status { get; set; }

        public int AssignedToUserId { get; set; }

        // Navigation properties
        public User? AssignedToUser { get; set; } // User to whom the task is assigned

        public ICollection<Tag>? Tags { get; set; } // Tags associated with this task

        public ICollection<Comment>? Comments { get; set; } // Comments associated with this task
    }
}
