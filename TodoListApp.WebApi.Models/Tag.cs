namespace TodoListApp.WebApi.Models
{
    public class Tag
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Color { get; set; }

        public ICollection<Task>? Tasks { get; set; } // Tasks associated with this tag
    }
}
