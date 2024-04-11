using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListApp.WebApi.Models
{
    public class TodoList
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int OwnerId { get; set; }
        // Navigation property
        public User Owner { get; set; } // Owner of the TodoList
        public ICollection<Task> Tasks { get; set; } // Tasks associated with this TodoList
    }
}
