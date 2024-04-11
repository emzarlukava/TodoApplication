namespace TodoListApp.WebApi.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public string? Text { get; set; }

        public DateTime CreatedDate { get; set; }

        public int TaskId { get; set; }

        public int UserId { get; set; }

        public Task? Task { get; set; } // Task to which this comment belongs

        public User? User { get; set; } // User who created this comment
    }
}
